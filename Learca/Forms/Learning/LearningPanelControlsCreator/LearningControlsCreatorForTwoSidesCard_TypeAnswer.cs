using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Класс Создателя Кнопок и Панелей с изображением сторон карточек на LearningPanel 
    /// для Карточки с двумя заполненными сторонами.
    /// Этап вопроса требующего печатный ответ.
    /// </summary>
    class LearningControlsCreatorForTwoSidesCard_TypeAnswer : LearningControlsCreatorForTwoSidesCard
    {
        private readonly int btnAnswer_LocationX;

        /// <summary>
        /// Количество попыток пользователя ответить
        /// </summary>
        private int userAttemptCount;

        public LearningControlsCreatorForTwoSidesCard_TypeAnswer(MainForm mainForm, LearningPanel panel, LearningTwoSidesCard learningCard) : base(mainForm, panel, learningCard)
        {
            userAttemptCount = 0;
            btnAnswer_LocationX = mainForm.ConvertWidth(1160);
        }

        /// <summary>
        /// Создание кнопки показывающей ответ пользователю.
        /// </summary>
        /// <returns></returns>
        private Button CreateButton_Answer()
        {
            var btn = CreateButton("A", new Point(btnAnswer_LocationX, btnLocationY), 4);

            btn.Click += Button_Answer_Click;

            return btn;
        }

        private void Button_Answer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rightSide.ValueCount; i++)
            {
                rightCardPanel.TextBoxes[i].Text = rightSide.GetValues()[i];
            }
        }

        /// <summary>
        /// Создание кнопки проверки ответа пользователя
        /// </summary>
        /// <returns></returns>
        protected override Button CreateMiddleButton()
        {
            var btn = CreateMiddleButton("EXAM", 1);
            btn.Enabled = false;

            btn.Click += MiddleButton_Click;
            btn.Click += parentPanel.RefreshStatistic_Click;

            return btn;
        }

        /// <summary>
        /// Создание кнопки пропуска карточки
        /// </summary>
        /// <returns></returns>
        protected override Button CreateRightButton()
        {
            if (learningCard_TwoSidesCard.IsLastCard)
                return null;

            var btn = CreateRightButton("SKIP CARD", 2);
            btn.Click += RightButton_Click;

            return btn;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            learningCard_TwoSidesCard.Skip();
            parentPanel.FillPanelAsLearningCard();
        }

        private void MiddleButton_Click(object sender, EventArgs e)
        {
            if (learningCard_TwoSidesCard.ExamineUser(rightCardPanel.GetTextBoxValues()))
            {
                rightCardPanel.BackColor = Color.LightGreen;
                parentPanel.Refresh();
                Thread.Sleep(50);

                parentPanel.FillPanelAsLearningCard();
            }
            else
            {
                rightCardPanel.BackColor = Color.LightPink;

                if (++userAttemptCount == 3)
                    parentPanel.Controls.Add(CreateButton_Answer());
            }
        }

        /// <summary>
        /// Создание Панели для ответа пользователя
        /// </summary>
        /// <returns></returns>
        protected override LearningCardSidePanel CreateRightCardSidePanel()
        {
            var panel = new LearningCardSidePanel_TypeAnswer(mainForm, rightSide)
            {
                Location = new Point(rightPanel_LocationX, panel_LocationY)
            };

            return panel;
        }

        protected override void FillCardSidePanels()
        {
            rightCardPanel.Fill(false);
            leftCardPanel.Fill(true);

            SetTextBoxHandlers();
        }

        /// <summary>
        /// Установка обработчиков для TextBox'ов на панели с ответом пользователя
        /// </summary>
        private void SetTextBoxHandlers()
        {
            foreach (var tb in rightCardPanel.TextBoxes)
            {
                tb.TextChanged += TextBox_TextChanged;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            rightCardPanel.BackColor = Color.Transparent;

            bool enableMiddleButton = true;

            foreach (var tb in rightCardPanel.TextBoxes)
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    enableMiddleButton = false;
                    break;
                }
            }

            buttons.Where(btn => btn.Text == "EXAM").First().Enabled = enableMiddleButton;
        }
    }
}
