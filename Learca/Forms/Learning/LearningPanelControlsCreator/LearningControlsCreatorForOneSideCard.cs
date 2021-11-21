using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learca
{
    /// <summary>
    /// Абстрактный класс Создателя Кнопок и Панелей с изображением сторон карточек на LearningPanel 
    /// для Карточки с только одной заполненной стороной
    /// </summary>
    public abstract class LearningControlsCreatorForOneSideCard : LearningPanelControlsCreator
    {
        private const int PANEL_LOCATION_X = 334;
        private const int PANEL_LOCATION_Y = 3;

        protected CardSide cardSide;

        public LearningControlsCreatorForOneSideCard(LearningPanel parentPanel, CardSide cardSide) : base(parentPanel)
        {
            this.cardSide = cardSide ?? throw new ArgumentNullException(" CardSide cardSide не может быть null");
        }

        /// <summary>
        /// Создание панелей отображающих стороны карточки, с последующим добавлением их в cardPanels
        /// </summary>
        protected override void CreateCardSidePanels()
        {
            cardPanels.Add(CreateCardSidePanel());
        }

        /// <summary>
        /// Создание панели отображающей сторону карточки
        /// </summary>
        protected virtual LearningCardSidePanel CreateCardSidePanel()
        {
            var cardPanel = new LearningCardSidePanel(cardSide)
            {
                Location = new Point(PANEL_LOCATION_X, PANEL_LOCATION_Y)
            };

            cardPanel.Fill(true);

            return cardPanel;
        }
    }
}

