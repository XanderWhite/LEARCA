using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learca
{
    /// <summary>
    /// Настройки обучения
    /// </summary>
    public class LearningSettings
    {
        private bool learnOnlyOneSide;
        private BeginLearnWith startSide;
        private int percent_LeftSide;
        private int percent_RightSide;

        /// <summary>
        /// Колоды выбранные из Колод DeckSet
        /// </summary>
        public SelectedAbstractDecksToLearn SelectedDecks { get; private set; }

        /// <summary>
        /// Колоды выбранные из Избранных колод ChosenDecks
        /// </summary>
        public SelectedAbstractDecksToLearn SelectedChosenDecks { get; private set; }

        /// <summary>
        /// Изучать односторонние карточки(карточки информации)
        /// </summary>
        public bool LearnInformationCards { get; set; }

        /// <summary>
        /// Изучать Карточки Вопрос - Ответ
        /// </summary>
        public bool LearnQACards { get; set; }

        /// <summary>
        /// Изучать карточки отмеченные для изучения двух сторон
        /// </summary>
        public bool LearnBothSidesCards { get; set; }
        
        /// <summary>
        /// Печатать текст, если в ответе карточки есть текст и указано, что его необходимо печатать
        /// </summary>
        public bool TypeAnswers { get; set; }

        /// <summary>
        /// Изучать только одну сторону, не зависимо от того, что указано изучать обе стороны
        /// </summary>
        public bool LearnOnlyOneSide
        {
            get { return learnOnlyOneSide; }
            set
            {
                if (value && StartingSide == BeginLearnWith.MixSides)
                    StartingSide = BeginLearnWith.LeftSide;

                learnOnlyOneSide = value;
            }
        }

        public BeginLearnWith StartingSide
        {
            set
            {
                if (value == BeginLearnWith.MixSides && learnOnlyOneSide)
                    throw new ArgumentException("value не может быть == BeginLearnWith.MixSides пока learnOnlyOneSide == true");

                startSide = value;
            }

            get { return startSide; }
        }

        /// <summary>
        /// Процент карточек для изучения с левой стороны, если в настройках карточек указано изучение с двух сторон
        /// </summary>
        public int Percent_LeftSide
        {
            get
            {
                return percent_LeftSide;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new Exception("Значение вышло из дапазона от 0 до 100");
                else
                {
                    percent_LeftSide = value;
                    percent_RightSide = 100 - value;
                }
            }
        }

        /// <summary>
        /// Процент карточек для изучения с правой стороны, если в настройках карточек указано изучение с двух сторон
        /// </summary>
        public int Percent_RightSide
        {
            get
            {
                return percent_RightSide;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new Exception("Значение вышло из дапазона от 0 до 100");
                else
                {
                    percent_RightSide = value;
                    percent_LeftSide = 100 - value;
                }
            }
        }

        public LearningSettings()
        {
            SelectedDecks = new SelectedAbstractDecksToLearn(Database.DeckSet);
            SelectedChosenDecks = new SelectedAbstractDecksToLearn(Database.ChosenDeckSet);

            LearnInformationCards =
                LearnQACards =
                LearnBothSidesCards =
                TypeAnswers = true;

            learnOnlyOneSide = false;
            StartingSide = BeginLearnWith.LeftSide;
            Percent_LeftSide = 50;
        }

        /// <summary>
        /// Получение всех колод выбранных для изучения
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AbstractDeck> GetAllDecks()
        {
            foreach (var deck in SelectedDecks)
            {
                yield return deck;
            }
            foreach (var chosenDeck in SelectedChosenDecks)
            {
                yield return chosenDeck;
            }

        }

        /// <summary>
        /// Добавление в список Колод, которые необходимо повторять по графику автоматически
        /// </summary>
        /// <param name="startPoint">точка отсчета графика</param>
        public void AddToDeckListAuto(DateTime startPoint)
        {
            AddToAbstractDeckListAuto(SelectedDecks, startPoint);
        }

        /// <summary>
        /// Добавление в список Избранных Колод, которые необходимо повторять по графику автоматически
        /// </summary>
        /// <param name="startPoint">точка отсчета графика</param>
        public void AddToChosenDeckListAuto(DateTime startPoint)
        {
            AddToAbstractDeckListAuto(SelectedChosenDecks, startPoint);
        }

        /// <summary>
        /// Добавление колод, которые необходимо повторять по графику автоматически
        /// </summary>
        /// <param name="selectedAbstractDecks">список колод для добавления</param>
        /// <param name="startPoint">точка отсчета графика</param>
        private void AddToAbstractDeckListAuto(SelectedAbstractDecksToLearn selectedAbstractDecks, DateTime startPoint)
        {
            foreach (var deck in selectedAbstractDecks.AbstractDeckSet)
            {
                foreach (var date in GenerateDates(startPoint))
                {
                    if ((deck.StartPoint.ToShortDateString() == date.ToShortDateString()))
                        selectedAbstractDecks.Add(deck);
                }
            }
        }

        /// <summary>
        /// Удаление колоды из списков выбранных колод
        /// </summary>
        /// <param name="deck"></param>
        public void RemoveDeck(AbstractDeck deck)
        {
            if (deck is Deck)
                SelectedDecks.Remove(deck);
            else
                SelectedChosenDecks.Remove(deck);
        }

        /// <summary>
        /// Удаление всех колод из списков выбранных колод
        /// </summary>
        public void RemoveAllDecks()
        {
            SelectedDecks.RemoveAllDecks();
            SelectedChosenDecks.RemoveAllDecks();
        }

        /// <summary>
        /// Создает список дат начиная в обратном порядке с startDate по принципу изучения по графику через 0 дней - 1 - 3 - 7 - 14 - 28 - 28 и т.д. 
        /// </summary>
        /// <param name="startDate"></param>
        /// <returns></returns>
        private List<DateTime> GenerateDates(DateTime startDate)
        {
            var dates = new List<DateTime>();

            int daysAgo = 0;

            do
            {
                dates.Add(startDate - TimeSpan.FromDays(daysAgo));

                switch (daysAgo)
                {
                    case 0: daysAgo += 1; break;
                    case 1: daysAgo += 2; break;
                    case 3: daysAgo += 4; break;
                    case 7: daysAgo += 7; break;
                    case 14: daysAgo += 14; break;
                    default: daysAgo += 28; break;
                }
            } while (daysAgo < 1000);

            return dates;
        }
    }
}
