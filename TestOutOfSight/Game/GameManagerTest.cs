using System;
using System.Collections.Generic;
using OutOfSight.Game;
using OutOfSight.Piece;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestOutOfSight.Game
{
    [TestClass]
    public class GameManagerTest
    {
        GameManager gm = new GameManager();
        List<Card> cards;
        List<int> dice;

        [TestMethod]
        //should be true
        public void testCanPlayCards_OneToOneMatchOneCard()
        {
            cards = new List<Card> { new Card { value = 4 } };
            dice = new List<int> { 4 };
            Assert.IsTrue(gm.canPlayCards(0, cards, dice));
        }

        [TestMethod]
        //should be false
        public void testCanPlayCards_OneToOneMismatchOneCard()
        {
            cards = new List<Card> { new Card { value = 5 } };
            dice = new List<int> { 4 };
            Assert.IsFalse(gm.canPlayCards(0, cards, dice));
        }

        [TestMethod]
        //should be true
        public void testCanPlayCards_OneToOneMatchMultiCard()
        {
            cards = new List<Card>
            {
                new Card { value = 6 },
                new Card { value = 4 },
                new Card { value = 1 }
            };
            dice = new List<int> { 4, 1, 6 };
            Assert.IsTrue(gm.canPlayCards(0, cards, dice));
        }

        [TestMethod]
        //should be false
        public void testCanPlayCards_OneToOneMismatchMultiCard()
        {
            cards = new List<Card>
            {
                new Card { value = 6 },
                new Card { value = 5 },
                new Card { value = 1 }
            };
            dice = new List<int> { 4, 1, 6 };
            Assert.IsFalse(gm.canPlayCards(0, cards, dice));
        }

        [TestMethod]
        //should be true
        public void testCanPlayCards_OneToOneMatchDoubleCard()
        {
            cards = new List<Card>
            {
                new Card { value = 4 },
                new Card { value = 4 }
            };
            dice = new List<int> { 4, 4 };
            Assert.IsTrue(gm.canPlayCards(0, cards, dice));
        }

        [TestMethod]
        //should be false
        public void testCanPlayCards_MoreToLess()
        {
            cards = new List<Card>
            {
                new Card { value = 4 },
                new Card { value = 6 }
            };
            dice = new List<int> { 4 };
            Assert.IsFalse(gm.canPlayCards(0, cards, dice));
            dice = new List<int> { 6 };
            Assert.IsFalse(gm.canPlayCards(0, cards, dice));

            cards = new List<Card>
            {
                new Card { value = 6 },
                new Card { value = 4 }
            };
            dice = new List<int> { 4 };
            Assert.IsFalse(gm.canPlayCards(0, cards, dice));
            dice = new List<int> { 6 };
            Assert.IsFalse(gm.canPlayCards(0, cards, dice));
        }

        [TestMethod]
        //should be true
        public void testCanPlayCards_LessToMore()
        {
            cards = new List<Card>
            {
                new Card { value = 4 }
            };
            dice = new List<int> { 2, 4 };
            Assert.IsTrue(gm.canPlayCards(0, cards, dice));
        }

        [TestMethod]
        //should be true
        public void testCanPlayCards_LessToMoreDoubleDice()
        {
            cards = new List<Card>
            {
                new Card { value = 4 }
            };
            dice = new List<int> { 4, 4 };
            Assert.IsTrue(gm.canPlayCards(0, cards, dice));
        }

        [TestMethod]
        //should be false
        public void testCanPlayCards_DiceNotReused()
        {
            cards = new List<Card>
            {
                new Card { value = 4 },
                new Card { value = 3 }
            };
            dice = new List<int> { 1, 3 };
            Assert.IsFalse(gm.canPlayCards(0, cards, dice));
            dice = new List<int> { 3, 1 };
            Assert.IsFalse(gm.canPlayCards(0, cards, dice));
        }

        [TestMethod]
        //should be true
        public void testCanPlayCards_BasicAdd()
        {
            cards = new List<Card>
            {
                new Card { value = 8 }
            };
            dice = new List<int> { 3, 5 };
            Assert.IsTrue(gm.canPlayCards(0, cards, dice));
            dice = new List<int> { 4, 4 };
            Assert.IsTrue(gm.canPlayCards(0, cards, dice));
            dice = new List<int> { 2, 5, 1 };
            Assert.IsTrue(gm.canPlayCards(0, cards, dice));
        }

        [TestMethod]
        //should be true
        public void testCanPlayCards_PartialAdd()
        {
            cards = new List<Card>
            {
                new Card { value = 4 },
                new Card { value = 4 }
            };
            dice = new List<int> { 1, 4, 3 };
            Assert.IsTrue(gm.canPlayCards(0, cards, dice));
        }
        
        [TestMethod]
        //should be true
        public void testCanPlayCards_DoubleAdd()
        {
            cards = new List<Card>
            {
                new Card { value = 4 },
                new Card { value = 10 }
            };
            dice = new List<int> { 3, 5, 1, 5 };
            Assert.IsTrue(gm.canPlayCards(0, cards, dice));
        }

    }
}
