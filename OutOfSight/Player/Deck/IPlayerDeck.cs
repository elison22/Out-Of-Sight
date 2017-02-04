using OutOfSight.Piece;
using System.Collections.Generic;
using System.Drawing;

namespace OutOfSight.Player.Deck
{
    public interface IPlayerDeck
    {
        void addCard(Card c);
        bool hasCard(Card c);
        int getRoundScore();
        int getCardCount();
        List<Card> discardCards();
        Dictionary<Color, int> getDeckState();
    }
}