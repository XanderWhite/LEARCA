using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learca
{
    /// <summary>
    /// Создатель списка карточек для изучения на основе настроек пользователя
    /// </summary>
    class LearningCardListCreator
    {
        /// <summary>
        /// настройки пользователя
        /// </summary>
        private readonly LearningSettings settings;

        private Teacher Teacher { get; set; }

        /// <summary>
        /// Карточки для изучения только с одной стороной
        /// </summary>
        private readonly List<Card> oneSideCards;

        /// <summary>
        /// Карточки для изучения с двумя сторонами по принципу вопрос - ответ
        /// </summary>
        private readonly List<Card> twoSidesCards;

        /// <summary>
        /// Карточки отмеченные для изучения обеих сторон
        /// </summary>
        private readonly List<Card> askBothSidesCards;

        public LearningCardListCreator(LearningSettings settings, Teacher teacher)
        {
            this.Teacher = teacher ?? throw new ArgumentNullException("Teacher teacher не может быть null");
            this.settings = settings ?? throw new ArgumentNullException("LearningSettings learningSettings не может быть null");

            oneSideCards = new List<Card>();
            twoSidesCards = new List<Card>();
            askBothSidesCards = new List<Card>();
        }

        /// <summary>
        /// Создать список карточек для изучения
        /// </summary>
        public List<AbstractLearningCard> CreateLearningCards()
        {
            var learningCards = new List<AbstractLearningCard>();

            oneSideCards.Clear();
            twoSidesCards.Clear();
            askBothSidesCards.Clear();

            SortCardsFrom(settings.SelectedDecks);
            SortCardsFrom(settings.SelectedChosenDecks);

            if (settings.LearnInformationCards)
                learningCards.AddRange(CreateOneSideLearningCards());

            if (settings.LearnQACards)
                learningCards.AddRange(CreateTwoSidesLearningCards());

            if (settings.LearnBothSidesCards)
                learningCards.AddRange(CreateAskBothSidesLearningCards());

            Shuffle(learningCards);

            if (askBothSidesCards.Count > 0 && !settings.LearnOnlyOneSide)
                TurnSomeAskBothSidesCards(learningCards);

            return learningCards;
        }

        /// <summary>
        /// Сортируем карточки из колоды по спискам oneSideCards, twoSidesCards, askBothSidesCards
        /// </summary>                              
        /// <param name="decks"></param>             
        private void SortCardsFrom(SelectedAbstractDecksToLearn decks)
        {
            foreach (var deck in decks)
            {
                foreach (var card in deck)
                {
                    if (card.GetOneFilledSide() == null)
                        continue;

                    if (card.LeftSide.IsEmpty || card.RightSide.IsEmpty)
                    {
                        if (!oneSideCards.Contains(card))
                            oneSideCards.Add(card);
                    }
                    else if (card.AskBoth)
                    {
                        if (!askBothSidesCards.Contains(card))
                            askBothSidesCards.Add(card);
                    }
                    else if (!twoSidesCards.Contains(card))
                    {
                        twoSidesCards.Add(card);
                    }
                }
            }
        }

        /// <summary>
        /// Создаем карточки для изучения из oneSideCards
        /// </summary>
        /// <returns></returns>
        private IEnumerable<AbstractLearningCard> CreateOneSideLearningCards()
        {
            foreach (var card in oneSideCards)
            {
                yield return new LearningOneSideCard(card, Teacher);
            }
        }

        /// <summary>
        /// Создаем карточки для изучения из twoSidesCards
        /// </summary>
        /// <returns></returns>
        private IEnumerable<AbstractLearningCard> CreateTwoSidesLearningCards()
        {
            foreach (var card in twoSidesCards)
            {
                bool isTyping = settings.TypeAnswers && card.IsTyping;

                yield return new LearningTwoSidesCard_LearnOneSide(card, isTyping, Teacher, true);
            }
        }

        /// <summary>
        /// Создаем карточки для изучения из askBothSidesCards
        /// </summary>
        /// <returns></returns>
        private IEnumerable<AbstractLearningCard> CreateAskBothSidesLearningCards()
        {
            bool leftSideIsQuestion = (settings.LearnOnlyOneSide) ? settings.StartingSide == BeginLearnWith.LeftSide : true;
            bool learnBothSides = !settings.LearnOnlyOneSide;

            foreach (var card in askBothSidesCards)
            {
                bool isTyping = settings.TypeAnswers && card.IsTyping;

                yield return new LearningTwoSidesCard_LearnBothSides(card, isTyping, Teacher, leftSideIsQuestion, learnBothSides);
            }
        }

        /// <summary>
        /// Перемешиваем карточки для изучения
        /// </summary>
        /// <param name="learningCards"></param>
        private void Shuffle(List<AbstractLearningCard> learningCards)
        {
            Random rand = new Random();

            for (int i = 0; i < learningCards.Count - 1; i++)
            {
                int index = rand.Next(i, learningCards.Count);

                var tempCard = learningCards[i];
                learningCards[i] = learningCards[index];
                learningCards[index] = tempCard;
            }
        }

        /// <summary>
        /// Переворачиавем карточки для изучения обоих сторон относительно настроек пользователя
        /// </summary>
        /// <param name="learningCards"></param>
        private void TurnSomeAskBothSidesCards(List<AbstractLearningCard> learningCards)
        {
            var turnedCards = new bool[askBothSidesCards.Count];

            int leftCount = settings.Percent_LeftSide * askBothSidesCards.Count / 100;

            for (int i = 0; i < leftCount; i++)
            {
                turnedCards[i] = true;
            }

            if (settings.StartingSide == BeginLearnWith.MixSides && leftCount > 0 && leftCount < askBothSidesCards.Count)
            {
                Random rand = new Random();

                for (int i = 0; i < turnedCards.Length - 1 && leftCount > 0; i++)
                {
                    int randIndex = rand.Next(i, turnedCards.Length);

                    if (turnedCards[i] != turnedCards[randIndex])
                    {
                        turnedCards[i] = turnedCards[randIndex];
                        turnedCards[randIndex] = !turnedCards[randIndex];
                    }

                    if (turnedCards[randIndex])
                        leftCount--;
                }
            }

            int index = 0;

            foreach (var learningCard in learningCards)
            {
                if (learningCard is LearningTwoSidesCard_LearnBothSides card)
                {
                    card.LeftSideIsQuestion = turnedCards[index++];

                    if (index == turnedCards.Length)
                        break;
                }
            }
        }
    }
}
