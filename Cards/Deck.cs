using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    /// <summary>
    /// Deck represents a deck of cards.  This implements the IEnumerable interface so that you can use it directly in foreach statements:
    /// e.g.
    /// 
    /// foreach(Card card in deck) { ... }
    /// </summary>
    public class Deck : IEnumerable<Card>
    {

        public List<Card> TheDeck;

        public IShuffleAlgorithm myShuffler;

        public Deck(bool aceHigh = false)
        {
            // the default shuffle algorithm is RifleShuffle.
            myShuffler = RifleShuffle.RifleShuffler;
            TheDeck = new List<Card>();
            foreach(Card.Suit suit in Card.Suit.Suits)
            {
                foreach(Card.Value value in aceHigh?Card.Value.AcesHighValues:Card.Value.AcesLowValues)
                {
                    TheDeck.Add(new Card(suit, value));
                }
            }
        }

        /// <summary>
        /// Add a card to the deck.
        /// </summary>
        /// <param name="card"></param>
        public void Add(Card card) => TheDeck.Add(card);

        /// <summary>
        /// Add 
        /// </summary>
        /// <param name="cards"></param>
        public void AddRange(IEnumerable<Card> cards) => TheDeck.AddRange(cards);
        
        /// <summary>
        /// Deals the top card from the deck.
        /// </summary>
        /// <returns></returns>
        public Card DealOne()
        {
            Card topCard = TheDeck[0];
            TheDeck.RemoveAt(0);

            return topCard;
        }

        /// <summary>
        /// Deals a given number of cards from the deck.
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public List<Card> Deal(int count)
        {
            if (count > TheDeck.Count) throw new DeckException("The deck doesn't have that many cards.");

            List<Card> cards = TheDeck.GetRange(0, count);
            TheDeck.RemoveRange(0, count);

            return cards;
        }

        public int Count => TheDeck.Count;

        /// <summary>
        /// Shuffles the deck using the elected shuffler algorithm.
        /// You can create your own shuffle algorithms by implementing the IShuffleAlgortihm interface.
        /// </summary>
        public void Shuffle()
        {
            myShuffler.Shuffle(ref TheDeck);
        }

        IEnumerator<Card> IEnumerable<Card>.GetEnumerator() => TheDeck.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => TheDeck.GetEnumerator();
    }

    public class DeckException : Exception
    {
        public DeckException(String message = null, Exception innerException = null) 
            : base(message, innerException) { }
    }
}
