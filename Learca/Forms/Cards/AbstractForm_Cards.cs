using Learca.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Абстрактная форма с карточками из набора колод
    /// </summary>
    public abstract partial class AbstractForm_Cards : Form
    {
        protected readonly MainForm mainForm;
        protected readonly AbstractDeckSet decks;
        private CancellationTokenSource cts;

        public AbstractForm_Cards(MainForm mainForm, AbstractDeckSet deckSet)
        {
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");
            decks = deckSet ?? throw new ArgumentNullException("AbstractDeckSet deckSet не может быть null");

            InitializeComponent();

            MdiParent = mainForm;

            Load += Form_Cards_Load;
        }

        protected virtual void Form_Cards_Load(object sender, EventArgs e)
        {
            VisibleChanged += Form_Cards_VisibleChanged;
            btnLookAtDeck.Click += BtnLookAtDeck_Click;
            btnToDecks.Click += BtnToDecks_Click;
            tBFilter.Enter += TBFilter_Enter;
            tBFilter.Leave += TBFilter_Leave;
            tBFilter.TextChanged += TBFilter_TextChanged;
            dataGridView_Cards.DoubleClick += DataGridView_Cards_DoubleClick;
            dataGridView_Cards.SelectionChanged += DataGridView_Cards_SelectionChanged;
            dataGridView_Cards.KeyDown += DataGridView_Cards_KeyDown;
            btnOpenCard.Click += BtnOpenCard_Click;
            btnDeleteCard.Click += BtnDeleteCard_Click;
            btnMoveOut.Click += BtnMoveOut_Click;
            btnOpenDeck.Click += BtnOpenDeck_Click;

            Dock = DockStyle.Fill;
            DoubleBuffered = true;
            Text = "LEARCA. Cards";

            tBFilter.ForeColor = Color.Gray;
            tBFilter.Text = "...SEARCH...";

            dataGridView_Cards.Columns["Column_LeftSideImage"].DefaultCellStyle.NullValue = null;
            dataGridView_Cards.Columns["Column_RightSideImage"].DefaultCellStyle.NullValue = null;
        }
       
        protected abstract void OpenDeck(AbstractDeck deck);
        
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

        /// <summary>
        /// Обработать удаление карточек
        /// </summary>
        private void HandleCardsRemoval()
        {
            if (dataGridView_Cards.SelectedRows.Count == 0)
                throw new Exception("dataGridView_Cards.SelectedRows.Count не может быть = 0");

            string question = (dataGridView_Cards.SelectedRows.Count == 1) ? "Delete Card?" : "Delete Cards?";

            if (MessageBox.Show(question, "Deleting", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            RemoveSelectedCards();

            Database.WriteXml();

            RemoveSelectedRows();

            RefreshButtons();
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
        /// Удаление выделенных Карт
        /// </summary>
        private void RemoveSelectedCards()
        {
            foreach (DataGridViewRow row in dataGridView_Cards.SelectedRows)
            {
                var card = row.Tag as Card;
                card.RemoveCard();
            }
        }

                /// <summary>
        /// Открытие формы с Карточкой Form_Card
        /// </summary>
        /// <param name="card"></param>
        private void OpenCard(Card card)
        {
            if (card == null)
                throw new ArgumentNullException("Card card не может быть null");

            mainForm.OpenNextForm(new Form_Card(mainForm, card));
            mainForm.AddToLastForms(this);
        }

        protected abstract void BtnMoveOut_Click(object sender, EventArgs e);

        private void BtnDeleteCard_Click(object sender, EventArgs e)
        {
            HandleCardsRemoval();
        }

        private void BtnOpenCard_Click(object sender, EventArgs e)
        {
            if (dataGridView_Cards.SelectedRows.Count != 1)
                throw new Exception("dataGridView_Cards.SelectedRows.Count не может быть != 1");

            OpenCard(dataGridView_Cards.SelectedRows[0].Tag as Card);
        }

        protected abstract void BtnToDecks_Click(object sender, EventArgs e);

        protected virtual void BtnLookAtDeck_Click(object sender, EventArgs e)
        {
            if (dataGridView_Cards.SelectedRows.Count != 1)
                throw new Exception("dataGridView_Cards.SelectedRows.Count не может быть != 1");

            var card = dataGridView_Cards.SelectedRows[0].Tag as Card;

            var form = new Form_LookAtDeck(card.ParentDeck);

            form.ShowDialog();
        }

        private void DataGridView_Cards_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dataGridView_Cards.SelectedRows.Count > 0)
                HandleCardsRemoval();
            else if (e.KeyCode == Keys.Enter && dataGridView_Cards.SelectedRows.Count == 1)
                OpenCard(dataGridView_Cards.SelectedRows[0].Tag as Card);
        }

        private void Form_Cards_VisibleChanged(object sender, EventArgs e)
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

                dataGridView_Cards.Rows.Clear();
            }
        }

        private void BtnOpenDeck_Click(object sender, EventArgs e)
        {
            if (dataGridView_Cards.SelectedRows.Count != 1)
                throw new Exception("dataGridView_Cards.SelectedRows.Count не может быть != 1");

            var card = dataGridView_Cards.SelectedRows[0].Tag as Card;

            OpenDeck(card.ParentDeck);
        }

        /// <summary>
        /// Обновление кнопок на форме
        /// </summary>
        protected void RefreshButtons()
        {
            btnDeleteCard.Enabled =
                    btnMoveOut.Enabled = dataGridView_Cards.SelectedRows.Count > 0;

            btnLookAtDeck.Enabled =
                btnOpenCard.Enabled =
                btnOpenDeck.Enabled = dataGridView_Cards.SelectedRows.Count == 1;
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

            if (tBFilter.ForeColor == Color.Black)
                FilterDataGridView(tBFilter.Text);

            label_Loading.Visible = false;
        }

        /// <summary>
        /// Получить массив DataGridViewRow на основе имеющихся карт
        /// </summary>
        /// <returns></returns>
        private DataGridViewRow[] GetRows(CancellationToken token)
        {
            var rows = new List<DataGridViewRow>();

            int index = 1;

            foreach (var card in decks.GetAllCards())
            {
                if (token.IsCancellationRequested)
                    break;

                var row = CreateRow(card, ref index);

                if (row != null)
                    rows.Add(row);
            }

            return rows.ToArray();
        }

        /// <summary>
        /// Создание строки для dataGridView_Cards
        /// </summary>
        /// <param name="card"></param>
        /// <param name="index">Инкрементирует index при каждом выполнении</param>
        /// <returns></returns>
        protected virtual DataGridViewRow CreateRow(Card card, ref int index)
        {
            if (card == null)
                throw new ArgumentNullException("Card card не может быть null");

            var row = new DataGridViewRow();

            var cell_number = new DataGridViewTextBoxCell();
            var cell_leftSideValues = new DataGridViewTextBoxCell();
            var cell_leftSideImage = new DataGridViewImageCell();
            var cell_rightSideValues = new DataGridViewTextBoxCell();
            var cell_rightSideImage = new DataGridViewImageCell();

            cell_number.Value = index++;
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
        private static Image GetImage(string imagePath)
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

        private void DataGridView_Cards_SelectionChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }

        private void DataGridView_Cards_DoubleClick(object sender, EventArgs e)
        {
            if ((sender as DataGridView).CurrentRow == null)
                return;

            OpenCard((sender as DataGridView).CurrentRow.Tag as Card);
        }

        #endregion

        #region TextBox_Filter

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

        /// <summary>
        /// Скрывает строки не совпадающие с string filter
        /// </summary>
        /// <param name="filter"></param>
        private void FilterDataGridView(string filter)
        {
            dataGridView_Cards.ClearSelection();

            if (string.IsNullOrWhiteSpace(filter))
                filter = string.Empty;
            else
                filter = filter.Trim().ToLower();

            for (int r = 0; r < dataGridView_Cards.Rows.Count; r++)
            {
                dataGridView_Cards.Rows[r].Visible = false;

                for (int c = 0; c < dataGridView_Cards.Columns.Count; c++)
                {
                    if (dataGridView_Cards[c, r].Value!= null && dataGridView_Cards[c, r].Value.ToString().ToLower().Contains(filter))    //TODO: null?
                    {
                        dataGridView_Cards.Rows[r].Visible = true;
                        break;
                    }
                }
            }
        }

        #endregion
    }
}
