using System;
using System.Drawing;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Абстрактный класс Создателя Кнопок и Панелей с изображением сторон карточек на LearningPanel 
    /// для Карточки с двумя заполненными сторонами
    /// </summary>
    abstract class LearningControlsCreatorForTwoSidesCard : LearningPanelControlsCreator
    {
        private const int BTN_HINT_LOCATION_X = 3;
        private const int LEFT_PANEL_LOCATION_X = 3;
        protected const int RIGTH_PANEL_LOCATION_X = 665;
        protected const int PANEL_LOCATION_Y = 3;
        protected LearningTwoSidesCard learningCard_TwoSidesCard;
        protected CardSide leftSide;
        protected CardSide rightSide;
        protected LearningCardSidePanel leftCardPanel;
        protected LearningCardSidePanel rightCardPanel;

        public LearningControlsCreatorForTwoSidesCard(LearningPanel panel, LearningTwoSidesCard learningCard)
            : base(panel)
        {
            this.learningCard_TwoSidesCard = learningCard ?? throw new ArgumentNullException("LearningCard_TwoSides learningCard не может быть null");
            leftSide = learningCard.QuestionSide;
            rightSide = learningCard.AnswerSide;
        }

        /// <summary>
        /// Создание кнопок для панели с последующим добавлением их в buttons
        /// </summary>
        protected override void CreateButtons()
        {
            if (learningCard_TwoSidesCard.GetLastHistoryCard() != null)
                buttons.Add(CreateLeftButton());

            var middleButton = CreateMiddleButton();

            if (middleButton != null)
                buttons.Add(middleButton);

            var rightButton = CreateRightButton();

            if (rightButton != null)
                buttons.Add(rightButton);

            if (!string.IsNullOrWhiteSpace(learningCard_TwoSidesCard.Card.Hint))
                buttons.Add(CreateButtonHint());
        }

        /// <summary>
        /// Создание кнопки для вывода подсказки
        /// </summary>
        /// <returns></returns>
        private Button CreateButtonHint()
        {
            var btn = CreateButton("HINT", new Point(BTN_HINT_LOCATION_X, BTN_LOCATION_Y), 5);

            btn.Click += BtnHint_Click;

            return btn;
        }

        private void BtnHint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(learningCard_TwoSidesCard.Card.Hint, "Hint", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Создание кнопки для возврата к пройденной карточке в истории
        /// </summary>
        /// <returns></returns>
        protected virtual Button CreateLeftButton()
        {
            var btn = CreateLeftButton("BACK", 3);
            btn.Click += LeftButton_Click;

            return btn;
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            parentPanel.FillPanelAsLastHistoryCard();
        }

        protected abstract Button CreateMiddleButton();
        protected abstract Button CreateRightButton();

        /// <summary>
        /// Создание панелей отображающих стороны карточки, с последующим добавлением их в cardPanels
        /// </summary>
        protected override void CreateCardSidePanels()
        {
            leftCardPanel = CreateLeftCardSidePanel();
            rightCardPanel = CreateRightCardSidePanel();

            FillCardSidePanels();

            cardPanels.Add(leftCardPanel);
            cardPanels.Add(rightCardPanel);
        }
        
        private LearningCardSidePanel CreateLeftCardSidePanel()
        {
            var panel = new LearningCardSidePanel(leftSide);
            panel.Location = new Point(LEFT_PANEL_LOCATION_X, PANEL_LOCATION_Y);

            return panel;
        }

        protected virtual LearningCardSidePanel CreateRightCardSidePanel()
        {
            var panel = new LearningCardSidePanel(rightSide);
            panel.Location = new Point(RIGTH_PANEL_LOCATION_X, PANEL_LOCATION_Y);

            return panel;
        }

        /// <summary>
        /// Заполнение панелей данными из карточки
        /// </summary>
        protected abstract void FillCardSidePanels();
    }
}
