namespace Learca
{
    /// <summary>
    /// Абстрактный класс Создателя Кнопок и Панелей с изображением сторон карточек на LearningPanel для Карточки с двумя заполненными сторонами.
    /// Этап устного ответа.
    /// </summary>
    abstract class LearningControlsCreatorForTwoSidesCard_OralAnswer : LearningControlsCreatorForTwoSidesCard
    {
        public LearningControlsCreatorForTwoSidesCard_OralAnswer(MainForm mainForm, LearningPanel panel, LearningTwoSidesCard learningCard)
            : base(mainForm, panel, learningCard)
        {

        }

        /// <summary>
        /// Заполнение панелей данными из карточки
        /// </summary>
        protected override void FillCardSidePanels()
        {
            leftCardPanel.Fill(true);
            rightCardPanel.Fill(true);
        }
    }
}
