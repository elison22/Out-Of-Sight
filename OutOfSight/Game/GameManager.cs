using OutOfSight.Piece;
using OutOfSight.Player;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OutOfSight.Game
{
    public enum GameDifficulty {Basic, Advanced};
    public enum GameState {Playing, NotPlaying, Ready, Setup};

    public class GameManager
    {
        private Dictionary<Color, Color> colors = new Dictionary<Color, Color>
        {
            { Color.Yellow, Color.Black },
            { Color.Green, Color.White },
            { Color.MediumVioletRed, Color.Black },
            { Color.DeepPink, Color.Black },
            { Color.Red, Color.White },
            { Color.Teal, Color.White },
            { Color.MidnightBlue, Color.White },
            { Color.DarkOrange, Color.Black },
            { Color.Silver, Color.Black }
        };

        private int cardColorCount = 9;
        private int cardsInPlayCount = 5;
        private int maxCardValue = 12;
        private int totalCards = 108;
        private int roundCount = 3;
        public static GameDifficulty difficulty;
        public static GameState state;

        public DiceManager dm;
        public GameDeck deck;

        public GameManager() {}

        public void newGame(GameDifficulty difficulty)
        {
            GameManager.difficulty = difficulty;
            dm = new DiceManager();
            deck = new GameDeck(colors, maxCardValue);
        }

        public List<Card> getMaxCards()
        {
            return deck.draw(cardsInPlayCount);
        }


        public bool canPlayCards(List<Card> selectedCards)
        {
            List<int> diceVals = dm.getDiceVals();
            bool isValid = canPlayCards(0, selectedCards, diceVals); // jump into recursion on this bad boy!
            return true;
        }

        public bool canPlayCards(int sum, List<Card> remainingCards, List<int> remainingDice)
        {
            //base case aka we can out of cards
            if (remainingCards.Count == 0) return true;
            //base case too many cards
            if (remainingCards.Count > remainingDice.Count) return false;

            //go through the remaining dice, starting with the first each time and removing it
            foreach(int i in remainingDice)
            {
                //go through the cards now and see if this die, plus the sum passed in matches a card
                foreach(Card c in remainingCards)
                {
                    List<int> newRemainingDice = new List<int>(remainingDice);  //deep copy the list of dice to pass on

                    int newSum = sum + i;    //this die plus the previous sum
                    newRemainingDice.Remove(i);
                    // the combined total matches the current card! Remove the card and pass on the remaining dice and cards
                    if (c.value == newSum)      
                    {
                        List<Card> newRemainingCards = new List<Card>(remainingCards);  //deep copy the list just in case
                        newRemainingCards.Remove(c);                                    //remove the card

                        if (canPlayCards(0, newRemainingCards, newRemainingDice))        //zero is the new sum because we're not including previous dice
                            return true;    // we hit the base case of no remaining cards, so we return true!
                    }
                    // the combined total doesn't match the current card... Pass on the new sum and the same cards with the remaining dice
                    else
                    {
                        if (canPlayCards(newSum, remainingCards, newRemainingDice))      
                            return true;    // we hit the base case of no remaining cards, so we return true!
                    }
                }
            }
            //this acts like a base case when there are no dice remaining but there are still cards left
            return false;   // we never found a match on this branch, so return false
        }

    }
}
