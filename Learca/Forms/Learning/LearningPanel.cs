using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Панель отображающая стороны карточки и кнопки взаимодействия с ней
    /// </summary>
    public class LearningPanel : Panel
    {
        private const int LOCATION_X = 12;
        private const int LOCATION_Y = 43;
        private const int PANEL_HEIGHT = 648;
        private const int PANEL_WIDTH = 1323;

        private readonly MainForm mainForm;
        private readonly Form_Learning parentForm;
        private Teacher teacher;
       
        public LearningPanel(MainForm mainForm, Form_Learning parentForm, Teacher teacher)
        {
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");
            this.parentForm = parentForm ?? throw new ArgumentNullException("Form_Learning parentForm не может быть null");
            this.teacher = teacher ?? throw new ArgumentNullException("Teacher teacher не может быть null");

            TabIndex = 0;
            BackColor = Color.Transparent;
            Size = new Size(mainForm.ConvertWidth(PANEL_WIDTH), mainForm.ConvertHeight( PANEL_HEIGHT));
            Location =new Point(mainForm.ConvertWidth(LOCATION_X), mainForm.ConvertHeight(LOCATION_Y));
            DoubleBuffered = true;
            Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            FillPanelAsLearningCard();
        }

        public void RefreshStatistic_Click(object sender, EventArgs e)
        {
            parentForm.RefreshStatistic();
        }

        /// <summary>
        /// Заполнить панель данными из текущей карточки для изучения
        /// </summary>
        public void FillPanelAsLearningCard()
        {
            if (teacher.CurrentCard == null)
            {
                parentForm.RefreshStatistic(); //TODO:

                MessageBox.Show("You've done!", "Congratulations!", MessageBoxButtons.OK);
                parentForm.EndSession();
            }
            else
            { 
               AddControls(teacher.CurrentCard.CreateControlsCreatorFor(mainForm, this));
            }
        }

        /// <summary>
        /// Заполнить панель данными из пройденной пользователем карточки для изучения
        /// </summary>
        public void FillPanelAsLastHistoryCard()
        {
            var lastHistoryCard = teacher.GetLastHistoryCard();

            AddControls(lastHistoryCard.GetControlsCreatorFor( mainForm, this));
        }

        /// <summary>
        /// Добавление элементов управления на панель
        /// </summary>
        /// <param name="learningControlsCreator"></param>
        private void AddControls(LearningPanelControlsCreator learningControlsCreator)
        {
            learningControlsCreator.CreateControls();

            foreach (Control control in Controls)
            {
                control.Dispose();
            }

            Controls.Clear();

            Controls.AddRange(learningControlsCreator.CardPanels);
            Controls.AddRange(learningControlsCreator.Buttons);

            SelectNextControl(this, true, true, true, true);
        }

        protected override void Dispose(bool disposing)
        {
            foreach (Control control in Controls)
            {
                control.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
