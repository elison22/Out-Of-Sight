using System;
using OutOfSight.Piece;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OutOfSight.Player.Deck
{
    public class BasicDeck : IPlayerDeck
    {

        List<Card> deck = new List<Card>();

        public void addCard(Card c)
        {
            deck.Add(c);
        }

        public Dictionary<Color, int> getDeckState()
        {
            Dictionary<Color, int> deckState = new Dictionary<Color, int>();
            foreach (Card c in deck)
            {
                if (!deckState.ContainsKey(c.backcolor)) deckState.Add(c.backcolor, 0);
                deckState[c.backcolor]++;
            }
            return deckState;
        }

        public int getRoundScore()
        {
            return deck.Count;
        }

        public int getCardCount()
        {
            return deck.Count;
        }

        public bool hasCard(Card c)
        {
            return deck.Contains(c);
        }

        public List<Card> discardCards()
        {
            List<Card> toReturn = new List<Card>(deck);
            deck.Clear();
            return toReturn;
        }

    }
}
