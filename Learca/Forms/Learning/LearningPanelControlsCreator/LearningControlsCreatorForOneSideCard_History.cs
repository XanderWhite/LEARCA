using System;
using System.Drawing;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Класс Создателя Кнопок и Панелей с изображением сторон карточек на LearningPanel 
    /// для Карточки с только одной заполненной стороной отображаемой в процессе просмотра ее в истории
    /// </summary>
    class LearningControlsCreatorForOneSideCard_History : LearningControlsCreatorForOneSideCard
        {
            HistoryOneSideCard historyCard;

            public LearningControlsCreatorForOneSideCard_History(MainForm mainForm, LearningPanel panel, HistoryOneSideCard historyCard)
                : base(mainForm, panel, historyCard.CardSide)
            {
                this.historyCard = historyCard ?? throw new ArgumentNullException("HistoryOneSideCard historyCard не может быть null");
            }

            /// <summary>
            /// Создание панели отображающей сторону карточки
            /// </summary>
            protected override LearningCardSidePanel CreateCardSidePanel()
            {
                var panel = base.CreateCardSidePanel();

                panel.BackColor = historyCard.Color;

                return panel;
            }

            /// <summary>
            /// Создание кнопок для панели с последующим добавлением их в buttons
            /// </summary>
            protected override void CreateButtons()
            {
                if (historyCard.ViewResult == ViewResult.Learned)
                    buttons.Add(CreateMiddleButton());

                buttons.Add(CreateRightButton());
            }

            /// <summary>
            /// Создание кнопки для возврата к изучению карточек
            /// </summary>
            /// <returns></returns>
            protected virtual Button CreateRightButton()
            {
                var btn = CreateRightButton("FORWARD", 0);
                btn.Click += RightButton_Click;

                return btn;
            }

            /// <summary>
            /// Создание кнопки для повторения уже изученой карточки
            /// </summary>
            /// <returns></returns>
            protected virtual Button CreateMiddleButton()
            {
                var btn = CreateMiddleButton("REPEAT", 1);
                btn.Click += MiddleButton_Click;
                btn.Click += parentPanel.RefreshStatistic_Click;

                return btn;
            }

            private void RightButton_Click(object sender, EventArgs e)
            {
                parentPanel.FillPanelAsLearningCard();
            }

            private void MiddleButton_Click(object sender, EventArgs e)
            {
                historyCard.ViewResult = ViewResult.Repeat;
                cardPanels[0].BackColor = Color.LightPink;

                historyCard.RepeatCurrentCard();
                (sender as Button).Visible = false;
            }
        }
    }

