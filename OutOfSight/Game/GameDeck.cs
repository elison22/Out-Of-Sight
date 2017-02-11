using OutOfSight.Piece;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OutOfSight.Game
{
    public class GameDeck
    {
        //this is my first commit
        private List<Card> deck;
        public GameDeck(Dictionary<Color, Color> colors, int maxCardVal)
        {
            deck = new List<Card>();
            foreach (Color backColor in colors.Keys)
            {
                for (int i = 1; i <= maxCardVal; i++)
                {
                    deck.Add(new Card(backColor, colors[backColor], i));
                }
            }
        }

        public void addCard(Card c)
        {
            deck.Add(c);
        }

        public void addCards(List<Card> cards)
        {
            deck.AddRange(cards);
        }

        public List<Card> draw(int numToDraw)
        {
            List<Card> toReturn = new List<Card>();
            Random rand = new Random();

            for(int i = 0; i < numToDraw; i++)
            {
                int cardIndex = rand.Next(deck.Count);
                Card toRemove = deck.ElementAt(cardIndex);
                toReturn.Add(toRemove);
                deck.Remove(toRemove);
            }
            return toReturn;
        }

        public void wipeDeck()
        {
            deck.Clear();
        }

        public void shuffle()
        {
            Random rand = new Random();

            for(int i = deck.Count - 1; i > 0; i--)
            {
                int k = rand.Next(i + 1);
                Card c = deck[k];
                deck[k] = deck[i];
                deck[i] = c;
            }
        }

    }
}




