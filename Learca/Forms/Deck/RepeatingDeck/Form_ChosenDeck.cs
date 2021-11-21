using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Форма для редактирования Избранной колоды
    /// </summary>
    class Form_ChosenDeck : AbstractForm_Deck
    {
        public Form_ChosenDeck(MainForm mainForm, AbstractDeck deck) : base(mainForm, deck)
        {
            Text = "LEARCA. Chosen Deck";
        }

        protected override void AbstractForm_Deck_Load(object sender, EventArgs e)
        {
            base.AbstractForm_Deck_Load(sender, e);

            btnCreateCard.Visible = false;
            btnMoveOut.Visible = false;
            btnMoveInside.Text = "ADD CARDS";

            btnDeleteDeck.Location = btnDeleteCard.Location;
            btnDeleteCard.Location = btnMoveOut.Location;
            btnMoveInside.Location = btnCreateCard.Location;
        }

        protected override void RefreshButtons()
        {
            base.RefreshButtons();
            btnMoveInside.Enabled = Database.DeckSet.CardCount - deck.CardCount > 0;
        }

        protected override void BtnMoveInside_Click(object sender, EventArgs e)
        {
            mainForm.OpenNextForm(new Form_Cards_AddToChosenDeck(mainForm, deck));
            mainForm.AddToLastForms(this);
        }
    }
}
