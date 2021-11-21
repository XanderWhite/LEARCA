using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Learca
{
    public class ChosenDeck : AbstractDeck
    {
        public ChosenDeck(ChosenDeckSet parent) : base(parent)
        {

        }        

        /// <summary>
        /// Добавление карты в текущую колоду
        /// </summary>
        /// <param name="card"></param>
        public override void Save(Card card)
        {
            if (card == null)
                throw new ArgumentNullException("Card card не может быть null");

            if (!cards.Contains(card))
            {
                cards.Add(card);
                card.RemoveCardEvent += Remove;

                SaveDeck();
            }
        }

        /// <summary>
        /// Удаление карты из колоды
        /// </summary>
        /// <param name="card"></param>
        public override void Remove(Card card)
        {
            if (card == null)
                throw new ArgumentNullException("Card card не может быть null");

            card.RemoveCardEvent -= Remove;
            cards.Remove(card);
        }

        /// <summary>
        /// Получение пар(ключ-значение). Индекс Колоды - Индекс Карты
        /// </summary>
        /// <returns></returns>
        private Dictionary<int, int> GetIndecies()
        {
            var dict = new Dictionary<int, int>();

            foreach (Card card in cards)
            {
                dict.Add(card.ParentDeck.Index, card.Index);
            }

            return dict;
        }

        /// <summary>
        /// Запись карт из колоды в Xml-документ
        /// </summary>
        /// <param name="writer"></param>
        protected override void WriteXml_Cards(XmlTextWriter writer)
        {
            if (writer == null)
                throw new ArgumentNullException("XmlTextWriter writer не может быть null");

            writer.WriteStartElement("Cards");
            foreach (var pair in GetIndecies())
            {
                writer.WriteStartElement("Card");
                {
                    writer.WriteStartAttribute("DeckIndex");
                    writer.WriteString(pair.Key.ToString());
                    writer.WriteEndAttribute();

                    writer.WriteStartAttribute("CardIndex");
                    writer.WriteString(pair.Value.ToString());
                    writer.WriteEndAttribute();
                }
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        /// <summary>
        /// Инициализация Карт Колоды из Xml-документа
        /// </summary>
        /// <param name="node">Узел в Xml-документе</param>
        protected override void InitCardsFromXmlNode(XmlNode node)
        {
            if (node == null)
                throw new ArgumentNullException("XmlNode node не может быть null");

            if (node.Name != "Cards") return;

            foreach (XmlNode childNode in node.ChildNodes)
            {
                int deckIndex = int.Parse(childNode.Attributes["DeckIndex"].Value);
                int cardIndex = int.Parse(childNode.Attributes["CardIndex"].Value);

                Card card = Database.DeckSet[deckIndex][cardIndex];

                Save(card);
            }
        }

        /// <summary>
        /// Создание формы для редактирования Избранной колоды
        /// </summary>
        /// <param name="mainForm"></param>
        /// <returns></returns>
        public override Form CreateFormToEditDeck(MainForm mainForm)
        {
            return new Form_ChosenDeck(mainForm, this);
        }

        public override string ToString()
        {
            return "Chosen Deck";
        }
    }
}
