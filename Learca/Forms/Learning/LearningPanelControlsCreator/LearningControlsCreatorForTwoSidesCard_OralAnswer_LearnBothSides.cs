using System;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Класс Создателя Кнопок и Панелей с изображением сторон карточек на LearningPanel для Карточки с двумя заполненными сторонами.
    /// Этап устного ответа для карточки в которой изучаются обе стороны
    /// </summary>
    class LearningControlsCreatorForTwoSidesCard_OralAnswer_LearnBothSides : LearningControlsCreatorForTwoSidesCard_OralAnswer
    {
        public LearningControlsCreatorForTwoSidesCard_OralAnswer_LearnBothSides(MainForm mainForm, LearningPanel panel, LearningTwoSidesCard_LearnBothSides learningCard)
             : base(mainForm, panel, learningCard)
        {

        }

        /// <summary>
        /// Создание кнопки для повторения карточки еще раз
        /// </summary>
        /// <returns></returns>
        protected override Button CreateMiddleButton()
        {
            if (learningCard_TwoSidesCard.IsInRepeatNextPassCards)
                return null;

            if (learningCard_TwoSidesCard.IsLastCard && !learningCard_TwoSidesCard.IsFirstPass
                && learningCard_TwoSidesCard.IsInCardsForChosenDeck)
                return null;

            var btn = CreateMiddleButton("REPEAT", 1);

            btn.Click += MiddleButton_Click;
            btn.Click += parentPanel.RefreshStatistic_Click;

            return btn;
        }

        /// <summary>
        /// Создание кнопки перехода к следующей стороне если изучена только одна сторона, 
        /// или карточке, если изучены обе стороны, или завершения изучения, если карт больше нет
        /// </summary>
        /// <returns></returns>
        protected override Button CreateRightButton()
        {
            string text;
            if (!learningCard_TwoSidesCard.IsLastCard)
                text = "NEXT CARD";
            else if (learningCard_TwoSidesCard.IsFirstPass || learningCard_TwoSidesCard.IsInRepeatNextPassCards)
                text = "NEXT SIDE";
            else
                text = "FINISH";

            var btn = CreateRightButton(text, 0);

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

            if (!learningCard_TwoSidesCard.IsLastCard || (!learningCard_TwoSidesCard.IsFirstPass && learningCard_TwoSidesCard.IsInRepeatNextPassCards))
                parentPanel.FillPanelAsLearningCard();
            else
                (sender as Button).Visible = false;
        }
    }
}
