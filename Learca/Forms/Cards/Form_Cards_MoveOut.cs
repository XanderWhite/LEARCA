using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Форма с карточками для вставки в Колоду
    /// </summary>
    class Form_Cards_MoveOut : Form_Cards
    {
        /// <summary>
        /// Колода в которую необходимо перенести карточки
        /// </summary>
        protected readonly AbstractDeck targetDeck;

        public Form_Cards_MoveOut(MainForm mainForm, AbstractDeck targetDeck) : base(mainForm)
        {
            this.targetDeck = targetDeck ?? throw new ArgumentNullException("AbstractDeck targetDeck не может быть null");
        }

        protected override void Form_Cards_Load(object sender, EventArgs e)
        {
            base.Form_Cards_Load(sender, e);

            btnDeleteCard.Visible = false;
            btnOpenDeck.Visible = false;
            btnToDecks.Visible = false;

            Text = "LEARCA. Cards. Insert to Deck";
            btnLookAtDeck.Location = btnDeleteCard.Location;
        }

        protected override void BtnMoveOut_Click(object sender, EventArgs e)
        {
            if (dataGridView_Cards.SelectedRows.Count == 0)
                throw new Exception("dataGridView_Cards.SelectedRows.Count не может быть = 0");

            string question = (dataGridView_Cards.SelectedRows.Count == 1) ? "Move Card?" : "Move Cards?";

            if (MessageBox.Show(question, "Moving", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            foreach (DataGridViewRow row in dataGridView_Cards.SelectedRows)
            {
                var card = row.Tag as Card;
                targetDeck.Save(card);
            }

            Database.WriteXml();

            RemoveSelectedRows();

            RefreshButtons();
        }

        /// <summary>
        /// Создание строки для dataGridView_Cards. Если card уже находится в targetDeck возвращается null
        /// </summary>
        /// <param name="card"></param>
        /// <param name="index">Инкрементирует index при каждом выполнении</param>
        /// <returns></returns>
        protected override DataGridViewRow CreateRow(Card card, ref int index)
        {
            if (targetDeck.Contains(card))
                return null;

            return base.CreateRow(card, ref index);
        }
    }
}
