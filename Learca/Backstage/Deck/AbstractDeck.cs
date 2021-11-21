using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Learca.Properties;
using System.Globalization;
using System.Xml;
using System.Reflection;
using System.Windows.Forms;

namespace Learca
{
    public delegate void RemoveDeckDel(AbstractDeck deck);

    public abstract class AbstractDeck : IEnumerable<Card>
    {
        public event RemoveDeckDel RemoveDeckEvent = null;

        /// <summary>
        /// Список карт в колоде
        /// </summary>
        protected List<Card> cards = new List<Card>();
        DateTime startPoint;

        public AbstractDeckSet ParentDeckSet { get; protected set; }
        public string Name { get; set; }
        public DateTime StartPoint
        {
            get
            {
                return startPoint;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("StartPoint не может быть null");
                else
                    startPoint = value;
            }
        }
        public string Description { get; set; }
        public int Index
        {
            get
            {
                if (ParentDeckSet == null)
                    return -1;

                return ParentDeckSet.GetIndexOf(this);
            }
        }
        public int CardCount => cards.Count;
        public bool IsSaved => ParentDeckSet.Contains(this);

        public Card this[int index]
        {
            get
            {
                if (index >= 0 && index < cards.Count)
                    return cards[index];

                return null;
            }
        }

        public AbstractDeck(AbstractDeckSet parentDeckSet)
        {
            ParentDeckSet = parentDeckSet ?? throw new ArgumentNullException("AbstractDeckSet parentDeckSet не может быть null");
            StartPoint = DateTime.Now;
            Name = Description = string.Empty;
        }

        /// <summary>
        /// Сохранение колоды в Набор колод
        /// </summary>
        public void SaveDeck()
        {
            if (!IsSaved)
                ParentDeckSet.Add(this);
        }

        /// <summary>
        /// Добавление карты в колоду
        /// </summary>
        /// <param name="card"></param>
        public abstract void Save(Card card);

        /// <summary>
        /// Проверка имеются ли в описании Колоды совпадения с value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsMatch(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return true;

            return Name.Trim().ToLower().Contains(value)
                || Description.Trim().ToLower().Contains(value)
                || StartPoint.ToLongDateString().Trim().ToLower().Contains(value);
        }

        /// <summary>
        /// Получить индекс карты в колоде
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public int GetIndexOf(Card card)
        {
            return cards.IndexOf(card);
        }

        /// <summary>
        /// Входит ли карта в колоду
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool Contains(Card card)
        {
            return cards.Contains(card);
        }

        /// <summary>
        /// Содержатся ли карты из передаваемой колоды в текущей колоде
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        public bool ContainsAny(IEnumerable<Card> cards)
        {
            foreach (var card in cards)
            {
                if (Contains(card))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Удаление всех карт
        /// </summary>
        public void Clear()
        {
            while (cards.Count > 0)
            {
                Remove(cards[0]);
            }
        }

        /// <summary>
        /// Создание формы для редактирования колоды
        /// </summary>
        /// <param name="mainForm"></param>
        /// <returns></returns>
        public abstract Form CreateFormToEditDeck(MainForm mainForm);

        /// <summary>
        /// Удаление карты
        /// </summary>
        /// <param name="card"></param>
        public abstract void Remove(Card card);

        /// <summary>
        /// Сохранение карт в текущую колоду
        /// </summary>
        /// <param name="cards"></param>
        public void Save(IEnumerable<Card> cards)
        {
            foreach (var card in cards)
            {
                Save(card);
            }
        }

        /// <summary>
        /// Удаление колоды
        /// </summary>
        public void RemoveDeck()
        {
            ParentDeckSet.Remove(this);
        }

        /// <summary>
        /// Запустить Событие Удаления Колоды
        /// </summary>
        public void InvokeRemoveDeckEvent()
        {
            if (RemoveDeckEvent != null)
                RemoveDeckEvent.Invoke(this);
        }

        /// <summary>
        /// Запись колоды в Xml-документ
        /// </summary>
        /// <param name="writer"></param>
        public void WriteXml(XmlTextWriter writer)
        {
            if (writer == null)
                throw new ArgumentNullException("XmlTextWriter writer не может быть null");

            writer.WriteStartElement(this.GetType().Name);
            {
                writer.WriteStartAttribute("Name");
                writer.WriteString(Name);
                writer.WriteEndAttribute();

                writer.WriteStartAttribute("StartingPoint");
                writer.WriteString(StartPoint.ToString("D", new CultureInfo("en-EN")));
                writer.WriteEndAttribute();

                writer.WriteStartElement("Description");
                writer.WriteString(Description);
                writer.WriteEndElement();

                WriteXml_Cards(writer);
            }
            writer.WriteEndElement();
        }

        /// <summary>
        /// Запись карт из колоды в Xml-документ
        /// </summary>
        /// <param name="writer"></param>
        protected abstract void WriteXml_Cards(XmlTextWriter writer);

        /// <summary>
        /// Инициализация Колоды из Xml-документа
        /// </summary>
        /// <param name="node">Узел в Xml-документе</param>
        public void InitFromXmlNode(XmlNode node)
        {
            if (node == null)
                throw new ArgumentNullException("XmlNode node не может быть null");

            Name = node.Attributes["Name"].Value;
            StartPoint = DateTime.Parse(node.Attributes["StartingPoint"].Value);

            foreach (XmlNode childNode in node.ChildNodes)
            {
                if (childNode.Name == "Description")
                    Description = childNode.InnerText;
                else
                    InitCardsFromXmlNode(childNode);
            }
        }

        /// <summary>
        /// Инициализация Карт Колоды из Xml-документа
        /// </summary>
        /// <param name="node">Узел в Xml-документе</param>
        protected abstract void InitCardsFromXmlNode(XmlNode node);

        public IEnumerator<Card> GetEnumerator()
        {
            return cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
