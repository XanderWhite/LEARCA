using System;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Класс Создателя Кнопок и Панелей с изображением сторон карточек на LearningPanel для Карточки с двумя заполненными сторонами.
    /// Этап устного ответа для карточки в которой изучается только одна сторона
    /// </summary>
    class LearningControlsCreatorForTwoSidesCard_OralAnswer_LearnOneSide : LearningControlsCreatorForTwoSidesCard_OralAnswer
    {
        public LearningControlsCreatorForTwoSidesCard_OralAnswer_LearnOneSide(MainForm mainForm, LearningPanel panel, LearningTwoSidesCard_LearnOneSide learningCard)
             : base(mainForm, panel, learningCard)
        {

        }

        /// <summary>
        /// Создание кнопки для повторения карточки еще раз
        /// </summary>
        /// <returns></returns>
        protected override Button CreateMiddleButton()
        {
            if (learningCard_TwoSidesCard.IsLastCard && learningCard_TwoSidesCard.IsInCardsForChosenDeck)
                return null;

            var btn = CreateMiddleButton("REPEAT", 1);
            btn.Click += MiddleButton_Click;
            btn.Click += parentPanel.RefreshStatistic_Click;

            return btn;
        }

        /// <summary>
        /// Создание кнопки перехода к следующей карточке или завершения изучения, если карт больше нет
        /// </summary>
        /// <returns></returns>
        protected override Button CreateRightButton()
        {
            var btn = (!learningCard_TwoSidesCard.IsLastCard) ? CreateRightButton("NEXT CARD", 0) : CreateRightButton("FINISH", 0);

            btn.Click += RightButton_Click;
            btn.Click += parentPanel.RefreshStatistic_Click;

            return btn;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            learningCard_TwoSidesCard.Remove();
            parentPanel.FillPanelAsLearningCard();
        }

        private void MiddleButton_Click(object sender, EventArgs e)
        {
            learningCard_TwoSidesCard.Repeat();

            if (learningCard_TwoSidesCard.IsLastCard)
                (sender as Button).Visible = false;
            else
                parentPanel.FillPanelAsLearningCard();
        }
    }
}
