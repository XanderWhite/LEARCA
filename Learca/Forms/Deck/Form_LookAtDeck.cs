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
    /// Aорма описывающая колоду и содержащиеся в ней карты. Без возможности их редактирования
    /// </summary>
    internal partial class Form_LookAtDeck : Form
    {
        private readonly AbstractDeck deck;
        private readonly MainForm mainForm;
        private CancellationTokenSource cts;

        public int STANDART_GRID_WIDTH = 1149;

        public Form_LookAtDeck(MainForm mainForm, AbstractDeck deck)
        {
            this.deck = deck ?? throw new ArgumentNullException("AbstractDeck deck не может быть null");
            this.mainForm = mainForm ?? throw new ArgumentNullException("MainForm mainForm не может быть null");

            InitializeComponent();

            Load += Form_LookAtDeck_Load;
        }

        private void Form_LookAtDeck_Load(object sender, EventArgs e)
        {
            VisibleChanged += Form_LookAtDeck_VisibleChanged;

            dataGridView_Cards.Columns["Column_LeftSideImage"].DefaultCellStyle.NullValue = null;
            dataGridView_Cards.Columns["Column_RightSideImage"].DefaultCellStyle.NullValue = null;

            foreach (DataGridViewColumn column in dataGridView_Cards.Columns)
            {
                column.Width = column.Width * dataGridView_Cards.Width / STANDART_GRID_WIDTH;
            }
        }

        private void Form_LookAtDeck_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                cts = new CancellationTokenSource();
                FillForm();
            }
            else
            {
                if (cts != null)
                    cts.Cancel();
            }
        }

        /// <summary>
        /// Заполнение формы
        /// </summary>
        private void FillForm()
        {
            FillDataGridView_Cards_Async();

            if (string.IsNullOrWhiteSpace(deck.Name))
            {
                textBoxDeckName.ForeColor = Color.Gray;
                textBoxDeckName.Text = "NO NAME";
            }
            else
            {
                textBoxDeckName.ForeColor = Color.Black;
                textBoxDeckName.Text = deck.Name;
            }

            textBoxStartingPoint.Text = deck.StartPoint.ToLongDateString();

        }

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

                rows[i] = CreateRow(deck[i]);
            }

            return rows;
        }

        /// <summary>
        /// Содание строки для dataGridView_Cards
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        protected virtual DataGridViewRow CreateRow(Card card)
        {
            if (card == null)
                throw new ArgumentNullException("Card card не может быть null");

            var row = new DataGridViewRow();

            var cell_number = new DataGridViewTextBoxCell();
            var cell_leftSideValues = new DataGridViewTextBoxCell();
            var cell_leftSideImage = new DataGridViewImageCell();
            var cell_rightSideValues = new DataGridViewTextBoxCell();
            var cell_rightSideImage = new DataGridViewImageCell();

            cell_number.Value = card.Index + 1;
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
    }
}
