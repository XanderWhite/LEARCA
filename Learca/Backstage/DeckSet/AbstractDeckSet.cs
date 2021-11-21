using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;

namespace Learca
{
    public abstract class AbstractDeckSet : IEnumerable<AbstractDeck>
    {
        /// <summary>
        /// Список колод в Наборе
        /// </summary>
        protected List<AbstractDeck> decks = new List<AbstractDeck>();

        /// <summary>
        /// Количество колод в Наборе
        /// </summary>
        public int Count => decks.Count;

        /// <summary>
        /// Количество карт в Наборе
        /// </summary>
        public int CardCount
        {
            get
            {
                int count = 0;

                foreach (var deck in decks)
                {
                    count += deck.CardCount;
                }

                return count;
            }
        }

        /// <summary>
        /// Количество пустых колод в Наборе
        /// </summary>
        public int EmptyDeckCount
        {
            get
            {
                int count = 0;

                foreach (var deck in decks)
                {
                    if (deck.CardCount == 0)
                        count++;
                }

                return count;
            }
        }

        public AbstractDeck this[int index]
        {
            get
            {
                if (index >= 0 && index < decks.Count)
                    return decks[index];

                return null;
            }
        }

        /// <summary>
        /// Количество карт без колод содержащих переданные карты 
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public int GetCardsCountWithoutDecksContaining(IEnumerable<Card> cards)
        {
            int count = 0;

            foreach (var deck in decks)
            {
                if (!deck.ContainsAny(cards))
                    count += deck.CardCount;
            }

            return count;
        }

        /// <summary>
        /// Индекс колоды в Наборе
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        public int GetIndexOf(AbstractDeck deck)
        {
            return decks.IndexOf(deck);
        }

        /// <summary>
        /// Добавление в Набор колоды
        /// </summary>
        /// <param name="deck"></param>
        public void Add(AbstractDeck deck)
        {
            if (!decks.Contains(deck))
                decks.Add(deck);
        }

        /// <summary>
        /// Удаление колоды из Набора
        /// </summary>
        /// <param name="deck"></param>
        public void Remove(AbstractDeck deck)
        {
            if (deck == null)
                throw new ArgumentNullException("AbstractDeck deck не может быть null");

            deck.InvokeRemoveDeckEvent();
            deck.Clear();
            decks.Remove(deck);
        }

        /// <summary>
        /// Удалить пустые колоды из Набора
        /// </summary>
        public void RemoveEmptyDecks()
        {
            for (int i = 0; i < decks.Count; i++)
            {
                if (decks[i].CardCount == 0)
                {
                    Remove(decks[i]);
                    i--;
                }
            }
        }

        public bool Contains(AbstractDeck deck)
        {
            return decks.Contains(deck);
        }

        /// <summary>
        /// Получить все карточки из набора колод
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Card> GetAllCards()
        {
            foreach (var deck in decks)
            {
                foreach (var card in deck)
                {
                    yield return card;
                }
            }
        }

        /// <summary>
        /// Создать колоду
        /// </summary>
        /// <returns></returns>
        public abstract AbstractDeck CreateDeck();

        /// <summary>
        /// Запись Набора колод в Xml-документ
        /// </summary>
        /// <param name="writer"></param>
        public void WriteXml(XmlTextWriter writer)
        {
            if (writer == null)
                throw new ArgumentNullException("XmlTextWriter writer не может быть null");

            writer.WriteStartElement(this.GetType().Name);

            foreach (var deck in decks)
            {
                deck.WriteXml(writer);
            }

            writer.WriteEndElement();
        }

        /// <summary>
        /// Инициализация Набора колод из Xml-документа
        /// </summary>
        /// <param name="node"></param>
        public void InitFromXmlNode(XmlNode node)
        {
            if (node == null)
                throw new ArgumentNullException("XmlNode node не может быть null");

            //if (node.Name != this.GetType().Name)
            //   return;

            foreach (XmlNode childNode in node)
            {
                var deck = CreateDeck();

                deck.InitFromXmlNode(childNode);

                if (deck.CardCount == 0)
                    Add(deck);
            }
        }

        public IEnumerator<AbstractDeck> GetEnumerator()
        {
            return decks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
