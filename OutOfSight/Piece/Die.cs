using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OutOfSight.Piece
{
    public class Die
    {
        private static Random rand = new Random();
        public Image image { get; set; }
        public int value { get; set; }
        public static int maxDiceValue = 6;
        private static List<Image> images = new List<Image>
        {
            Properties.Resources._1,
            Properties.Resources._2,
            Properties.Resources._3,
            Properties.Resources._4,
            Properties.Resources._5,
            Properties.Resources._6
        };

        public Die()
        {
            value = maxDiceValue;
        }

        public Die(int startVal)
        {
            value = startVal;
        }
        
        private int getRandomDiceNumber()
        {
            return rand.Next(0, maxDiceValue);
        }

        public void roll()
        {
            value = getRandomDiceNumber();
            image = images[value];
        }

    }
}
