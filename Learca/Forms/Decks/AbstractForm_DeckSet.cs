using Learca.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Абстрактная форма для редактирования Набора колод
    /// </summary>
    public abstract partial class AbstractForm_DeckSet : Form
    {
        protected readonly MainForm mainForm;
        protected readonly AbstractDeckSet decks; 
        private CancellationTokenSource cts;

        public AbstractForm_DeckSet(MainForm mainForm, AbstractDeckSet deckSet)
        {
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");
            decks = deckSet ?? throw new ArgumentNullException("AbstractDeckSet deckSet не может быть null");

            InitializeComponent();

            MdiParent = mainForm;

            Load += AbstractForm_DeckSet_Load;
        }

        protected virtual void AbstractForm_DeckSet_Load(object sender, EventArgs e)
        {
            VisibleChanged += Form_AbstractDeckSet_VisibleChanged;
            btnDeleteEmptyDecks.Click += ButtonDeleteEmptyDecks_Click;
            btnDeleteDeck.Click += BtnDeleteDeck_Click;
            tBFilter.Enter += TBFilter_Enter;
            tBFilter.Leave += TBFilter_Leave;
            tBFilter.TextChanged += TBFilter_TextChanged;
            dataGridView_Decks.DoubleClick += DataGridView_Decks_DoubleClick;
            dataGridView_Decks.SelectionChanged += DataGridView_Decks_SelectionChanged;
            dataGridView_Decks.KeyDown += DataGridView_Decks_KeyDown;

            btnMoveInside.Visible = false;
            btnToCards.Visible = false;

            Dock = DockStyle.Fill;
            DoubleBuffered = true;

            tBFilter.ForeColor = Color.Gray;
            tBFilter.Text = "...SEARCH...";
        }

        /// <summary>
        /// Обновление кнопок на форме
        /// </summary>
        protected virtual void RefreshButtons()
        {
            btnDeleteEmptyDecks.Enabled = decks.EmptyDeckCount > 0;

            btnDeleteDeck.Enabled = dataGridView_Decks.SelectedRows.Count > 0;

            btnOpenDeck.Enabled = dataGridView_Decks.SelectedRows.Count == 1;
        }

        private void Form_AbstractDeckSet_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                mainForm.Text = Text;

                cts = new CancellationTokenSource();
                FillDataGridView_Decks_Async();
                RefreshButtons();
            }
            else
            {
                if (cts != null)
                    cts.Cancel();
            }
        }

        protected void ButtonDeleteEmptyDecks_Click(object sender, EventArgs e)
        {
            if (decks.EmptyDeckCount == 0)
                throw new Exception("decks.EmptyDeckCount не может быть = 0");

            var question = (decks.EmptyDeckCount == 1) ? "Delete Empty Deck?" : $"Delete {decks.EmptyDeckCount} Empty Decks?";

            if (MessageBox.Show(question, "Deleting", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            decks.RemoveEmptyDecks();

            Database.WriteXml();

            FillDataGridView_Decks_Async();
            RefreshButtons();
        }

        protected void BtnCreateDeck_Click(object sender, EventArgs e)
        {
            OpenDeck(decks.CreateDeck());
        }

        private void BtnOpenDeck_Click(object sender, EventArgs e)
        {
            OpenDeck(dataGridView_Decks.SelectedRows[0].Tag as AbstractDeck);
        }

        protected abstract void OpenDeck(AbstractDeck deck);

        #region Textbox_Filter

        private void TBFilter_Enter(object sender, EventArgs e)
        {
            if (tBFilter.ForeColor == Color.Gray)
                tBFilter.Text = string.Empty;

            tBFilter.ForeColor = Color.Black;
        }
        private void TBFilter_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBFilter.Text))
            {
                tBFilter.ForeColor = Color.Gray;
                tBFilter.Text = "...SEARCH...";
            }
        }
        private void TBFilter_TextChanged(object sender, EventArgs e)
        {
            if (tBFilter.ForeColor == Color.Black)
                FilterDataGridView(tBFilter.Text);
        }

        #endregion

        #region DataGridView_Decks

        /// <summary>
        /// Заполнение dataGridView_Decks
        /// </summary>
        protected async void FillDataGridView_Decks_Async()
        {
            label_Loading.Visible = true;

            dataGridView_Decks.Rows.Clear();

            var rows = await Task.Run<DataGridViewRow[]>(() => GetRows(cts.Token));

            if (cts.IsCancellationRequested)
                return;

            dataGridView_Decks.Rows.AddRange(rows);
            dataGridView_Decks.ClearSelection();

            if (tBFilter.ForeColor == Color.Black)
                FilterDataGridView(tBFilter.Text);

            label_Loading.Visible = false;
        }

        /// <summary>
        /// Получить массив DataGridViewRow на основе имеющихся колод
        /// </summary>
        /// <returns></returns>
        public DataGridViewRow[] GetRows(CancellationToken token)
        {
            var rows = new List<DataGridViewRow>();

            int number = 1;

            foreach(var deck in decks)
            {
                if (token.IsCancellationRequested)
                    break;

                var row = CreateRow(deck, ref number);

                if (row != null)
                    rows.Add(row);
            }

            return rows.ToArray();
        }

        /// <summary>
        /// Создание Строки для dataGridView_Decks
        /// </summary>
        /// <param name="deck"></param>
        /// <param name="number">увеличивается на единицу</param>
        /// <returns></returns>
        protected virtual DataGridViewRow CreateRow(AbstractDeck deck, ref int number)
        {
            if (deck == null)
                throw new ArgumentNullException("AbstractDeck deck не может быть null");

            var row = new DataGridViewRow();

            var cell_number = new DataGridViewTextBoxCell();
            var cell_deckName = new DataGridViewTextBoxCell();
            var cell_cards = new DataGridViewTextBoxCell();
            var cell_startingPoint = new DataGridViewTextBoxCell();
            var cell_description = new DataGridViewTextBoxCell();

            cell_number.Value = number++;
            cell_deckName.Value = string.IsNullOrWhiteSpace(deck.Name) ? "no name" : deck.Name;
            cell_cards.Value = deck.CardCount;
            cell_startingPoint.Value = deck.StartPoint.ToLongDateString();
            cell_description.Value = deck.Description;

            row.Cells.AddRange(cell_number, cell_deckName, cell_cards, cell_startingPoint, cell_description);

            row.Tag = deck;

            return row;
        }

        /// <summary>
        /// Скрывает строки не совпадающие с string filter
        /// </summary>
        /// <param name="filter"></param>
        private void FilterDataGridView(string filter)
        {
            dataGridView_Decks.ClearSelection();

            if (string.IsNullOrWhiteSpace(filter))
                filter = string.Empty;
            else
                filter = filter.Trim().ToLower();

            for (int r = 0; r < dataGridView_Decks.Rows.Count; r++)
            {
                dataGridView_Decks.Rows[r].Visible = false;

                for (int c = 0; c < dataGridView_Decks.Columns.Count; c++)
                {
                    if (dataGridView_Decks[c, r].Value.ToString().ToLower().Contains(filter))
                    {
                        dataGridView_Decks.Rows[r].Visible = true;
                        break;
                    }
                }
            }
        }

        private void DataGridView_Decks_DoubleClick(object sender, EventArgs e)
        {
            if ((sender as DataGridView).CurrentRow == null)
                return;

            OpenDeck((sender as DataGridView).CurrentRow.Tag as AbstractDeck);
        }

        private void DataGridView_Decks_SelectionChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }
        #endregion

        #region Удаление Колод

        private void DataGridView_Decks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridView_Decks.SelectedRows.Count > 0)
                HandleDecksRemoval();
            else if (e.KeyCode == Keys.Enter && dataGridView_Decks.SelectedRows.Count == 1)
                OpenDeck(dataGridView_Decks.SelectedRows[0].Tag as AbstractDeck);
        }

        protected virtual void BtnDeleteDeck_Click(object sender, EventArgs e)
        {
            HandleDecksRemoval();
        }

        /// <summary>
        /// Обработать удаление Колод
        /// </summary>
        private void HandleDecksRemoval()
        {
            if (dataGridView_Decks.SelectedRows.Count == 0)
                throw new Exception("dataGridView_Decks.SelectedRows.Count не может быть = 0");

            var question = (dataGridView_Decks.SelectedRows.Count == 1) ? "Delete Deck?" : "Delete Decks?";

            if (MessageBox.Show(question, "Deleting", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            RemoveSelectedDecks();

            Database.WriteXml();

            RemoveSelectedRows();

            RefreshButtons();
        }

        /// <summary>
        /// Удаление выделенных строк
        /// </summary>
        protected void RemoveSelectedRows()
        {
            int count = dataGridView_Decks.SelectedRows.Count;

            if (count == 0) return;

            while (count > 0)
            {
                dataGridView_Decks.Rows.RemoveAt(dataGridView_Decks.SelectedRows[0].Index);
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

            foreach (DataGridViewRow row in dataGridView_Decks.Rows)
            {
                row.Cells[0].Value = n++;
            }
        }

        /// <summary>
        /// Удаление выделенных Колод
        /// </summary>
        private void RemoveSelectedDecks()
        {
            foreach (DataGridViewRow row in dataGridView_Decks.SelectedRows)
            {
                var deck = row.Tag as AbstractDeck;
                decks.Remove(deck);
            }
        }

        #endregion
    }


}
