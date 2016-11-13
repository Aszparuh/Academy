namespace Poker.Tests
{
    using Contracts;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class PokerHandCheckerTest
    {
        [Test]
        public void FiveDiffernetCards_ShouldBeValidHand()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(true, checker.IsValidHand(hand));
        }

        [Test]
        public void NullHandThrowsException()
        {
            var checker = new PokerHandsChecker();
            Hand hand = null;

            Assert.Throws<ArgumentNullException>(() => checker.IsValidHand(hand));
        }

        [Test]
        public void HandWithLessThanFiveCardsIsNotValid()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(false, checker.IsValidHand(hand));
        }

        [Test]
        public void HandWithTwoSameCardsIsNotValid()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Hearts)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(false, checker.IsValidHand(hand));
        }

        [Test]
        public void IsFlushShouldReturnTrue_IfTheHandIsAFlush()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(true, checker.IsFlush(hand));
        }

        [Test]
        public void IsFlushShouldReturnFalse_IfTheHandIsNotAFlush()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(false, checker.IsFlush(hand));
        }

        [Test]
        public void WhenHandIsStraightFlush_IsFlushShouldReturnFalse()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(false, checker.IsFlush(hand));
        }

        [Test]
        public void IsStraightShouldReturnTrue_WhenStraight()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(true, checker.IsStraight(hand));
        }

        [Test]
        public void IsStraightFlush_ShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(true, checker.IsStraightFlush(hand));
        }

        [Test]
        public void IsFourOfAKind_ShouldReturnFalse()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(false, checker.IsFourOfAKind(hand));
        }

        [Test]
        public void IsFourOfAKind_ShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(true, checker.IsFourOfAKind(hand));
        }

        [Test]
        public void IsFullHouse_ShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(true, checker.IsFullHouse(hand));
        }

        [Test]
        public void IsFullHouse_ShouldReturnFalse()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(false, checker.IsFullHouse(hand));
        }

        [Test]
        public void ThreeOfAKind_ShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(true, checker.IsThreeOfAKind(hand));
        }

        [Test]
        public void ThreeOfAKind_ShouldReturnFalse()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(false, checker.IsThreeOfAKind(hand));
        }

        [Test]
        public void IsTwoPair_ShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(true, checker.IsTwoPair(hand));
        }

        [Test]
        public void IsTwoPair_ShouldReturnFalse()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(false, checker.IsTwoPair(hand));
        }

        [Test]
        public void IsOnePair_ShouldReturnFalseWhenTwoPairs()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(false, checker.IsOnePair(hand));
        }

        public void IsOnePair_ShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(true, checker.IsOnePair(hand));
        }

        [Test]
        public void IsHighCardShouldReturnFalse_WhenOnePairs()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(false, checker.IsHighCard(hand));
        }

        [Test]
        public void IsHighCardShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(true, checker.IsHighCard(hand));
        }

        [Test]
        public void IsHighCardShouldReturnFalse_WhenFlush()
        {
            var checker = new PokerHandsChecker();
            var cardList = new List<ICard>()
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs)
            };
            var hand = new Hand(cardList);

            Assert.AreEqual(false, checker.IsHighCard(hand));
        }
    }
}
