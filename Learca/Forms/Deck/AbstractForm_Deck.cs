using Learca.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Абстрактная форма для редактирования колоды
    /// </summary>
    internal abstract partial class AbstractForm_Deck : Form
    {
        protected readonly MainForm mainForm;
        protected readonly AbstractDeck deck;
        private CancellationTokenSource cts;

        /// <summary>
        /// Вносились ли изменения в колоду
        /// </summary>
        private bool changed = false;

        public AbstractForm_Deck(MainForm mainForm, AbstractDeck deck)
        {
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");
            this.deck = deck ?? throw new ArgumentNullException("AbstractDeck deck не может быть null");

            InitializeComponent();

            MdiParent = mainForm;

            Load += AbstractForm_Deck_Load;
        }

        protected virtual void AbstractForm_Deck_Load(object sender, EventArgs e)
        {
            VisibleChanged += Form_Deck_VisibleChanged;
            tBDeckName.Enter += TBDeckName_Enter;
            tBDeckName.Leave += TBDeckName_Leave;
            tBDeckName.TextChanged += TextBoxDeckName_TextChanged;
            tBDescription.TextChanged += TBDescription_TextChanged;
            dateTimePicker_StartPoint.ValueChanged += DateTimePicker_StartPoint_ValueChanged;
            dataGridView_Cards.DoubleClick += DataGridView_Cards_DoubleClick;
            btnCreateCard.Click += BtnCreateCard_Click;
            btnMoveInside.Click += BtnMoveInside_Click;
            btnDeleteCard.Click += BtnDeleteCard_Click;
            dataGridView_Cards.KeyDown += DataGridView_Cards_KeyDown;

            Dock = DockStyle.Fill;
            DoubleBuffered = true;

            dataGridView_Cards.Columns["Column_LeftSideImage"].DefaultCellStyle.NullValue = null;
            dataGridView_Cards.Columns["Column_RightSideImage"].DefaultCellStyle.NullValue = null;

            FillFormComponents();
        }

        private void BtnCreateCard_Click(object sender, EventArgs e)
        {
            var card = ((Deck)deck).CreateCard();

            Open(card);
        }

        protected void DataGridView_Cards_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridView_Cards.SelectedRows.Count > 0)
                HandleCardsRemoval();
            else if (e.KeyCode == Keys.Enter && dataGridView_Cards.SelectedRows.Count == 1)
                Open(dataGridView_Cards.SelectedRows[0].Tag as Card);
        }

        protected abstract void BtnMoveInside_Click(object sender, EventArgs e);

        /// <summary>
        /// Получение выделенных карточек
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        protected IEnumerable<Card> GetCardsFrom(DataGridViewSelectedRowCollection rows)
        {
            foreach (DataGridViewRow row in rows)
            {
                yield return (row.Tag as Card);
            }
        }

        private void Form_Deck_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                mainForm.Text = Text;

                cts = new CancellationTokenSource();

                FillDataGridView_Cards_Async();
                RefreshButtons();
            }
            else
            {
                if (cts != null)
                    cts.Cancel();

                if (changed && deck.IsSaved)
                {
                    Database.WriteXml();
                    changed = false;
                }

                dataGridView_Cards.Rows.Clear();
            }
        }

        /// <summary>
        /// Заполнение tBDeckName, dateTimePicker_StartPoint, tBDescription данными из deck
        /// </summary>
        private void FillFormComponents()
        {
            if (string.IsNullOrWhiteSpace(deck.Name))
            {
                tBDeckName.ForeColor = Color.Gray;
                tBDeckName.Text = "NO NAME";
            }
            else
            {
                tBDeckName.ForeColor = Color.Black;
                tBDeckName.Text = deck.Name;
            }

            try
            {
                dateTimePicker_StartPoint.Value = deck.StartPoint;
            }
            catch
            {
                deck.StartPoint = DateTime.Now;
                dateTimePicker_StartPoint.Value = deck.StartPoint;
            }

            tBDescription.Text = deck.Description;
        }

        /// <summary>
        /// Обновление кнопок на форме
        /// </summary>
        protected virtual void RefreshButtons()
        {
            btnDeleteCard.Enabled =
                   btnMoveOut.Enabled = dataGridView_Cards.SelectedRows.Count > 0;

            btnEditCard.Enabled = dataGridView_Cards.SelectedRows.Count == 1;

            btnDeleteCard.Text = (dataGridView_Cards.SelectedRows.Count > 1) ? "DELETE CARDS" : "DELETE CARD";

            btnDeleteDeck.Enabled = deck.IsSaved;
        }

        #region DataGridView_Cards

        /// <summary>
        /// Заполнение карточками dataGridView_Cards
        /// </summary>
        protected async void FillDataGridView_Cards_Async()
        {
            label_Loading.Visible = true;

            dataGridView_Cards.Rows.Clear();

            var rows = await Task.Run<DataGridViewRow[]>(() => GetRows(cts.Token));

            if (cts.IsCancellationRequested)
                return;

            dataGridView_Cards.Rows.AddRange(rows);
            dataGridView_Cards.ClearSelection();

            label_Loading.Visible = false;
        }

        /// <summary>
        /// Получить массив DataGridViewRow на основе имеющихся карт
        /// </summary>
        /// <returns></returns>
        public DataGridViewRow[] GetRows(CancellationToken token)
        {
            var rows = new DataGridViewRow[deck.CardCount];

            for (int i = 0; i < deck.CardCount; i++)
            {
                if (token.IsCancellationRequested)
                    break;

                rows[i] = CreateRow(deck[i], i + 1);
            }

            return rows;
        }

        /// <summary>
        /// Содание строки для dataGridView_Cards
        /// </summary>
        /// <param name="card"></param>
        /// <param name="number">номер карточки отображаемый в первой колонке</param>
        /// <returns></returns>
        protected virtual DataGridViewRow CreateRow(Card card, int number)
        {
            if (card == null)
                throw new ArgumentNullException("Card card не может быть null");

            var row = new DataGridViewRow();

            var cell_number = new DataGridViewTextBoxCell();
            var cell_leftSideValues = new DataGridViewTextBoxCell();
            var cell_leftSideImage = new DataGridViewImageCell();
            var cell_rightSideValues = new DataGridViewTextBoxCell();
            var cell_rightSideImage = new DataGridViewImageCell();

            cell_number.Value = number;
            cell_leftSideValues.Value = card.LeftSide.GetValuesToString();
            cell_leftSideImage.Value = GetImage(card.LeftSide.ImagePath);
            cell_rightSideValues.Value = card.RightSide.GetValuesToString();
            cell_rightSideImage.Value = GetImage(card.RightSide.ImagePath);

            row.Height = 90;
            row.Tag = card;

            row.Cells.AddRange(cell_number, cell_leftSideValues, cell_leftSideImage, cell_rightSideValues, cell_rightSideImage);

            return row;
        }

        /// <summary>
        /// Получить картинку для dataGridView_Cards
        /// </summary>
        /// <param name="imagePath"></param>
        /// <returns></returns>
        private Image GetImage(string imagePath)
        {
            var image = ImageHandler.GetImage(imagePath);

            try
            {
                return ImageHandler.ResizeImage(image, 150, 84);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Открытие выделенной карточки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void DataGridView_Cards_DoubleClick(object sender, EventArgs e)
        {
            if ((sender as DataGridView).CurrentRow == null)
                return;

            Open((sender as DataGridView).CurrentRow.Tag as Card);
        }

        private void DataGridView_Cards_SelectionChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }

        #endregion

        /// <summary>
        /// Открыть форму с карточкой
        /// </summary>
        /// <param name="card"></param>
        protected void Open(Card card)
        {
            if (card == null)
                throw new ArgumentNullException("Card card не может быть null");

            dataGridView_Cards.Rows.Clear();

            mainForm.OpenNextForm(new Form_Card(mainForm, card));
            mainForm.AddToLastForms(this);
        }

        private void BtnDeleteDeck_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Deck?", "Deleting", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deck.RemoveDeck();

                Database.WriteXml();

                changed = false;

                mainForm.OpenLastForm();
            }
        }

        private void BtnEditCard_Click(object sender, EventArgs e)
        {
            if (dataGridView_Cards.SelectedRows.Count != 1)
                throw new Exception("dataGridView_Cards.SelectedRows.Count не может быть != 1");

            Open(dataGridView_Cards.SelectedRows[0].Tag as Card);
        }

        protected virtual void BtnDeleteCard_Click(object sender, EventArgs e)
        {
            HandleCardsRemoval();
        }

        /// <summary>
        /// Обработать удаление Карточек
        /// </summary>
        private void HandleCardsRemoval()
        {
            if (dataGridView_Cards.SelectedRows.Count == 0)
                throw new Exception("dataGridView_Cards.SelectedRows.Count не может быть = 0");

            var question = (dataGridView_Cards.SelectedRows.Count == 1) ? "Delete Card?" : "Delete Cards?";

            if (MessageBox.Show(question, "Deleting", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            RemoveSelectedCards();
            RemoveSelectedRows();

            RefreshButtons();

            changed = true;
        }

        /// <summary>
        /// Удаление выделенных строк
        /// </summary>
        protected void RemoveSelectedRows()
        {
            int count = dataGridView_Cards.SelectedRows.Count;

            if (count == 0) return;

            while (count > 0)
            {
                dataGridView_Cards.Rows.RemoveAt(dataGridView_Cards.SelectedRows[0].Index);
                count--;
            }

            RefreshDataGridColumn_Number();
        }

        /// <summary>
        /// Обновление нумерации строк
        /// </summary>
        private void RefreshDataGridColumn_Number()
        {
            int n = 1;

            foreach (DataGridViewRow row in dataGridView_Cards.Rows)
            {
                row.Cells[0].Value = n++;
            }
        }

        /// <summary>
        /// Удаление выделенных Карт из колоды
        /// </summary>
        private void RemoveSelectedCards()
        {
            foreach (DataGridViewRow row in dataGridView_Cards.SelectedRows)
            {
                deck.Remove(row.Tag as Card);
            }
        }

        #region Изменения в колоде

        private void TBDeckName_Enter(object sender, EventArgs e)
        {
            if (tBDeckName.ForeColor == Color.Gray)
                tBDeckName.Text = string.Empty;

            tBDeckName.ForeColor = Color.Black;
        }
        private void TBDeckName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBDeckName.Text))
            {
                tBDeckName.ForeColor = Color.Gray;
                tBDeckName.Text = "NO NAME";
            }
        }
        private void TextBoxDeckName_TextChanged(object sender, EventArgs e)
        {
            string tempName = string.Empty;

            if (tBDeckName.ForeColor == Color.Black)
                tempName = tBDeckName.Text.Trim();

            if (tempName != deck.Name)
            {
                deck.Name = tempName;

                changed = true;
            }
        }

        private void TBDescription_TextChanged(object sender, EventArgs e)
        {
            if (deck.Description != tBDescription.Text)
            {
                deck.Description = tBDescription.Text;

                changed = true;
            }
        }

        private void DateTimePicker_StartPoint_ValueChanged(object sender, EventArgs e)
        {
            if (deck.StartPoint.Date != dateTimePicker_StartPoint.Value.Date)
            {
                deck.StartPoint = dateTimePicker_StartPoint.Value;

                changed = true;
            }
        }

        #endregion
    }
}

