using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Форма для редактирования колоды
    /// </summary>
    class Form_Deck : AbstractForm_Deck
    {
        public Form_Deck(MainForm mainForm, AbstractDeck deck) : base(mainForm, deck)
        {
            Text = "LEARCA. Deck";
        }

        protected override void AbstractForm_Deck_Load(object sender, EventArgs e)
        {
            base.AbstractForm_Deck_Load(sender, e);

            btnMoveOut.Click += BtnMoveOut_Click;
        }

        protected override void RefreshButtons()
        {
            base.RefreshButtons();
            btnMoveInside.Enabled = deck.ParentDeckSet.GetCardsCountWithoutDecksContaining(deck) > 0;
        }

        protected virtual void BtnMoveOut_Click(object sender, EventArgs e)
        {
            var cards = GetCardsFrom(dataGridView_Cards.SelectedRows);

            mainForm.OpenNextForm(new Form_DeckSet_MoveInside(mainForm, cards, deck));
            mainForm.AddToLastForms(this);
            mainForm.Checkpoint = this;
        }

        protected override void BtnMoveInside_Click(object sender, EventArgs e)
        {
            mainForm.OpenNextForm(new Form_Cards_MoveOut(mainForm, deck));
            mainForm.AddToLastForms(this);
        }
    }
}
