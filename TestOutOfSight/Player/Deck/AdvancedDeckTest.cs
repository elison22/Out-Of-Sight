using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace TestOutOfSight.Player.Deck
{
    [TestClass]
    public class AdvancedDeckTest
    {
        OutOfSight.Player.Deck.IPlayerDeck ad;
        OutOfSight.Piece.Card a;
        OutOfSight.Piece.Card b;
        OutOfSight.Piece.Card c;
        OutOfSight.Piece.Card d;

        [TestInitialize]
        public void setup()
        {
            ad = new OutOfSight.Player.Deck.AdvancedDeck();
        }

        [TestMethod]
        public void testAddCard()
        {
            a = makeCard(Color.Blue, 6);
            b = makeCard(Color.Blue, 6);
            ad.addCard(a);
            Assert.IsTrue(ad.hasCard(b));
            Assert.AreEqual(1, ad.getCardCount());
            c = makeCard(Color.Yellow, 3);
            d = makeCard(Color.Yellow, 3);
            ad.addCard(c);
            Assert.IsTrue(ad.hasCard(d));
            Assert.IsTrue(ad.hasCard(b));
            Assert.AreEqual(2, ad.getCardCount());
        }

        [TestMethod]
        public void testHasCard()
        {
            a = makeCard(Color.Yellow, 6);
            b = makeCard(Color.Yellow, 6);
            c = makeCard(Color.Yellow, 4);
            d = makeCard(Color.Red, 6);
            ad.addCard(a);
            Assert.IsTrue(ad.hasCard(b));
            Assert.IsFalse(ad.hasCard(c));
            Assert.IsFalse(ad.hasCard(d));
        }

        [TestMethod]
        public void testGetRoundScore()
        {
            
        }

        private OutOfSight.Piece.Card makeCard(Color c, int v)
        {
            return new OutOfSight.Piece.Card { backcolor = c, value = v };
        }



        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
    }
}
