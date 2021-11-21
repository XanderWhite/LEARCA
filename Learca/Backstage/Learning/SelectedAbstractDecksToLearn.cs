using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learca
{
    /// <summary>
    /// Выбранные колоды для изучения
    /// </summary>
    public class SelectedAbstractDecksToLearn : IEnumerable<AbstractDeck>
    {
        protected readonly List<AbstractDeck> selectedAbstractDecks;

        /// <summary>
        /// Колоды из которых происходит выборка
        /// </summary>
        public AbstractDeckSet AbstractDeckSet { get; private set; }
        public int Count => selectedAbstractDecks.Count;

        public SelectedAbstractDecksToLearn(AbstractDeckSet abstractDecks)
        {
            this.AbstractDeckSet = abstractDecks ?? throw new ArgumentNullException("AbstractDeckSet abstractDecks не может быть null");
            selectedAbstractDecks = new List<AbstractDeck>();
        }

        /// <summary>
        /// Добавление Колоды в список выбранных колод
        /// </summary>
        /// <param name="deck"></param>
        public void Add(AbstractDeck deck)
        {
            if (!selectedAbstractDecks.Contains(deck))
            {
                selectedAbstractDecks.Add(deck);
                deck.RemoveDeckEvent += Remove;
            }
        }

        /// <summary>
        /// Удаление Колоды из списка выбранных колод
        /// </summary>
        /// <param name="deck"></param>
        public void Remove(AbstractDeck deck)
        {
            if (deck == null)
                throw new ArgumentNullException("AbstractDeck deck не может быть null");

            deck.RemoveDeckEvent -= Remove;

            selectedAbstractDecks.Remove(deck);
        }

        /// <summary>
        /// Удаление всех колод из списка выбранных колод
        /// </summary>
        public void RemoveAllDecks()
        {
            for (int i = selectedAbstractDecks.Count - 1; i >= 0; i--)
            {
                Remove(selectedAbstractDecks[i]);
            }
        }

        public IEnumerator<AbstractDeck> GetEnumerator()
        {
            return selectedAbstractDecks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
