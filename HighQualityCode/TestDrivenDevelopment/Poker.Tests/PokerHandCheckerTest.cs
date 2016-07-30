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
    }
}
