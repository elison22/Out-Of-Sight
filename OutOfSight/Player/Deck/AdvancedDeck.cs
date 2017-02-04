using OutOfSight.Piece;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OutOfSight.Player.Deck
{
    public class AdvancedDeck : IPlayerDeck
    {

        private Dictionary<Color, List<Card>> deck = new Dictionary<Color, List<Card>>();

        public void addCard(Card c)
        {
            if (!deck.ContainsKey(c.backcolor)) deck.Add(c.backcolor, new List<Card>());
            deck[c.backcolor].Add(c);
        }

        public Dictionary<Color, int> getDeckState()
        {
            Dictionary<Color, int> deckState = new Dictionary<Color, int>();
            foreach(Color c in deck.Keys)
            {
                deckState.Add(c, deck[c].Count);
            }
            return deckState;
        }

        public int getRoundScore()
        {
            List<Color> top3Colors = (
                from dr in deck
                orderby dr.Value.Count descending
                select dr.Key).Take(3).ToList();

            int score = 0;
            foreach(Color c in top3Colors)
            {
                score += deck[c].Count;
            }
            return score;
        }

        public int getCardCount()
        {
            int total = 0;
            foreach(List<Card> c in deck.Values)
            {
                total += c.Count;
            }
            return total;
        }

        public bool hasCard(Card c)
        {
            return deck[c.backcolor].Contains(c);
        }

        public List<Card> discardCards()
        {
            List<Color> orderedColors = (
                from dr in deck
                orderby dr.Value.Count descending
                select dr.Key).ToList();

            List<Card> toReturn = new List<Card>();
            for(int i = 0; i < orderedColors.Count; i++)
            {
                if (3 <= i && i <= 5) continue;
                toReturn.AddRange(deck[orderedColors[i]]);
                deck.Remove(orderedColors[i]);
            }

            return toReturn;
        }
    }
}
