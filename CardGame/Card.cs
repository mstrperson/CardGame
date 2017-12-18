using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Card : IComparable
    {
        #region Helper Classes
        public class Suit
        {
            public static Suit Spades = new Suit("Spades");
            public static Suit Hearts = new Suit("Hearts");
            public static Suit Clubs = new Suit("Clubs");
            public static Suit Diamonds = new Suit("Diamonds");

            public static List<Suit> Suits = new List<Suit>()
            { Spades, Hearts, Clubs, Diamonds };

            private String title;
            private Suit(string title)
            {
                this.title = title;
            }

            public override String ToString() => this.title;

            public override bool Equals(object obj)
            {
                if (obj is Suit)
                    return ((Suit)obj).title.Equals(this.title);
                else
                    return false;
            }
        }

        public class Value
        {
            public int value;
            public String title;

            private Value(int value, string title)
            {
                this.title = title;
                this.value = value;
            }

            public static bool operator >(Value a, Value b) => a.value > b.value;
            public static bool operator <(Value a, Value b) => a.value < b.value;

            public static bool operator ==(Value a, Value b) => a.value == b.value;
            public static bool operator !=(Value a, Value b) => a.value != b.value;

            public static bool operator >=(Value a, Value b) => a.value >= b.value;
            public static bool operator <=(Value a, Value b) => a.value <= b.value;

            public override string ToString() => this.title;

            public static Value AceLow = new Value(1, "Ace");
            public static Value Two = new Value(2, "2");
            public static Value Three = new Value(3, "3");
            public static Value Four = new Value(4, "4");
            public static Value Five = new Value(5, "5");
            public static Value Six = new Value(6, "6");
            public static Value Seven = new Value(7, "7");
            public static Value Eight = new Value(8, "8");
            public static Value Nine = new Value(9, "9");
            public static Value Ten = new Value(10, "10");
            public static Value Jack = new Value(11, "Jack");
            public static Value Queen = new Value(12, "Queen");
            public static Value King = new Value(13, "King");
            public static Value AceHigh = new Value(14, "Ace");

            public static List<Value> AcesLowValues = new List<Value>()
            { AceLow, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

            public static List<Value> AcesHighValues = new List<Value>()
            { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, AceHigh };
        }
        #endregion

        public Value myValue { get; protected set; }
        public Suit mySuit { get; protected set; }

        public Card(Suit suit, Value value)
        {
            myValue = value;
            mySuit = suit;
        }

        public override string ToString() => String.Format("{0} of {1}", myValue, mySuit);

        int IComparable.CompareTo(object obj)
        {
            // if the object is not an instance of the Card class
            if(!(obj is Card))
            {
                throw new ArgumentException("Cannot compare a Card to anything but a Card.");
            }
            else
            {
                return this.myValue.value - ((Card)obj).myValue.value;
            }
        }
    }
}
