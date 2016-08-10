namespace Poker.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;
    using Poker;
    using Contracts;

    [TestFixture]
    public class HandTest
    {
        [Test]
        public void HandToStringMethod_ShouldReturnCorrectString()
        {
            IList<ICard> cardList = new List<ICard>()
            {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds)
            };

            var hand = new Hand(cardList);
            var expectedResult = "Two of Spades, Three of Spades, Six of Diamonds, Four of Clubs, Five of Clubs";

            Assert.AreEqual(expectedResult, hand.ToString());
        }
    }
}
