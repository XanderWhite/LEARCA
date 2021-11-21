using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learca
{
    /// <summary>
    /// Класс Учителя. Управление изучаемыми карточками. 
    /// learningCards - карточки для изучения.
    /// historyCards - карточки, как результат просмотра пользователя.
    /// cardsForChosenDeck - Карточки которые сохранятся в Избранной колоде в конце сессии, отмеченые пользователем как repeat или с ошибочными ответами от пользователя.
    /// repeatNextPassCards - Карточки, которые будут повторены после успешного прохода текущих карточек, если были отмечены пользователем как repeat или с ошибочными ответами от пользователя
    /// </summary>
    public class Teacher
    {
        /// <summary>
        /// Изучаемые карточки.
        /// </summary>
        private readonly List<AbstractLearningCard> learningCards;

        private readonly List<HistoryCard> historyCards;

        /// <summary>
        /// Карточки которые сохранятся в Избранной колоде в конце сессии,
        /// отмеченые пользователем как repeat или с ошибочными ответами от пользователя
        /// </summary>
        private readonly List<Card> cardsForChosenDeck;

        /// <summary>
        /// Карточки, которые будут повторены после успешного прохода текущих карточек,
        /// если были отмечены пользователем как repeat или с ошибочными ответами от пользователя
        /// </summary>
        private readonly List<AbstractLearningCard> repeatNextPassCards;

        public bool CurrentPassIsEmpty => learningCards.Count == 0;
        public bool CurrentCardIsLastCard => learningCards.Count == 1;
        public int LearningCardsCount => learningCards.Count;
        public int СardsForChosenDeckCount => cardsForChosenDeck.Count;

        /// <summary>
        /// Текущая карточка для изучения
        /// </summary>
        public AbstractLearningCard CurrentCard
        {
            get
            {
                if (learningCards.Count == 0)
                    return null;

                return learningCards[0];
            }
        }

        public Teacher(LearningSettings settings)
        {
            historyCards = new List<HistoryCard>();
            cardsForChosenDeck = new List<Card>();
            repeatNextPassCards = new List<AbstractLearningCard>();

            var creator = new LearningCardListCreator(settings, this);
            learningCards = creator.CreateLearningCards();
        }

        public bool CardsForChosenDeckContains(AbstractLearningCard learningCard)
        {
            if (learningCard == null)
                throw new ArgumentNullException("AbstractLearningCard learningCard не может быть null");

            return cardsForChosenDeck.Contains(learningCard.Card);
        }

        /// <summary>
        /// Перенос текущей карточки в конец очереди
        /// </summary>
        public void SkipCurrentCard()
        {
            learningCards.Add(CurrentCard);
            learningCards.RemoveAt(0);
        }

        /// <summary>
        /// Удаление текщей карты из списка для изучения.
        /// Если карта находится в repeatNextPassCards, то возвращается ее копия в конец очереди для изучения и удаляется из repeatNextPassCards
        /// </summary>
        public void RemoveCurrentCard()
        {
            var repeatNextPassCard = GetCardFromRepeatNextPassCards(learningCards[0]);

            if (repeatNextPassCard != null)
            {
                learningCards.Add(learningCards[0].Clone());
                repeatNextPassCards.Remove(repeatNextPassCard);
            }

            learningCards.RemoveAt(0);
        }

        /// <summary>
        /// обавление Карточки в learningCards для еще одного повторения.
        /// Добавление карточки в cardsForChosenDeck
        /// </summary>
        /// <param name="learningCard"></param>
        public void Repeat(AbstractLearningCard learningCard)
        {
            if (learningCard == null)
                throw new ArgumentNullException("AbstractLearningCard learningCard не может быть null");

            learningCards.Add(learningCard);

            AddToCardsForChosenDeck(learningCard);
        }

        /// <summary>
        /// Добавление карточки в cardsForChosenDeck
        /// </summary>
        /// <param name="learningCard"></param>
        public void AddToCardsForChosenDeck(AbstractLearningCard learningCard)
        {
            if (learningCard == null)
                throw new ArgumentNullException("AbstractLearningCard learningCard не может быть null");

            if (!cardsForChosenDeck.Contains(learningCard.Card))
                cardsForChosenDeck.Add(learningCard.Card);
        }

        /// <summary>
        /// Добавление карточки в repeatNextPassCards для повторения.
        /// Добавление карточки в cardsForChosenDeck
        /// </summary>
        /// <param name="learningCard"></param>
        public void RepeatNextPass(AbstractLearningCard learningCard)
        {
            if (learningCard == null)
                throw new ArgumentNullException("AbstractLearningCard learningCard не может быть null");

            AddToCardsForChosenDeck(learningCard);

            if (GetCardFromRepeatNextPassCards(learningCard) == null)
                repeatNextPassCards.Add(learningCard);
        }

        /// <summary>
        /// Добавление карточки к historyCards
        /// </summary>
        /// <param name="historyCard"></param>
        public void AddToHistory(HistoryCard historyCard)
        {
            if (historyCard == null)
                throw new ArgumentNullException("HistoryCard historyCard не может быть null");

            historyCards.Add(historyCard);
        }

        /// <summary>
        /// Получение последней карточки из истории(карточки уже показанной пользователю)
        /// </summary>
        /// <returns></returns>
        public HistoryCard GetLastHistoryCard()
        {
            if (historyCards.Count == 0)
                return null;

            return historyCards.Last();
        }

        /// <summary>
        /// Получение карточки из repeatNextPassCards, если такой нет, то вернуть null
        /// </summary>
        /// <param name="learningCard"></param>
        /// <returns></returns>
        public AbstractLearningCard GetCardFromRepeatNextPassCards(AbstractLearningCard learningCard)
        {
            if (learningCard == null)
                throw new ArgumentNullException("AbstractLearningCard learningCard не может быть null");

            foreach (var card in repeatNextPassCards)
            {
                if (learningCard.Equals(card))
                    return card;
            }

            return null;
        }

        /// <summary>
        /// Имеится ли карта в списках для изучения
        /// Т.е. Содержится ли карта в learningCards или в repeatNextPassCards.
        /// </summary>
        /// <param name="learningCard"></param>
        /// <returns></returns>
        public bool IsExists(AbstractLearningCard learningCard)
        {
            if (learningCard == null)
                throw new ArgumentNullException("AbstractLearningCard learningCard не может быть null");

            if (GetCardFromRepeatNextPassCards(learningCard) != null)
                return true;

            foreach (var card in learningCards)
            {
                if (card.Equals(learningCard))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Создание Избранной колоды из списка cardsForChosenDeck
        /// </summary>
        /// <returns></returns>
        public AbstractDeck CreateChosenDeck()
        {
            var chosenDeck = Database.ChosenDeckSet.CreateDeck();

            foreach (Card card in cardsForChosenDeck)
            {
                chosenDeck.Save(card);
            }

            return chosenDeck;
        }
    }
}
