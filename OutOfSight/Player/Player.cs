using OutOfSight.Piece;
using OutOfSight.Player.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OutOfSight.Player
{
    public class Player
    {
        public IPlayerDeck deck { get; }
        public string name { get; }
        public List<int> score { get; }
        private int roundCount = 3;

        public Player(string name, IPlayerDeck deck)
        {
            this.name = name;
            this.deck = deck;
            this.score = new List<int>();
        }


    }
}
