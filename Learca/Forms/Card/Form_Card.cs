using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Learca.Properties;

namespace Learca
{
    /// <summary>
    /// Форма для Редактирования Карточки
    /// </summary>
    internal partial class Form_Card : Form
    {
        protected readonly MainForm mainForm;
        protected readonly Card card;

        /// <summary>
        /// Вносились ли изменения в Карту
        /// </summary>
        private bool changed = false;

        public Form_Card(MainForm mainForm, Card card)
        {
            InitializeComponent();

            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");
            this.card = card ?? throw new ArgumentNullException("AbstractDeck deck не может быть null");

            MdiParent = mainForm;
            Load += Form_Card_Load;
        }

        private void Form_Card_Load(object sender, EventArgs e)
        {
            VisibleChanged += Form_Card_VisibleChanged;
            panel_LeftSide.DoubleClick += Panel_LeftSide_DoubleClick;
            panel_RightSide.DoubleClick += Panel_RightSide_DoubleClick;
            btnLookAtDeck.Click += BtnLookAtDeck_Click;
            btnDeleteCard.Click += BtnDeleteCard_Click;
            btnClearLeft.Click += BtnClearLeft_Click;
            btnClearRight.Click += BtnClearRight_Click;
            btnEditLeft.Click += Panel_LeftSide_DoubleClick;
            btnEditRight.Click += Panel_RightSide_DoubleClick;
            checkBox_TypeAnswer.CheckedChanged += CheckBox_TypeAnswer_CheckedChanged;
            checkBox_AskBoth.CheckedChanged += CheckBox_AskBoth_CheckedChanged;
            tBHint.TextChanged += TBHint_TextChanged;
            tBHint.Enter += TBHint_Enter;
            tBHint.Leave += TBHint_Leave;
            Text = "LEARCA. Card";

            DoubleBuffered = true;
            Dock = DockStyle.Fill;
        }

        private void Form_Card_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                mainForm.Text = Text;

                RefreshCardSidePanel(card.LeftSide, ref panel_LeftSide, Panel_LeftSide_DoubleClick);
                RefreshCardSidePanel(card.RightSide, ref panel_RightSide, Panel_RightSide_DoubleClick);
                RefreshForm();
            }

            else
            {
                if (changed && card.IsSaved)
                {
                    Database.WriteXml();
                    changed = false;
                }

                ((MiniPanel_CardSide)panel_LeftSide).DisposePictureBoxImage();
                ((MiniPanel_CardSide)panel_RightSide).DisposePictureBoxImage();
            }
        }

        /// <summary>
        /// Обновление формы: Обновление TBHint, Обновление кнопок, обновление панели настроек карты(SideSettingsPanel)
        /// </summary>
        private void RefreshForm()
        {
            RefreshTBHint();
            RefreshButtons();

            RefreshPanel_CardSettings();
        }

        /// <summary>
        /// Обновление кнопок на форме
        /// </summary>
        private void RefreshButtons()
        {
            btnClearLeft.Enabled = !card.LeftSide.IsEmpty;
            btnClearRight.Enabled = !card.RightSide.IsEmpty;
            btnDeleteCard.Enabled = card.IsSaved;
        }

        /// <summary>
        /// Сфокусироваться на btnLookAtDeck после загрузки формы
        /// </summary>
        /// <param name="e"></param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ActiveControl = btnLookAtDeck;
        }

        #region Textbox_Hint

        /// <summary>
        /// Обновление TBHint
        /// </summary>
        private void RefreshTBHint()
        {
            if (card.LeftSide.IsEmpty || card.RightSide.IsEmpty)
            {
                tBHint.Enabled = false;
                tBHint.ForeColor = Color.Gray;

                if (card.LeftSide.IsEmpty && card.RightSide.IsEmpty)
                    tBHint.Text = "EMPTY CARD";
                else
                    tBHint.Text = "INFORMATION CARD";
            }

            else
            {
                tBHint.Enabled = true;

                if (card.Hint == string.Empty)
                {
                    tBHint.ForeColor = Color.Gray;
                    tBHint.Text = "...HINT...";
                }
                else
                {
                    tBHint.ForeColor = Color.Black;
                    tBHint.Text = card.Hint;
                }
            }
        }

        private void TBHint_Enter(object sender, EventArgs e)
        {
            if (tBHint.ForeColor == Color.Gray)
                tBHint.Text = string.Empty;

            tBHint.ForeColor = Color.Black;
        }
        private void TBHint_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBHint.Text))
            {
                tBHint.Text = "...HINT...";
                tBHint.ForeColor = Color.Gray;
            }
        }
        private void TBHint_TextChanged(object sender, EventArgs e)
        {
            string tempHint = string.Empty;

            if (tBHint.ForeColor == Color.Black)
                tempHint = tBHint.Text;

            if (tempHint != card.Hint)
            {
                card.Hint = tempHint;
                changed = true;
            }

            btnLookAtDeck.Focus();
        }

        #endregion

        #region CardSidePanels

        private void Panel_LeftSide_DoubleClick(object sender, EventArgs e)
        {
            EditCardSide(card.LeftSide);
        }
        private void Panel_RightSide_DoubleClick(object sender, EventArgs e)
        {
            EditCardSide(card.RightSide);
        }

        /// <summary>
        /// Переход в форму для редактирования Стороны карты
        /// </summary>
        /// <param name="side"></param>
        private void EditCardSide(CardSide side)
        {
            if (side == null)
                throw new ArgumentNullException("CardSide side не может быть null");

            mainForm.OpenNextForm(new Form_CardSide(mainForm, side));
            mainForm.AddToLastForms(this);
        }

        /// <summary>
        /// Обновление CardSidePanel 
        /// </summary>
        /// <param name="side">Сторона для привязки к панели</param>
        /// <param name="panel"></param>
        /// <param name="doubleClickEvent">Событие на двойной щелчек по элементам панели</param>
        private void RefreshCardSidePanel(CardSide side, ref Panel panel, EventHandler doubleClickEvent)
        {
            Controls.Remove(panel);

            panel = new MiniPanel_CardSide(side, panel.Location, doubleClickEvent);

            Controls.Add(panel);
        }

        /// <summary>
        /// Очистка Стороны карты
        /// </summary>
        /// <param name="panel"></param>
        private void ClearSidePanel(MiniPanel_CardSide panel)
        {
            if (panel == null)
                throw new ArgumentNullException("MiniCardSidePanel panel не может быть null");

            panel.ClearSide();

            Database.WriteXml();
            changed = false;

            RefreshForm();
        }

        #endregion

        private void BtnClearLeft_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear left side?", "Clearing", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ClearSidePanel(panel_LeftSide as MiniPanel_CardSide);
        }

        private void BtnClearRight_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear right side?", "Clearing", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ClearSidePanel(panel_RightSide as MiniPanel_CardSide);
        }

        private void BtnDeleteCard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete card?", "Deleting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ((MiniPanel_CardSide)panel_LeftSide).DisposePictureBoxImage();
                ((MiniPanel_CardSide)panel_RightSide).DisposePictureBoxImage();

                card.RemoveCard();

                Database.WriteXml();

                changed = false;

                mainForm.OpenLastForm();
            }
        }

        private void BtnLookAtDeck_Click(object sender, EventArgs e)
        {
            var form = new Form_LookAtDeck(card.ParentDeck);

            form.ShowDialog();
        }

        #region Panel_CardSettings

        /// <summary>
        /// Обновление панели с настройками для изучения карточки
        /// </summary>
        private void RefreshPanel_CardSettings()
        {
            panel_CardSettings.Visible = !(card.LeftSide.IsEmpty || card.RightSide.IsEmpty);

            checkBox_AskBoth.Checked = card.AskBoth;
            checkBox_TypeAnswer.Checked = card.IsTyping;
        }

        private void CheckBox_TypeAnswer_CheckedChanged(object sender, EventArgs e)
        {
            if (card.IsTyping != checkBox_TypeAnswer.Checked)
            {
                card.IsTyping = checkBox_TypeAnswer.Checked;
                changed = true;
            }
        }

        private void CheckBox_AskBoth_CheckedChanged(object sender, EventArgs e)
        {
            if (card.AskBoth != checkBox_AskBoth.Checked)
            {
                card.AskBoth = checkBox_AskBoth.Checked;
                changed = true;
            }
        }

        #endregion
    }
}
