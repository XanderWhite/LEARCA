using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Форма для редактирования набора избранных колод
    /// </summary>
    class Form_ChosenDeckSet : AbstractForm_DeckSet
    {
        public Form_ChosenDeckSet(MainForm mainForm) : base(mainForm, Database.ChosenDeckSet)
        {

        }

        protected override void AbstractForm_DeckSet_Load(object sender, EventArgs e)
        {
            base.AbstractForm_DeckSet_Load(sender, e);

            Text = "LEARCA. Chosen Decks";
        }

        /// <summary>
        /// Открывает форму для редактирования колоды Form_СhosenDeck
        /// </summary>
        /// <param name="deck"></param>
        protected override void OpenDeck(AbstractDeck deck)
        {
            mainForm.OpenNextForm(new Form_ChosenDeck(mainForm, deck));
            mainForm.AddToLastForms(this);
        }
    }
}
