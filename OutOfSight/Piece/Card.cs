using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OutOfSight.Piece
{
    public class Card
    {
        public Color backcolor { get; set; }
        public Color textcolor { get; set; }
        public int value { get; set; }

        public Card() { }
        public Card(Color backColor, Color textColor, int value)
        {
            this.backcolor = backColor;
            this.textcolor = textColor;
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            Card toCompare = (Card)obj;
            return this.backcolor.Equals(toCompare.backcolor) &&
                    this.textcolor.Equals(toCompare.textcolor) &&
                    this.value.Equals(toCompare.value);
        }

        public override int GetHashCode()
        {
            return
                this.backcolor.GetHashCode() *
                this.textcolor.GetHashCode() *
                this.value * 13;
        }

    }
}
