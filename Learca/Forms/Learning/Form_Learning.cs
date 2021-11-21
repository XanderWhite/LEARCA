using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Форма для изучения карточек
    /// </summary>
    public partial class Form_Learning : Form
    {
        private readonly MainForm mainForm;
        private readonly Teacher teacher;
        private readonly int totalCards;

        /// <summary>
        /// флаг для закрытия формы. Если false, то запрос пользователя на завершение сессии, иначе закрыть форму
        /// </summary>
        private bool close = false;

        public Form_Learning(MainForm mainForm, Teacher teacher)
        {
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");
            this.teacher = teacher ?? throw new ArgumentNullException("Teacher teacher не может быть null");

            InitializeComponent();

            totalCards = teacher.LearningCardsCount;

            MdiParent = mainForm;

            Controls.Add(new LearningPanel(this, teacher));

            Load += Form_Learning_Load;
        }

        private void Form_Learning_Load(object sender, EventArgs e)
        {
            VisibleChanged += Form_Learning_VisibleChanged;
            FormClosing += Form_Learning_FormClosing;

            toolStripStatusLabel_TotalCards.Text = "Total cards: " + totalCards;
            progressBar_Statistic.Maximum = totalCards;

            DoubleBuffered = true;
            Text = "LEARCA. Learning";

            RefreshStatistic();

            Dock = DockStyle.Fill;
        }

        private void Form_Learning_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!close)
            {
                if (MessageBox.Show("Stop Learning?", "Learning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (teacher.СardsForChosenDeckCount > 0)
                    {
                        teacher.CreateChosenDeck();
                        Database.WriteXml();
                    }
                }
                else
                    e.Cancel = true;
            }
        }

        private void Form_Learning_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                mainForm.Text = Text;

                mainForm.toolStripMenuItem_EndSession.Visible = true;
                mainForm.toolStripMenuItem_ShowStatistic.Visible = true;
                mainForm.toolStripMenuItem_EndSession.Click += ToolStripMenuItem_EndSession_Click;
                mainForm.toolStripMenuItem_ShowStatistic.Click += ToolStripMenuItem_HideStatistic_Click;
            }
            else
            {
                mainForm.toolStripMenuItem_EndSession.Visible = false;
                mainForm.toolStripMenuItem_ShowStatistic.Visible = false;
                mainForm.toolStripMenuItem_EndSession.Click -= ToolStripMenuItem_EndSession_Click;
                mainForm.toolStripMenuItem_ShowStatistic.Click -= ToolStripMenuItem_HideStatistic_Click;
            }
        }

        /// <summary>
        /// Обновление строки статистики.
        /// </summary>
        public void RefreshStatistic()
        {
            toolStripStatusLabel_СardsForChosenDeckCount.Text = "Number of Chosen Cards: " + teacher.СardsForChosenDeckCount;
            toolStripStatusLabel_RemainingCards.Text = "Remaining cards: " + teacher.LearningCardsCount;

            progressBar_Statistic.Value = totalCards - teacher.LearningCardsCount;
            toolStripStatusLabel_PassedCards.Text = "Passed cards: " + progressBar_Statistic.Value;
        }

        private void ToolStripMenuItem_HideStatistic_Click(object sender, EventArgs e)
        {
            statusStrip_Statistic.Visible = !statusStrip_Statistic.Visible;

            mainForm.toolStripMenuItem_ShowStatistic.Text = (statusStrip_Statistic.Visible) ? "HIDE STATISTIC" : "SHOW STATISTIC";
        }

        private void ToolStripMenuItem_EndSession_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Stop Learning?", "Learning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                EndSession();
        }

        /// <summary>
        /// Завершение изучения карточек
        /// </summary>
        public void EndSession()
        {
            close = true;

            if (teacher.СardsForChosenDeckCount == 0)
                mainForm.OpenLastForm();
            else
            {
                var deck = teacher.CreateChosenDeck();

                Database.WriteXml();

                mainForm.OpenNextForm(new Form_ChosenDeck(mainForm, deck));

                Close();
            }
        }
    }
}
