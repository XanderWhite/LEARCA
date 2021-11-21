using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Абстрактная форма для выбора колоды в которую необходимо переместить карточки
    /// </summary>
    abstract class AbstractForm_DeckSet_MoveInside : AbstractForm_DeckSet
    {
        /// <summary>
        /// Колода не отображаемая в dataGridView_Decks
        /// </summary>
        private readonly AbstractDeck hiddenDeck;

        protected IEnumerable<Card> movingCards;

        public AbstractForm_DeckSet_MoveInside(MainForm mainForm, AbstractDeckSet deckCollection, IEnumerable<Card> movingCards, AbstractDeck hiddenDeck)
            : base(mainForm, deckCollection)
        {
            if (movingCards == null)
                throw new ArgumentNullException("IEnumerable<Card> movingCards не может быть null");
            if (movingCards.Count() == 0)
                throw new Exception("movingCards.Count должен быть > 0");

            this.movingCards = movingCards;
            this.hiddenDeck = hiddenDeck;
        }

        protected override void AbstractForm_DeckSet_Load(object sender, EventArgs e)
        {
            base.AbstractForm_DeckSet_Load(sender, e);

            btnDeleteDeck.Visible = false;
            
            btnMoveInside.Location = btnDeleteDeck.Location;
            btnMoveInside.Visible = true;
            btnMoveInside.Click += BtnMoveInside_Click;

            dataGridView_Decks.MultiSelect = false;
        }

        protected override void RefreshButtons()
        {
            base.RefreshButtons();

            btnMoveInside.Enabled = dataGridView_Decks.SelectedRows.Count == 1;
        }

        protected void BtnMoveInside_Click(object sender, EventArgs e)
        {
            if (dataGridView_Decks.SelectedRows.Count != 1)
                throw new Exception("dataGridView_Decks.SelectedRows.Count не может быть != 1");

            string question = (movingCards.Count() == 1) ? "Move Card?" : "Move Cards?";

            if (MessageBox.Show(question, "Moving", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var deck = dataGridView_Decks.CurrentRow.Tag as AbstractDeck;

            deck.Save(movingCards);

            Database.WriteXml();

            mainForm.LoadCheckpoint();
        }

        /// <summary>
        /// Создание Строки для dataGridView_Decks
        /// </summary>
        /// <param name="deck"></param>
        /// <returns></returns>
        protected override DataGridViewRow CreateRow(AbstractDeck deck, ref int number)
        {
            if (ReferenceEquals(deck, hiddenDeck))
                return null;

            return base.CreateRow(deck, ref number);
        }
    }
}
