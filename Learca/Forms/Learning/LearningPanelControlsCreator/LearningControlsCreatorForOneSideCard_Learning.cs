using System;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Класс Создателя Кнопок и Панелей с изображением сторон карточек на LearningPanel 
    /// для Карточки с только одной заполненной стороной.
    /// Этап изучения
    /// </summary>
    class LearningControlsCreatorForOneSideCard_Learning : LearningControlsCreatorForOneSideCard
        {
            private LearningOneSideCard learningCard_OneSide;

            public LearningControlsCreatorForOneSideCard_Learning(LearningPanel panel, LearningOneSideCard learningCard)
                : base(panel, learningCard.CardSide)
            {
                this.learningCard_OneSide = learningCard ?? throw new ArgumentNullException("LearningOneSideCard learningCard_OneSide не может быть null");
            }

            /// <summary>
            /// Создание кнопок для панели с последующим добавлением их в buttons
            /// </summary>
            protected override void CreateButtons()
            {
                if (learningCard_OneSide.GetLastHistoryCard() != null)
                    buttons.Add(CreateLeftButton());

                if (!learningCard_OneSide.IsInCardsForChosenDeck)
                    buttons.Add(CreateMiddleButton());

                buttons.Add(CreateRightButton());
            }

            /// <summary>
            /// Создание кнопки для перехода к последней карточке в истории
            /// </summary>
            protected virtual Button CreateLeftButton()
            {
                var btn = CreateLeftButton("BACK", 2);
                btn.Click += LeftButton_Click;

                return btn;
            }

            /// <summary>
            /// Создание кнопки для повтора текущей карточки
            /// </summary>
            protected virtual Button CreateMiddleButton()
            {
                var btn = CreateMiddleButton("REPEAT", 1);
                btn.Click += MiddleButton_Click;
                btn.Click += parentPanel.RefreshStatistic_Click;

                return btn;
            }

            /// <summary>
            /// Создание кнопки для перехода с следующей карточке или завершения изучения, если карточек больше нет
            /// </summary>
            protected virtual Button CreateRightButton()
            {
                var btn = (!learningCard_OneSide.IsLastCard) ? CreateRightButton("NEXT CARD", 0) : CreateRightButton("FINISH", 0);

                btn.Click += RightButton_Click;
                btn.Click += parentPanel.RefreshStatistic_Click;

                return btn;
            }

            protected virtual void RightButton_Click(object sender, EventArgs e)
            {
                learningCard_OneSide.Remove();
                parentPanel.FillPanelAsLearningCard();
            }

            protected virtual void MiddleButton_Click(object sender, EventArgs e)
            {
                learningCard_OneSide.Repeat();

                if (learningCard_OneSide.IsLastCard)
                    (sender as Button).Visible = false;
                else
                    parentPanel.FillPanelAsLearningCard();
            }

            protected virtual void LeftButton_Click(object sender, EventArgs e)
            {
                parentPanel.FillPanelAsLastHistoryCard();
            }
        }
    }

