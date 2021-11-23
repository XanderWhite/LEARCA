using System;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Класс Создателя Кнопок и Панелей с изображением сторон карточек на LearningPanel 
    /// для Карточки с двумя заполненными сторонами.
    /// Этап вопроса не требующего печатный ответ.
    /// </summary>
    class LearningControlsCreatorForTwoSidesCard_OralQuestion : LearningControlsCreatorForTwoSidesCard
    {
        public LearningControlsCreatorForTwoSidesCard_OralQuestion(MainForm mainForm, LearningPanel panel, LearningTwoSidesCard learningCard)
      : base(mainForm, panel, learningCard)
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
        /// Создать кнопку Показывающую ответ
        /// </summary>
        /// <returns></returns>
        protected override Button CreateMiddleButton()
        {
            var btn = CreateMiddleButton("SHOW ANSWER", 0);
            btn.Click += MiddleButton_ShowAnswer_Click;

            return btn;
        }

        private void MiddleButton_ShowAnswer_Click(object sender, EventArgs e)
        {
            learningCard_TwoSidesCard.ShowAnswer = true;

            parentPanel.FillPanelAsLearningCard();
        }

        /// <summary>
        /// Создание кнопки пропускающей карточку
        /// </summary>
        /// <returns></returns>
        protected override Button CreateRightButton()
        {
            if (learningCard_TwoSidesCard.IsLastCard)
                return null;

            var btn = CreateRightButton("SKIP CARD", 1);
            btn.Click += RightButton_Click;

            return btn;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            learningCard_TwoSidesCard.Skip();
            parentPanel.FillPanelAsLearningCard();
        }
    }
}
