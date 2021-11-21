using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Learca
{
    public class DeckSet : AbstractDeckSet
    {
        public override AbstractDeck CreateDeck()
        {
            return new Deck(this);
        }

               /// <summary>
        /// Получение имен файлов изображений на карточках
        /// </summary>
        /// <returns></returns>
        public List<string> GetPicturePathes()
        {
            var pathes = new List<string>();

            foreach (var deck in decks)
            {
                foreach (var card in deck)
                {
                    var path = card.LeftSide.ImagePath;

                    if (!string.IsNullOrWhiteSpace(path))
                        pathes.Add(path);

                    path = card.RightSide.ImagePath;

                    if (!string.IsNullOrWhiteSpace(path))
                        pathes.Add(path);
                }
            }

            return pathes;
        }
    }
}
