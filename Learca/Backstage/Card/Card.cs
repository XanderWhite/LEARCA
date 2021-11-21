using Learca.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Learca
{
    public delegate void RemoveCardDel(Card card);

    /// <summary>
    /// Карточка
    /// </summary>
    public class Card
    {
        public event RemoveCardDel RemoveCardEvent = null;

        public Deck ParentDeck { get; set; }
        public CardSide LeftSide { get; set; }
        public CardSide RightSide { get; set; }

        /// <summary>
        /// Является ли карточка, карточкой с одной заполненной стороной
        /// </summary>
        public bool IsOneSideCard
        {
            get
            {
                if (IsEmpty)
                    return false;

                return LeftSide.IsEmpty || RightSide.IsEmpty;
            }
        }

        /// <summary>
        /// Является ли карточка пустой, т.е. ни одна сторона не заполненна
        /// </summary>
        public bool IsEmpty => GetOneFilledSide() == null;

        /// <summary>
        /// Печатать текст во время ответа
        /// </summary>
        public bool IsTyping { get; set; }

        /// <summary>
        /// Спрашивать обе стороны карты, если они заполненны
        /// </summary>
        public bool AskBoth { get; set; }

        public string Hint { get; set; }

        /// <summary>
        /// Добавлена ли карта в колоду
        /// </summary>
        public bool IsSaved
        {
            get
            {
                return ParentDeck.Contains(this);
            }
        }

        public int Index
        {
            get
            {
                if (ParentDeck == null)
                    return -1;

                return ParentDeck.GetIndexOf(this);
            }
        }

        public Card(Deck parentDeck)
        {
            ParentDeck = parentDeck ?? throw new ArgumentNullException("Deck parentDeck не может быть null");

            LeftSide = CreateCardSide(Side.Left);
            RightSide = CreateCardSide(Side.Right);
            Hint = string.Empty;
        }

        /// <summary>
        /// Сохранить карту в колоду
        /// </summary>
        public void SaveCard()
        {
            if (!IsSaved)
                ParentDeck.Save(this);
        }

        /// <summary>
        /// Очистка сторон карты в том числе и удаление файлов изображений связанных с картой
        /// </summary>
        public void Clear()
        {
            LeftSide.Clear();
            RightSide.Clear();
        }

        /// <summary>
        /// Получить одну заполненную сторону карты.
        /// Если такой нет, то возвращается null
        /// </summary>
        /// <returns></returns>
        public CardSide GetOneFilledSide()
        {
            if (!LeftSide.IsEmpty)
                return LeftSide;

            if (!RightSide.IsEmpty)
                return RightSide;

            return null;
        }

        /// <summary>
        /// Удаление текущей карты из Колоды вместе с выполнением RemoveCardEvent
        /// </summary>
        public void RemoveCard()
        {
            ParentDeck.Remove(this);
        }

        /// <summary>
        /// Запустить Событие Удаления Карты
        /// </summary>
        public void InvokeRemoveCardEvent()
        {
            if (RemoveCardEvent != null)
                RemoveCardEvent.Invoke(this);
        }

        /// <summary>
        /// Создание стороны карты
        /// </summary>
        /// <param name="side"></param>
        /// <returns></returns>
        public CardSide CreateCardSide(Side side)
        {
            return new CardSide(this, side);
        }

        /// <summary>
        /// Запись Карты в Xml-документ
        /// </summary>
        /// <param name="writer"></param>
        public void WriteXml(XmlTextWriter writer)
        {
            if (writer == null)
                throw new ArgumentNullException("XmlTextWriter writer не может быть null");

            writer.WriteStartElement("Card");
            {
                writer.WriteStartAttribute("AskBoth");
                writer.WriteString(AskBoth.ToString());
                writer.WriteEndAttribute();

                writer.WriteStartAttribute("IsTyping");
                writer.WriteString(IsTyping.ToString());
                writer.WriteEndAttribute();

                writer.WriteStartElement("Hint");
                writer.WriteString(Hint);
                writer.WriteEndElement();


                LeftSide.WriteXml(writer);
                RightSide.WriteXml(writer);
            }
            writer.WriteEndElement();
        }

        /// <summary>
        /// Инициализация Карты из Xml-документа
        /// </summary>
        /// <param name="node">Узел в Xml-документе</param>
        public void InitFromXmlNode(XmlNode node)
        {
            if (node == null)
                throw new ArgumentNullException("XmlNode node не может быть null");

            if (node.Name != "Card") return;

            AskBoth = bool.Parse(node.Attributes["AskBoth"].Value);
            IsTyping = bool.Parse(node.Attributes["IsTyping"].Value);

            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.Name == "Hint")
                    Hint = childNode.InnerText;

                else if (childNode.Name == "Left")
                {
                    if (LeftSide == null)
                        LeftSide = CreateCardSide(Side.Left);

                    LeftSide.InitFromXmlNode(childNode);
                }
                else if (childNode.Name == "Right")
                {
                    if (RightSide == null)
                        RightSide = CreateCardSide(Side.Right);

                    RightSide.InitFromXmlNode(childNode);
                }
            }
        }
    }
}
