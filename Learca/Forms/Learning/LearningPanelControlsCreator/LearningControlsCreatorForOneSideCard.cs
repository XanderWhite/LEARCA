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
        private readonly int panel_LocationX = 334;
        private readonly int panel_LocationY = 3;

        protected CardSide cardSide;

        public LearningControlsCreatorForOneSideCard(MainForm mainForm, LearningPanel parentPanel, CardSide cardSide) : base(mainForm, parentPanel)
        {
            this.cardSide = cardSide ?? throw new ArgumentNullException(" CardSide cardSide не может быть null");

            panel_LocationX = mainForm.ConvertWidth(334);
            panel_LocationY = mainForm.ConvertHeight(3);
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
            var cardPanel = new LearningCardSidePanel(mainForm, cardSide)
            {
                Location = new Point(panel_LocationX, panel_LocationY)
            };

            cardPanel.Fill(true);

            return cardPanel;
        }
    }
}

