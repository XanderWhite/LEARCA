using System;

namespace Learca
{
    /// <summary>
    /// Абстрактная карточка в процессе изучения
    /// </summary>
    public abstract class AbstractLearningCard
    {
        protected readonly Teacher teacher;

        /// <summary>
        /// Изучаемая карточка
        /// </summary>
        public Card Card { get; private set; }

        /// <summary>
        /// Является ли карточка последней
        /// </summary>
        public bool IsLastCard => teacher.CurrentCardIsLastCard;
        public bool IsInCardsForChosenDeck => teacher.CardsForChosenDeckContains(this);

        /// <summary>
        /// Находится ли карта в списках для изучения
        /// </summary>
        public bool IsExists => teacher.IsExists(this);

        /// <summary>
        /// Находится ли карта в списке repeatNextPassCards
        /// </summary>
        public bool IsInRepeatNextPassCards => teacher.GetCardFromRepeatNextPassCards(this) != null;

        public AbstractLearningCard(Card card, Teacher teacher)
        {
            Card = card ?? throw new ArgumentNullException("Card card не может быть null");
            this.teacher = teacher ?? throw new ArgumentNullException("Teacher teacher не может быть null");
        }

        /// <summary>
        /// Команда на удаление карточки
        /// </summary>
        public abstract void Remove();

        /// <summary>
        /// Команда пропустить карточку
        /// </summary>
        public abstract void Skip();

        /// <summary>
        /// Команда на повторение карточки
        /// </summary>
        public abstract void Repeat();

        /// <summary>
        /// Создание копии карточки
        /// </summary>
        /// <returns></returns>
        public abstract AbstractLearningCard Clone();

        /// <summary>
        ///  Получить Создателя Кнопок и Панелей с изображением сторон карточек для LearningPanel   
        /// </summary>
        /// <param name="panel"></param>
        /// <returns></returns>
        public abstract LearningPanelControlsCreator CreateControlsCreatorFor(MainForm mainForm, LearningPanel panel);

        /// <summary>
        /// Получение последней карточки добавленной в историю
        /// </summary>
        /// <returns></returns>
        public HistoryCard GetLastHistoryCard()
        {
            return teacher.GetLastHistoryCard();
        }

        /// <summary>
        /// Повторение карточки еще раз после того ка она была удалена из learningCards
        /// </summary>
        public virtual void RepeatRemovedCard()
        {
            teacher.Repeat(Clone());
        }

        /// <summary>
        /// Проверка на совпадение Изучаемой карточки
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is AbstractLearningCard learningCard))
                return false;

            return ReferenceEquals(learningCard.Card, Card);
        }
        public override int GetHashCode()
        {
            return Card.GetHashCode();
        }
    }
}