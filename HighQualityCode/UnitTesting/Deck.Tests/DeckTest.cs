namespace Deck.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Extensions;
    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;

    [TestFixture]
    public class DeckTest
    {
        private const int DeckSize = 24;

        [Test]
        public void DrawNextCardOnEmptyDeck_ShouldThrowException()
        {
            var deck = new Deck();

            for (int card = 0; card < DeckSize; card++)
            {
                deck.GetNextCard();
            }

            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }

        [Test]
        public void DeckTrumpCard_ShouldNotBeNull()
        {
            var deck = new Deck();

            Assert.IsNotNull(deck.GetTrumpCard);
        }

        [Test]
        public void ExpectTheTrumpCardToBeTakenLast()
        {
            var deck = new Deck();
            var trumpCard = deck.GetTrumpCard;
            Card lastCard = deck.GetNextCard();

            while (deck.CardsLeft > 0)
            {
                lastCard = deck.GetNextCard();
            }

            Assert.AreSame(trumpCard, lastCard);
        }

        [Test]
        public void ExpectTheTrumpCardToBeChanged()
        {
            var deck = new Deck();
            var initialTrumpCard = deck.GetTrumpCard;
            var newTrumpCard = deck.GetNextCard();

            deck.ChangeTrumpCard(newTrumpCard);

            Assert.AreSame(newTrumpCard, deck.GetTrumpCard);
        }

        [Test]
        public void TwoEqualCardsAreConsideredTheSame()
        {
            var first = new Card(CardSuit.Club, CardType.Ace);
            var second = new Card(CardSuit.Club, CardType.Ace);

            Assert.AreEqual(first, second);
        }

        [TestCase(4)]
        [TestCase(8)]
        [TestCase(15)]
        [TestCase(17)]
        [TestCase(24)]
        public void ExpectedDeckToReturnNDifferentCards(int count)
        {
            var deck = new Deck();
            var cards = new List<Card>();

            for (int card = 0; card < count; card++)
            {
                cards.Add(deck.GetNextCard());
            }

            var distinc = cards.DistinctBy(c => new { c.Suit, c.Type } );

            Assert.AreEqual(count, distinc.Count());
        }

    }
}
