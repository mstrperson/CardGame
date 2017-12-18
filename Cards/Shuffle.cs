using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    /// <summary>
    /// Abstraction for different shuffling algorithms.
    /// </summary>
    public interface IShuffleAlgorithm
    {
        void Shuffle(ref List<Card> deck);
    }

    /// <summary>
    /// Shuffles the cards by randomly swaping cards in the deck.
    /// </summary>
    public class RandomShuffle : IShuffleAlgorithm
    {
        /// <summary>
        /// Shuffles the cards by randomly swaping cards in the deck.
        /// </summary>
        public static RandomShuffle RandomShuffler = new RandomShuffle();

        protected Random rand = new Random();
        public int IterationCount = 3;
        
        /// <summary>
        /// Shuffles the cards by randomly swaping cards in the deck.
        /// </summary>
        /// <param name="deck"></param>
        public void Shuffle(ref List<Card> deck)
        {            
            for(int i = 0; i < IterationCount; i++)
            {
                for(int j = 0; j < deck.Count; j++)
                {
                    int a = rand.Next(deck.Count);
                    int b = rand.Next(deck.Count);

                    Card temp = deck[a];
                    deck[a] = deck[b];
                    deck[b] = temp;
                }
            }
        } 
    }

    /// <summary>
    /// Rifle Shuffle Simpulates shuffling a deck of cards by spliting the deck 
    /// and then inserting the cards a couple at a time from each half back into the original deck.
    /// </summary>
    public class RifleShuffle : IShuffleAlgorithm
    {
        /// <summary>
        /// Rifle Shuffle Simpulates shuffling a deck of cards by spliting the deck 
        /// and then inserting the cards a couple at a time from each half back into the original deck.
        /// </summary>
        public static RifleShuffle RifleShuffler = new RifleShuffle();

        protected Random rand = new Random();
        public int IterationCount = 7;
        
        /// <summary>
        /// Rifle Shuffle Simpulates shuffling a deck of cards by spliting the deck 
        /// and then inserting the cards a couple at a time from each half back into the original deck.
        /// </summary>
        public void Shuffle(ref List<Card> deck)
        {
            for (int i = 0; i < IterationCount; i++)
            {
                int splitPoint = deck.Count / 2 + (rand.Next(6) - 3);
                List<Card> a = deck.GetRange(0, splitPoint);
                List<Card> b = deck.GetRange(splitPoint, deck.Count - splitPoint);

                deck.Clear();
                while(a.Count > 0 || b.Count > 0)
                {
                    if(a.Count > 0)
                    {
                        for(int j = 0; j < Math.Min(rand.Next(2)+1, a.Count); j++)
                        {
                            deck.Add(a[0]);
                            a.RemoveAt(0);
                        }
                    }
                    if (b.Count > 0)
                    {
                        for (int j = 0; j < Math.Min(rand.Next(2) + 1, b.Count); j++)
                        {
                            deck.Add(b[0]);
                            b.RemoveAt(0);
                        }
                    }
                }
            }
        }
    }
}
