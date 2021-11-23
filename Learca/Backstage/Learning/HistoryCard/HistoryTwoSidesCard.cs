namespace Learca
{
    /// <summary>
    /// Карточка находящаяся в истории.
    /// Карточка заполненная с двух сторон, которая была просмотрена пользователем.
    /// </summary>
    class HistoryTwoSidesCard : HistoryCard
    {
        /// <summary>
        /// Является ли левая сторона Вопросом
        /// </summary>
        private readonly bool leftSideIsQuestion;

        /// <summary>
        /// Сторона с вопросом
        /// </summary>
        public CardSide QuestionSide => leftSideIsQuestion ? LearningCard.Card.LeftSide : LearningCard.Card.RightSide;

        // <summary>
        /// Сторона с ответом
        /// </summary>
        public CardSide AnswerSide => leftSideIsQuestion ? LearningCard.Card.RightSide : LearningCard.Card.LeftSide;

        public HistoryTwoSidesCard(AbstractLearningCard learningCard, ViewResult viewResult, bool leftSideIsQuestion)
            : base(learningCard, viewResult)
        {
            this.leftSideIsQuestion = leftSideIsQuestion;
        }

        /// <summary>
        ///  Получить Создателя Кнопок и Панелей с изображением сторон карточек для LearningPanel
        /// </summary>
        /// <param name="mainLearningPanel"></param>
        /// <returns></returns>
        public override LearningPanelControlsCreator GetControlsCreatorFor(MainForm mainForm, LearningPanel mainLearningPanel)
        {
            if (ViewResult == ViewResult.Learned)
                return new LearningControlsCreatorForTwoSidesCard_History_CardIsLearned( mainForm, mainLearningPanel, this);

            return new LearningControlsCreatorForTwoSidesCard_History_RepeatCard( mainForm, mainLearningPanel, this);
        }
    }
}
