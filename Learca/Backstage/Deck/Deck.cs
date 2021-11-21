using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Learca
{
    public class Deck : AbstractDeck
    {
        public Deck(DeckSet parent) : base(parent)
        {

        }

         /// <summary>
        /// Удаление карты
        /// </summary>
        /// <param name="card"></param>
        public override void Remove(Card card)
        {
            if (card == null)
                throw new ArgumentNullException("Card card не может быть null");

            card.InvokeRemoveCardEvent();
            card.Clear();
            cards.Remove(card);
        }

        /// <summary>
        /// Добавление карты в текущую колоду
        /// </summary>
        /// <param name="card"></param>
        public override void Save(Card card)
        {
            if (card == null)
                throw new ArgumentNullException("Card card не может быть null");

            if (card.ParentDeck != null && card.ParentDeck != this)
                card.ParentDeck.cards.Remove(card);

            card.ParentDeck = this;

            if (!cards.Contains(card))
            {
                cards.Add(card);
            }

            SaveDeck();
        }

        /// <summary>
        /// Создание новой карты
        /// </summary>
        /// <returns></returns>
        public Card CreateCard()
        {
            return new Card(this);
        }

        /// <summary>
        /// Запись карт из колоды в Xml-документ
        /// </summary>
        /// <param name="writer"></param>
        protected override void WriteXml_Cards(XmlTextWriter writer)
        {
            if (writer == null)
                throw new ArgumentNullException("XmlTextWriter writer не может быть null");

            foreach (var card in cards)
            {
                card.WriteXml(writer);
            }
        }

        /// <summary>
        /// Инициализация Карт Колоды из Xml-документа
        /// </summary>
        /// <param name="node">Узел в Xml-документе</param>
        protected override void InitCardsFromXmlNode(XmlNode node)
        {
            if (node == null)
                throw new ArgumentNullException("XmlNode node не может быть null");

            if (node.Name != "Card")
                return;

            Card card = CreateCard();

            card.InitFromXmlNode(node);

            Save(card);
        }

        /// <summary>
        /// Создание формы для редактирования колоды
        /// </summary>
        /// <param name="mainForm"></param>
        /// <returns></returns>
        public override Form CreateFormToEditDeck(MainForm mainForm)
        {
            return new Form_Deck(mainForm, this);
        }

        public override string ToString()
        {
            return "Deck";
        }

        
    }
}
