using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Форма с карточками из набора колод
    /// </summary>
    class Form_Cards:AbstractForm_Cards
    {
        public Form_Cards(MainForm mainForm)
            :base(mainForm, Database.DeckSet)
        {

        }

        protected override void BtnToDecks_Click(object sender, EventArgs e)
        {
            mainForm.OpenNextForm(new Form_DeckSet(mainForm));
            mainForm.AddToLastForms(this);
        }

        protected override void BtnMoveOut_Click(object sender, EventArgs e)
        {
            var cards = GetCardsFrom(dataGridView_Cards.SelectedRows);

            mainForm.Checkpoint = this;
            mainForm.OpenNextForm(new Form_DeckSet_MoveInside(mainForm, cards));
            mainForm.AddToLastForms(this);
        }

        /// <summary>
        /// Открытие колоды в форме Form_Deck
        /// </summary>
        /// <param name="deck"></param>
        protected override void OpenDeck(AbstractDeck deck)
        {
            if (deck == null)
                throw new ArgumentNullException("AbstractDeck deck не может быть null");

            mainForm.OpenNextForm(new Form_Deck(mainForm, deck as Deck));
            mainForm.AddToLastForms(this);
        }
    }
}
