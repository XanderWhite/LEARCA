using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Форма для редактирования Набора колод
    /// </summary>
    class Form_DeckSet : AbstractForm_DeckSet
    {
        public Form_DeckSet(MainForm mainForm)
     : base(mainForm, Database.DeckSet)
        {

        }

        protected override void AbstractForm_DeckSet_Load(object sender, EventArgs e)
        {
            base.AbstractForm_DeckSet_Load(sender, e);

            btnToCards.Visible = true;
            btnToCards.Click += BtnToCards_Click;

            Text = "LEARCA. Decks";
        }

        protected override void RefreshButtons()
        {
            base.RefreshButtons();

            btnToCards.Enabled = decks.CardCount > 0;
        }

        /// <summary>
        /// Открытие формы для редактирования колоды Form_Deck
        /// </summary>
        /// <param name="deck"></param>
        protected override void OpenDeck(AbstractDeck deck)
        {
            if (deck == null)
                throw new ArgumentNullException("AbstractDeck deck не может быть null");

            mainForm.OpenNextForm(new Form_Deck(mainForm, deck as AbstractDeck));
            mainForm.AddToLastForms(this);
        }

        protected void BtnToCards_Click(object sender, EventArgs e)
        {
            mainForm.OpenNextForm(new Form_Cards(mainForm));
            mainForm.AddToLastForms(this);
        }
    }
}
