using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Форма для колоды в которую необходимо переместить карточки
    /// </summary>
    class Form_Deck_MoveInside :AbstractForm_Deck_MoveInside
    {
        public Form_Deck_MoveInside(MainForm mainForm, Deck deck, IEnumerable<Card> movingCards)
            : base(mainForm, deck, movingCards)
        {

        }

        protected override void AbstractForm_Deck_Load(object sender, EventArgs e)
        {
            base.AbstractForm_Deck_Load(sender, e);
            
            Text = "LEARCA. Move cards to this Deck";
        }
    }
}
