using System;
using System.Drawing;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Класс Создателя Кнопок и Панелей с изображением сторон карточек на LearningPanel 
    /// для Карточки с двумя заполненными сторонами.
    /// Этап просмотра истории. Карточка с правильным ответом.
    /// </summary>
    class LearningControlsCreatorForTwoSidesCard_History_CardIsLearned : LearningControlsCreatorForTwoSidesCard
    {
        HistoryTwoSidesCard historyCard;

        public LearningControlsCreatorForTwoSidesCard_History_CardIsLearned(MainForm mainForm, LearningPanel panel, HistoryTwoSidesCard historyCard)
             : base(mainForm, panel, historyCard.LearningCard as LearningTwoSidesCard)
        {
            this.historyCard = historyCard ?? throw new ArgumentNullException("HistoryCard_TwoSides historyCard не может быть null");
        }

        protected override void CreateCardSidePanels()
        {
            base.CreateCardSidePanels();

            cardPanels[0].BackColor = cardPanels[1].BackColor = historyCard.Color;
        }

        /// <summary>
        /// Создание кнопок для панели с последующим добавлением их в buttons
        /// </summary>
        protected override void CreateButtons()
        {
            if (!historyCard.LearningCard.IsExists)
                buttons.Add(CreateMiddleButton());

            buttons.Add(CreateRightButton());
        }

        /// <summary>
        /// Создание кнопки возврата карточки в колоду для изучения
        /// </summary>
        /// <returns></returns>
        protected override Button CreateMiddleButton()
        {
            var btn = CreateMiddleButton("REPEAT", 1);

            btn.Click += MiddleButton_Click;
            btn.Click += parentPanel.RefreshStatistic_Click;

            return btn;
        }

        /// <summary>
        /// Создание кнопки перехода к изучению карточек
        /// </summary>
        /// <returns></returns>
        protected override Button CreateRightButton()
        {
            var btn = CreateRightButton("FORWARD", 0);
            btn.Click += RightButton_Click;

            return btn;
        }

        protected void RightButton_Click(object sender, EventArgs e)
        {
            parentPanel.FillPanelAsLearningCard();
        }

        private void MiddleButton_Click(object sender, EventArgs e)
        {
            historyCard.ViewResult = ViewResult.Repeat;

            historyCard.RepeatCurrentCard();

            parentPanel.FillPanelAsLastHistoryCard();
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
