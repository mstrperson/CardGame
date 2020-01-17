using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Card : IComparable<Card>
    {
        #region Helper Classes
        /// <summary>
        /// Represent the various suits of a deck of cards.
        /// Suits are not comparable other than Equality.
        /// </summary>
        public class Suit
        {
            public static Suit Spades = new Suit("Spades");
            public static Suit Hearts = new Suit("Hearts");
            public static Suit Clubs = new Suit("Clubs");
            public static Suit Diamonds = new Suit("Diamonds");

            public static List<Suit> Suits = new List<Suit>()
            { Spades, Hearts, Clubs, Diamonds };

            private string title;
            private Suit(string title)
            {
                this.title = title;
            }

            public override string ToString() => this.title;

            public override bool Equals(object obj)
            {
                if (obj is Suit)
                    return ((Suit)obj).title.Equals(this.title);
                else
                    return false;
            }
        }

        /// <summary>
        /// Represents the Values associated with cards.  These have numeric values as well as textual descriptions.
        /// Values are comparable and implement boolean comparison operators.
        /// for use in Scoring, Values also implement arithmetic operators + and - and return integers.
        /// </summary>
        public class Value : IEquatable<Value>
        {
            private int value;
            private string title;

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

            public static int operator -(Value a, Value b) => a.value - b.value;
            public static int operator -(int a, Value b) => a - b.value;
            public static int operator -(Value a, int b) => a.value - b;

            public static int operator +(Value a, Value b) => a.value + b.value;
            public static int operator +(int a, Value b) => a + b.value;
            public static int operator +(Value a, int b) => a.value + b;

            public override string ToString() => this.title;

            #region Auto Generated Equality Comparison Code
            public override bool Equals(object obj)
            {
                return Equals(obj as Value);
            }

            public bool Equals(Value other)
            {
                return other != null &&
                       value == other.value;
            }

            /// <summary>
            /// This is auto generated and you dont need to worry about it at this point.
            /// </summary>
            /// <returns></returns>
            public override int GetHashCode()
            {
                var hashCode = 972665443;
                hashCode = hashCode * -1521134295 + value.GetHashCode();
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(title);
                return hashCode;
            }
            #endregion

            #region Card Values
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
            #endregion


            /// <summary>
            /// Statically defined Values in useful List format ordered from AceLow to King
            /// </summary>
            public static List<Value> AcesLowValues = new List<Value>()
            { AceLow, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

            /// <summary>
            /// Statically defined Values in useful List format ordered from 2 to AceHigh.
            /// </summary>
            public static List<Value> AcesHighValues = new List<Value>()
            { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, AceHigh };
        }
        #endregion

        /// <summary>
        /// Value of this Card.
        /// </summary>
        public Value MyValue { get; protected set; }
        /// <summary>
        /// Suit of this card.
        /// </summary>
        public Suit MySuit { get; protected set; }

        /// <summary>
        /// Initialize a Card to be played with.
        /// </summary>
        /// <param name="suit">the Suit</param>
        /// <param name="value">the Value</param>
        public Card(Suit suit, Value value)
        {
            MyValue = value;
            MySuit = suit;
        }

        /// <summary>
        /// Get a text representation of this card.
        /// </summary>
        /// <returns></returns>
        public override string ToString() => string.Format("{0} of {1}", MyValue, MySuit);

        /// <summary>
        /// Compare two Cards.  Returns the difference in their values.
        /// Ignores suit.
        /// </summary>
        /// <param name="obj">card to compare to.</param>
        /// <returns></returns>
        int CompareTo(Card obj) => this.MyValue - obj.MyValue;

        /// <summary>
        /// Implement the IComparable interface using the CompareTo method.
        /// This allows you to do things like auto-sort lists of cards.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        int IComparable<Card>.CompareTo(Card other) => this.CompareTo(other);

        /// <summary>
        /// Determine if two cards are the same suit and value.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        bool Equals(Card other) => this.MySuit.Equals(other.MySuit) && this.MyValue == other.MyValue;

        /// <summary>
        /// Determines if two cards have the same value;
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        bool EqualValue(Card other) => this.CompareTo(other) == 0;

    }
}
