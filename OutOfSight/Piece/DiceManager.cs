using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OutOfSight.Piece
{
    public class DiceManager
    {

        public List<Die> dice { get; }
        private int diceInPlayCount = 3;
        private int maxDiceValue = 6;

        public DiceManager()
        {
            Die.maxDiceValue = maxDiceValue;
            for (int i = 0; i < diceInPlayCount; i++)
            {
                dice.Add(new Die());
            }
        }

        public void rollDice()
        {
            foreach(Die d in dice)
            {
                d.roll();
            }
        }

        public bool hasDoubles()
        {
            foreach(Die d1 in dice)
            {
                int count = (
                    from d2 in dice
                    where d1.value == d2.value
                    select d2.value).Count();
                if (count > 1) return true;
            }

            return false;
        }

        public List<int> getDiceVals()
        {
            List<int> vals = new List<int>();
            foreach(Die d in dice)
                vals.Add(d.value);
            return vals;
        }

        public void setDiceVals(List<int> vals)
        {
            dice.Clear();
            foreach(int i in vals)
            {
                dice.Add(new Die(i));
            }
        }

    }
}
