using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Learca
{
    public class ChosenDeckSet : AbstractDeckSet
    {
        public override AbstractDeck CreateDeck()
        {
            return new ChosenDeck(this);
        }
    }
}
