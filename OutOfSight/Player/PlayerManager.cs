using OutOfSight.Game;
using OutOfSight.Player.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OutOfSight.Player
{
    class PlayerManager
    {
        public List<Player> players = new List<Player>();
        public int maxPlayer = 6;
        public int currentPlayer = 0;

        public PlayerManager() {}

        public bool addPlayer(string name)
        {
            if (players.Count == maxPlayer) return false;

            switch(GameManager.difficulty)
            {
                case GameDifficulty.Basic:
                    players.Add(new Player(name, new BasicDeck()));
                    break;
                case GameDifficulty.Advanced:
                    players.Add(new Player(name, new AdvancedDeck()));
                    break;
            }
            return true;
        }

        public int getPlayerCount()
        {
            return players.Count;
        }

        public void nextPlayer()
        {
            currentPlayer = (currentPlayer + 1) % players.Count;
        }

        public Player getCurrentPlayer()
        {
            return players.ElementAt(currentPlayer);
        }

    }
}
