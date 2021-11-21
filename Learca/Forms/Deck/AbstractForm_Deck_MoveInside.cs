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
    /// Абстрактная форма для колоды в которую необходимо переместить карточки
    /// </summary>
    abstract class AbstractForm_Deck_MoveInside : AbstractForm_Deck
    {
        protected IEnumerable<Card> movingCards;

        public AbstractForm_Deck_MoveInside(MainForm mainForm, AbstractDeck deck, IEnumerable<Card> movingCards) : base(mainForm, deck)
        {
            if (movingCards == null)
                throw new ArgumentNullException("IEnumerable<Card> movingCards не может быть null");
            if (movingCards.Count() == 0)
                throw new Exception("movingCards.Count должен быть > 0");

            this.movingCards = movingCards;
        }

        protected override void AbstractForm_Deck_Load(object sender, EventArgs e)
        {
            base.AbstractForm_Deck_Load(sender, e);

            dataGridView_Cards.DoubleClick -= DataGridView_Cards_DoubleClick;
            dataGridView_Cards.KeyDown -= DataGridView_Cards_KeyDown;
            btnCreateCard.Visible = false;
            btnDeleteDeck.Visible = false;
            btnDeleteCard.Visible = false;
            btnEditCard.Visible = false;
            btnMoveOut.Visible = false;

            btnMoveInside.Location = btnCreateCard.Location;
        }

        protected override void BtnMoveInside_Click(object sender, EventArgs e)
        {
            string question = (movingCards.Count() == 1) ? "Move Card?" : "Move Cards?";

            if (MessageBox.Show(question, "Moving", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            deck.Save(movingCards);

            Database.WriteXml();

            mainForm.LoadCheckpoint();
        }

        /// <summary>
        /// Содание строки для dataGridView_Cards
        /// </summary>
        /// <param name="card"></param>
        /// <param name="number">номер карточки отображаемый в первой колонке</param>
        /// <returns></returns>
        protected override DataGridViewRow CreateRow(Card card, int number)
        {
            var row = base.CreateRow(card, number);

            if (movingCards.Contains(card))
                row.DefaultCellStyle.ForeColor = Color.LightGray;

            return row;
        }
    }
}
