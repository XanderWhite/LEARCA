using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Learca.Properties;

namespace Learca
{
    /// <summary>
    /// Форма - Домашняя страница. Форма приложения с главным меню
    /// </summary>
    public partial class Form_Home : Form
    {
        readonly MainForm mainForm;

        public Form_Home(MainForm mainForm)
        {
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");

            InitializeComponent();

            MdiParent = mainForm;

            Load += Form_Home_Load;
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            btnCards.Click += BtnCards_Click;
            btnLearn.Click += BtnLearn_Click;
            btnRepeat.Click += BtnRepeat_Click;
            btnDecks.Click += BtnDecks_Click;

            Dock = DockStyle.Fill;
            DoubleBuffered = true;
            mainForm.Text = "LEARCA";

            RefreshButtons();
        }

        private void BtnRepeat_Click(object sender, EventArgs e)
        {
            mainForm.OpenNextForm(new Form_ChosenDeckSet(mainForm));

            Close();
        }

        private void BtnLearn_Click(object sender, EventArgs e)
        {
            mainForm.OpenNextForm(new Form_SettingsToLearn(mainForm));

            Close();
        }

        private void BtnCards_Click(object sender, EventArgs e)
        {
            mainForm.OpenNextForm(new Form_Cards(mainForm));

            Close();
        }

        /// <summary>
        /// Обновление кнопок на форме
        /// </summary>
        private void RefreshButtons()
        {
            btnLearn.Enabled =
                btnCards.Enabled =
                btnRepeat.Enabled = Database.DeckSet.CardCount > 0;
        }

        private void BtnDecks_Click(object sender, EventArgs e)
        {
            mainForm.OpenNextForm(new Form_DeckSet(mainForm));

            Close();
        }
    }
}
