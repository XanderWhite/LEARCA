using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Форма для выбора колоды в которую необходимо переместить карточки
    /// </summary>
    class Form_DeckSet_MoveInside : AbstractForm_DeckSet_MoveInside
    {
        public Form_DeckSet_MoveInside(MainForm mainForm, IEnumerable<Card> movingCards)
            :base(mainForm, Database.DeckSet, movingCards, null)
        {

        }

        public Form_DeckSet_MoveInside(MainForm mainForm, IEnumerable<Card> movingCards, AbstractDeck hiddenDeck)
            :base(mainForm, Database.DeckSet, movingCards, hiddenDeck)
        {

        }

        protected override void AbstractForm_DeckSet_Load(object sender, EventArgs e)
        {
            base.AbstractForm_DeckSet_Load(sender, e);

            Text = "LEARCA. Select Deck to move Cards";
        }

        /// <summary>
        /// Открытие колоды в которую необходимо переместить карточки в форме Form_Deck_MoveInside
        /// </summary>
        /// <param name="deck"></param>
        protected override void OpenDeck(AbstractDeck deck)
        {
            mainForm.OpenNextForm(new Form_Deck_MoveInside(mainForm, deck as Deck, movingCards));
            mainForm.AddToLastForms(this);
        }


    }
}
