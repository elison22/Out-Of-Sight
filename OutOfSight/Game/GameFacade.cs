using OutOfSight.Piece;
using OutOfSight.Player;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OutOfSight.Game
{
    class GameFacade
    {

        GameManager gameManager;
        PlayerManager playerManager;

        public void newGame(GameDifficulty difficulty)
        {
            GameManager.state = GameState.Setup;
            gameManager = new GameManager();
            playerManager = new PlayerManager();
        }

        public bool addUser(string name)
        {
            return playerManager.addPlayer(name);
        }

        public List<Card> startGame()
        {
            return gameManager.getMaxCards();
        }
        /*
        public List<Card> refresh(List<Card> selectedCards)
        {
            gameManager.playCards(selectedCards);
            return gameManager.getCards(selectedCards.Count);
        }
        */

        public bool canPlayCards(List<Card> selectedCards)
        {
            return gameManager.canPlayCards(selectedCards);
        }

        public List<Image> rollDice()
        {
            gameManager.dm.rollDice();
            List<Image> images = new List<Image>();
            foreach(Die d in gameManager.dm.dice)
            {
                images.Add(d.image);
            }
            return images;
        }

    }
}
