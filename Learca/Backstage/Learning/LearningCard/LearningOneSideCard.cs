namespace Learca
{
    /// <summary>
    /// Карточка в процессе изучения заполненная только с одной стороны(информационная карточка)
    /// </summary>
    class LearningOneSideCard : AbstractLearningCard
    {
        public CardSide CardSide { get; private set; }

        public LearningOneSideCard(Card card, Teacher teacher) : base(card, teacher)
        {
            CardSide = card.GetOneFilledSide();
        }

        /// <summary>
        /// Команда на повторение карточки
        /// </summary>
        public override void Repeat()
        {
            if (IsLastCard)
            {
                teacher.AddToCardsForChosenDeck(this);
            }
            else
            {
                teacher.Repeat(Clone());
                teacher.RemoveCurrentCard();
                teacher.AddToHistory(new HistoryOneSideCard(this, ViewResult.Repeat));
            }
        }

        /// <summary>
        /// Команда на удаление карточки
        /// </summary>
        public override void Remove()
        {
            teacher.RemoveCurrentCard();
            teacher.AddToHistory(new HistoryOneSideCard(this, ViewResult.Learned));
        }

        /// <summary>
        /// Команда пропустить карточку
        /// </summary>
        public override void Skip()
        {
            teacher.AddToHistory(new HistoryOneSideCard(this, ViewResult.Skipped));
            teacher.SkipCurrentCard();
        }

        /// <summary>
        /// Создание копии карточки
        /// </summary>
        /// <returns></returns>
        public override AbstractLearningCard Clone()
        {
            return new LearningOneSideCard(Card, teacher);
        }

        /// <summary>
        ///  Получить Создателя Кнопок и Панелей с изображением сторон карточек для LearningPanel   
        /// </summary>
        /// <param name="panel"></param>
        /// <returns></returns>
        public override LearningPanelControlsCreator CreateControlsCreatorFor(MainForm mainForm, LearningPanel panel)
        {
            return new LearningControlsCreatorForOneSideCard_Learning(mainForm, panel, this);
        }
    }
}