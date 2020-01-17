using System;
using System.Collections.Generic;
using CardGame;

namespace MacVersion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Deck deck = new Deck();


            while (deck.Count > 5)
            {
                deck.Shuffle();

                List<Card> hand = deck.Deal(2);
                bool keepGoing = true;
                int total = 0;
                while (keepGoing)
                {
                    total = 0;
                    foreach (Card card in hand)
                    {
                        Console.WriteLine(card);
                        total += card.MyValue;
                    }

                    Console.WriteLine("Your hand is worth: {0}", total);

                    if (total > 21) break;

                    Console.WriteLine("Hit or Stand? [h/s]");
                    if (Console.ReadKey().KeyChar == 's') break;

                    Console.WriteLine("\n___________________________");

                    hand.Add(deck.DealOne());
                }
                Console.WriteLine();
                if (total > 21)
                    Console.WriteLine("Busted!");
                else if (total == 21)
                    Console.WriteLine("BlackJack!");

                Console.WriteLine("Press any key for next hand.");

                Console.ReadKey();
            }

            Console.WriteLine("Done!");
        }
    }
}
