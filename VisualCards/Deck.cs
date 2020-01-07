using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class VisualDeck : Deck
    {
        public VisualDeck(bool aceHigh = false)
        {
            // the default shuffle algorithm is RifleShuffle.
            myShuffler = RifleShuffle.RifleShuffler;
            TheDeck = new List<Card>();
            foreach (Card.Suit suit in Card.Suit.Suits)
            {
                foreach (Card.Value value in aceHigh ? Card.Value.AcesHighValues : Card.Value.AcesLowValues)
                {
                    TheDeck.Add(new VisualCard(suit, value));
                }
            }
        }
    }
}
