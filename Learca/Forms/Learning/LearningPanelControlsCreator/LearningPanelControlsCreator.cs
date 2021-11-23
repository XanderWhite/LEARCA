using Learca.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Создатель Кнопок и Панелей с изображением сторон карточек для LearningPanel
    /// </summary>
    public abstract class LearningPanelControlsCreator
    {
        protected readonly MainForm mainForm;

        private readonly int btnHeight;
        private readonly int btnWidth;
        protected readonly int btnLocationY;
        protected readonly int btnLeft_LocationX;
        protected readonly int btnMiddle_LocationX;
        protected readonly int btnRight_LocationX;

        protected LearningPanel parentPanel;

        /// <summary>
        /// Если у карточки заполнена только одна сторона то cardPanels.Count = 1, иначе .Count = 2
        /// </summary>
        protected readonly List<LearningCardSidePanel> cardPanels;
        public LearningCardSidePanel[] CardPanels => cardPanels.ToArray();

        /// <summary>
        /// По умолчанию имеются три основных кнопки. Левая, средняя и правая. 
        /// Остальные кнопки, например такие как Hint и Answer появляются в зависимости от типа карточки и некоторых условий
        /// </summary>
        protected readonly List<Button> buttons;
        public Button[] Buttons => buttons.ToArray();

        protected LearningPanelControlsCreator(MainForm mainForm, LearningPanel parentPanel)
        {
            this.parentPanel = parentPanel ?? throw new ArgumentNullException("LearningPanel parentPanel не может быть null");
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");

            buttons = new List<Button>();
            cardPanels = new List<LearningCardSidePanel>();

            btnHeight = mainForm.ConvertHeight(40);
            btnWidth = mainForm.ConvertWidth(160);
            btnLocationY = mainForm.ConvertHeight(599);
            btnLeft_LocationX = mainForm.ConvertWidth(414);
            btnMiddle_LocationX = mainForm.ConvertWidth(580);
            btnRight_LocationX = mainForm.ConvertWidth(746);
        }

        /// <summary>
        /// Создание элементов управления Buttons и Panels
        /// </summary>
        public void CreateControls()
        {
            CreateCardSidePanels();
            CreateButtons();
        }

        protected abstract void CreateCardSidePanels();
        protected abstract void CreateButtons();

        /// <summary>
        /// Создание кнопки 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="location"></param>
        /// <param name="tabIndex"></param>
        /// <returns></returns>
        protected Button CreateButton(string text, Point location, int tabIndex)
        {
            var btn = new Button
            {
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Size = new Size(mainForm.ConvertWidth(btnWidth), mainForm.ConvertHeight(btnHeight)),
                Text = text,
                Location = location,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                TabIndex = tabIndex
            };

            btn.Font = new Font(btn.Font, FontStyle.Bold);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Settings.Default.BackColor;

            return btn;
        }

        /// <summary>
        /// Создание левой кнопки
        /// </summary>
        /// <param name="text"></param>
        /// <param name="tabIndex"></param>
        /// <returns></returns>
        protected Button CreateLeftButton(string text, int tabIndex)
        {
            return CreateButton(text, new Point(btnLeft_LocationX, btnLocationY), tabIndex);
        }

        /// <summary>
        /// Создание средней кнопки
        /// </summary>
        /// <param name="text"></param>
        /// <param name="tabIndex"></param>
        /// <returns></returns>
        protected Button CreateMiddleButton(string text, int tabIndex)
        {
            return CreateButton(text, new Point(btnMiddle_LocationX, btnLocationY), tabIndex);
        }

        /// <summary>
        /// Создание правой кнопки
        /// </summary>
        /// <param name="text"></param>
        /// <param name="tabIndex"></param>
        /// <returns></returns>
        protected Button CreateRightButton(string text, int tabIndex)
        {
            return CreateButton(text, new Point(btnRight_LocationX, btnLocationY), tabIndex);
        }
    }
}
