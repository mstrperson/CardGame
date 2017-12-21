using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using CardGame;

namespace WindowsFormsApp1
{
    public class VisualCard : Card
    {
        public VisualCard(Suit suit, Value value)
            :base(suit, value)
        {
            String fileName = String.Format("\\CardImages\\{0}{1}.png", value.value == 10? "10" : value.ToString()[0].ToString(), suit.ToString()[0]);
            CardImage = Image.FromFile(Environment.CurrentDirectory + fileName);
        }

        public Image CardImage { get; protected set; }
        
    }
}
