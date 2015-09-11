namespace DeckTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;
    using Santase.Logic.Cards;
    using Santase.Logic;

    [TestFixture]
    public class Test
    {
        [Test]
        public void InitializeDeckShouldNotThrowException()
        {
            var testDeck = new Deck();
        }

        [Test]
        public void CheckIfGetReturnsACard()
        {
            var testDeck = new Deck();
            var card = testDeck.GetNextCard();

            Assert.IsInstanceOf(typeof(Card), card, "GetNextCard does not return a card");
        }

        [TestCase(20)]
        [TestCase(12)]
        [TestCase(9)]
        public void CheckIfGetNextCardRemovesItFromTheDeck(int removedCards)
        {
            var testDeck = new Deck();
            for (int i = 0; i < removedCards; i++)
            {
                testDeck.GetNextCard();
            }

            var cardsLeft = 24 - removedCards;

            Assert.AreEqual(cardsLeft, testDeck.CardsLeft, "GetNextCard does not remove a card from the deck");
        }

        [Test]
        public void CheckIfTheDeckIsFullInitialy()
        {
            var testDeck = new Deck();

            Assert.AreEqual(24, testDeck.CardsLeft, "Deck is not full initially");
        }

        [Test]
        public void CheckIfGetNextCardThrowsExceptionWhenDeckIsEmpty()
        {
            var testDeck = new Deck();

            Assert.Throws(typeof(InternalGameException), () =>
            {
                for (int i = 0; i < 25; i++)
                {
                    testDeck.GetNextCard();
                }
            }, "Deck does not throw exception on empty deck");
        }

    }
}