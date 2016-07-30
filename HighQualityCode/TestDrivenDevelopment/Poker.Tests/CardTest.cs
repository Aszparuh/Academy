namespace Poker.Tests
{
    using NUnit.Framework;
    using Poker;

    [TestFixture]
    public class CardTest
    {
        [Test]
        public void CardToStringMethod_ShouldReturnCorrectString()
        {
            var cardName = "King of Clubs";
            var card = new Card(CardFace.King, CardSuit.Clubs);

            Assert.AreEqual(card.ToString(), cardName);
        }
    }
}
