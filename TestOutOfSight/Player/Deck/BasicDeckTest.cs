using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace TestOutOfSight.Player.Deck
{
	[TestClass]
	public class BasicDeckTest
	{
        OutOfSight.Player.Deck.IPlayerDeck bd;
        OutOfSight.Piece.Card a;
        OutOfSight.Piece.Card b;
        OutOfSight.Piece.Card c;
        OutOfSight.Piece.Card d;

        [TestInitialize]
        public void setup()
        {
            bd = new OutOfSight.Player.Deck.BasicDeck();
        }

        [TestMethod]
		public void testAddCard()
		{
            a = makeCard(Color.Blue, 6);
            b = makeCard(Color.Blue, 6);
            bd.addCard(a);
            Assert.IsTrue(bd.hasCard(b));
            Assert.AreEqual(1, bd.getCardCount());
            c = makeCard(Color.Yellow, 3);
            d = makeCard(Color.Yellow, 3);
            bd.addCard(c);
            Assert.IsTrue(bd.hasCard(d));
            Assert.IsTrue(bd.hasCard(b));
            Assert.AreEqual(2, bd.getCardCount());
        }

        [TestMethod]
        public void testHasCard()
        {
            a = makeCard(Color.Yellow, 6);
            b = makeCard(Color.Yellow, 6);
            c = makeCard(Color.Yellow, 4);
            d = makeCard(Color.Red, 6);
            bd.addCard(a);
            Assert.IsTrue(bd.hasCard(b));
            Assert.IsFalse(bd.hasCard(c));
            Assert.IsFalse(bd.hasCard(d));
        }

        [TestMethod]
        public void testGetRoundScore()
        {
            a = makeCard(Color.Yellow, 6);
            b = makeCard(Color.Blue, 1);
            c = makeCard(Color.Yellow, 4);
            d = makeCard(Color.Red, 6);
            bd.addCard(a);
            bd.addCard(b);
            bd.addCard(c);
            bd.addCard(d);
            Assert.AreEqual(4, bd.getRoundScore());
        }

        [TestMethod]
        public void testDiscardCards()
        {
            a = makeCard(Color.Yellow, 6);
            b = makeCard(Color.Blue, 1);
            c = makeCard(Color.Yellow, 4);
            d = makeCard(Color.Red, 6);
            bd.addCard(a);
            bd.addCard(b);
            bd.addCard(c);
            bd.addCard(d);
            Assert.AreEqual(4, bd.getCardCount());
            bd.discardCards();
            Assert.AreEqual(0, bd.getCardCount());
        }

        [TestMethod]
        public void testGetDeckState()
        {
            bd.addCard(makeCard(Color.Yellow, 6));
            bd.addCard(makeCard(Color.Blue, 7));
            bd.addCard(makeCard(Color.Yellow, 4));
            bd.addCard(makeCard(Color.Red, 12));
            bd.addCard(makeCard(Color.Red, 3));
            bd.addCard(makeCard(Color.Yellow, 9));
            bd.addCard(makeCard(Color.Black, 1));
            Dictionary<Color, int> deckState = bd.getDeckState();
            foreach(Color c in deckState.Keys)
            {
                if (c == Color.Yellow) Assert.AreEqual(3, deckState[c]);
                else if (c == Color.Red) Assert.AreEqual(2, deckState[c]);
                else if (c == Color.Blue) Assert.AreEqual(1, deckState[c]);
                else if (c == Color.Black) Assert.AreEqual(1, deckState[c]);
                else Assert.IsTrue(false);
            }
        }


        private OutOfSight.Piece.Card makeCard(Color c, int v)
        {
            return new OutOfSight.Piece.Card { backcolor = c, value = v };
        }

    }
}
