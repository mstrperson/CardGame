using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardGame;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<PictureBox> Cards;
        VisualDeck deck;
        List<Card> Hand;
        bool gameover = false;

        public Form1()
        {

            deck = new VisualDeck();
            deck.Shuffle();

            Hand = new List<Card>();

            InitializeComponent();


            Cards = new List<PictureBox>();
            Cards.Add(Card1);
            Cards.Add(Card2);
            Cards.Add(Card3);
            Cards.Add(Card4);
            Cards.Add(Card5);
            Cards.Add(Card6);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!gameover)
            {
                if (Hand.Count == 0)
                {
                    List<Card> delt = deck.Deal(2);

                    Hand.Add(delt[0]);
                    Hand.Add(delt[1]);

                    Card1.Image = ((VisualCard)Hand[0]).CardImage;
                    Card2.Image = ((VisualCard)Hand[1]).CardImage;
                }
                else
                {
                    Hand.Add(deck.DealOne());
                    Cards[Hand.Count - 1].Visible = true;
                    Cards[Hand.Count - 1].Image = ((VisualCard)Hand.Last()).CardImage;
                }

                int score = 0;
                foreach (Card card in Hand)
                {
                    score += card.MyValue;
                }

                if (score > 21)
                {
                    this.ScoreLabel.Text = "BUSTED";
                    gameover = true;
                }
                else
                {
                    this.ScoreLabel.Text = string.Format("{0}", score);
                }
            }
            else
            {
                
            }
        }
    }
}
