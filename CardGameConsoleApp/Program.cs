using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;

namespace CardGameConsoleApp
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Deck deck = new Deck();

            foreach(Card card in deck)
            {
                Console.WriteLine(card);
            }

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

                    hand.Add(deck.DealOne());
                }

                if (total > 21)
                    Console.WriteLine("Busted!");
                else if (total == 21)
                    Console.WriteLine("BlackJack!");

                Console.ReadKey();
            }

            Console.WriteLine("Done!");
        }
    }
}
