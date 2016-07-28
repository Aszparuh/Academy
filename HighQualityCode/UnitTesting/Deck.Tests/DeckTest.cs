namespace Deck.Tests
{
    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;
    using System;

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
    }
}
