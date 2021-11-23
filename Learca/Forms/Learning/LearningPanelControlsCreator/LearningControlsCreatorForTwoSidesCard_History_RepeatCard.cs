namespace Learca
{
    /// <summary>
    /// Класс Создателя Кнопок и Панелей с изображением сторон карточек на LearningPanel 
    /// для Карточки с двумя заполненными сторонами.
    /// Этап просмотра истории. Карточка с не правильным ответом, которая будет повторена
    /// </summary>
    class LearningControlsCreatorForTwoSidesCard_History_RepeatCard : LearningControlsCreatorForTwoSidesCard_History_CardIsLearned
    {
        public LearningControlsCreatorForTwoSidesCard_History_RepeatCard(MainForm mainForm, LearningPanel panel, HistoryTwoSidesCard historyCard)
            : base( mainForm, panel, historyCard)
        {

        }

        /// <summary>
        /// Заполнение панелей данными из карточки
        /// </summary>
        protected override void FillCardSidePanels()
        {
            leftCardPanel.Fill(true);
        }

        /// <summary>
        /// Создание кнопки возврата к изучению карточе с последующим добавлением ее в buttons
        /// </summary>
        protected override void CreateButtons()
        {
            var btn = CreateRightButton("FORWARD", 0);

            btn.Click += RightButton_Click;

            buttons.Add(btn);
        }
    }
}
