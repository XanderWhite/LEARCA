namespace Learca
{
    /// <summary>
    /// Карточка находящаяся в истории.
    /// Карточка заполненная только с одной стороны, которая была просмотрена пользователем.
    /// </summary>
    class HistoryOneSideCard : HistoryCard
    {
        /// <summary>
        /// Заполненая сторона карточки
        /// </summary>
        public CardSide CardSide => (LearningCard as LearningOneSideCard).CardSide;

        public HistoryOneSideCard(LearningOneSideCard learningCard, ViewResult viewResult) : base(learningCard, viewResult)
        {

        }

        /// <summary>
        /// Получить Создателя Кнопок и Панелей с изображением сторон карточек для LearningPanel   
        /// <param name="panel"></param>
        /// <returns></returns>
        public override LearningPanelControlsCreator GetControlsCreatorFor(MainForm mainForm, LearningPanel panel)
        {
            return new LearningControlsCreatorForOneSideCard_History(mainForm, panel, this);
        }
    }
}
