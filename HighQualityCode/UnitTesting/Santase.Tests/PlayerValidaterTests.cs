namespace Santase.Tests
{
    using System.Collections.Generic;
    using Logic;
    using Logic.Cards;
    using Logic.Players;
    using Logic.RoundStates;
    using NUnit.Framework;

    [TestFixture]
    public class PlayerValidaterTests
    {
        private PlayerActionValidater validater = new PlayerActionValidater();

        [Test]
        public void PlayingCardThatIsInPlayerDeltCards_ShouldBeValid()
        {
            var cards = new List<Card> { new Card(CardSuit.Heart, CardType.Ten) };
            var state = new FinalRoundState();
            var action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Heart, CardType.Ten), Announce.None);
            var roundContext = new PlayerTurnContext(state, new Card(CardSuit.Heart, CardType.Ten), 0);

            Assert.IsTrue(this.validater.IsValid(action, roundContext, cards));
        }

        [Test]
        public void PalyingCardThatIsInNotInPlayerDeltCards_ShouldNotBeValid()
        {
            var cards = new List<Card> { new Card(CardSuit.Heart, CardType.Ten) };
            var state = new FinalRoundState();
            var action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Diamond, CardType.Ten), Announce.None);
            var roundContext = new PlayerTurnContext(state, new Card(CardSuit.Diamond, CardType.Ten), 0);

            Assert.IsFalse(this.validater.IsValid(action, roundContext, cards));
        }

        [Test]
        public void AnnouncingTwenty_ShouldBeValid()
        {
            var cards = new List<Card>
            {
                new Card(CardSuit.Spade, CardType.Queen),
                new Card(CardSuit.Spade, CardType.King),
                new Card(CardSuit.Diamond, CardType.Ace)
            };

            var round = new GameRound(new Player(), new Player(), PlayerPosition.FirstPlayer);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            var context = new PlayerTurnContext(state, new Card(CardSuit.Spade, CardType.Ten), 6);
            var action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Spade, CardType.Queen), Announce.Twenty);
            this.validater.IsValid(action, context, cards);

            Assert.AreEqual(Announce.Twenty, action.Announce);
        }

        [Test]
        public void AnnouncingTwenty_ShouldBeNotValid_WhenPlayerDoesNotHaveTheKing()
        {
            var cards = new List<Card>()
            {
                new Card(CardSuit.Spade, CardType.Queen),
                new Card(CardSuit.Spade, CardType.Jack)
            };

            var round = new GameRound(new Player(), new Player(), PlayerPosition.FirstPlayer);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            var context = new PlayerTurnContext(state, new Card(CardSuit.Spade, CardType.Ten), 6);
            var action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Spade, CardType.Queen), Announce.Twenty);
            this.validater.IsValid(action, context, cards);

            Assert.AreNotEqual(Announce.Twenty, action.Announce);
        }

        [Test]
        public void AnnouncingTwenty_ShouldBeNotValid_WhenPlayerDoesNotHaveTheQueen()
        {
            var cards = new List<Card>()
            {
                new Card(CardSuit.Spade, CardType.King),
                new Card(CardSuit.Spade, CardType.Jack)
            };

            var round = new GameRound(new Player(), new Player(), PlayerPosition.FirstPlayer);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            var context = new PlayerTurnContext(state, new Card(CardSuit.Spade, CardType.Ten), 6);
            var action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Spade, CardType.King), Announce.Twenty);
            this.validater.IsValid(action, context, cards);

            Assert.AreNotEqual(Announce.Twenty, action.Announce);
        }

        [Test]
        public void AnnouncingTwenty_ShouldBeNotValid_WhenPlayerDoesPlaysCardOtherThanQuuenOrKing()
        {
            var cards = new List<Card>()
            {
                new Card(CardSuit.Spade, CardType.Queen),
                new Card(CardSuit.Spade, CardType.Jack)
            };

            var round = new GameRound(new Player(), new Player(), PlayerPosition.FirstPlayer);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            var context = new PlayerTurnContext(state, new Card(CardSuit.Spade, CardType.Ten), 6);
            var action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Spade, CardType.Jack), Announce.Twenty);
            this.validater.IsValid(action, context, cards);

            Assert.AreNotEqual(Announce.Twenty, action.Announce);
        }

        [Test]
        public void AnnouncingWhenPlayerIsNotFirst_ShouldChangeAnnounceToNone()
        {
            var cards = new List<Card>()
            {
                new Card(CardSuit.Club, CardType.Queen),
                new Card(CardSuit.Club, CardType.King),
                new Card(CardSuit.Heart, CardType.Jack)
            };
            var announce = Announce.Fourty;
            var action = new PlayerAction(PlayerActionType.PlayCard, new Card(CardSuit.Club, CardType.Queen), announce);
            var round = new GameRound(new Player(), new Player(), PlayerPosition.SecondPlayer);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            var context = new PlayerTurnContext(state, new Card(CardSuit.Club, CardType.Jack), 0);
            this.validater.IsValid(action, context, cards);

            Assert.AreEqual(Announce.None, action.Announce);
        }

        [Test]
        public void PlayerChangesTrumpWithNine_ShouldBeValid()
        {
            var cards = new List<Card>() { new Card(CardSuit.Club, CardType.Nine) };
            var action = new PlayerAction(PlayerActionType.ChangeTrump, new Card(CardSuit.Club, CardType.Nine), Announce.None);
            var round = new GameRound(new Player(), new Player(), PlayerPosition.FirstPlayer);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            var context = new PlayerTurnContext(state, new Card(CardSuit.Club, CardType.Jack), 0);

            Assert.IsTrue(validater.IsValid(action, context, cards));
        }

        public void PlayerChangesTrumpWithTen_ShouldBeInvalid()
        {
            var cards = new List<Card>() { new Card(CardSuit.Club, CardType.Queen) };
            var action = new PlayerAction(PlayerActionType.ChangeTrump, new Card(CardSuit.Club, CardType.Ten), Announce.None);
            var round = new GameRound(new Player(), new Player(), PlayerPosition.FirstPlayer);
            var state = new MoreThanTwoCardsLeftRoundState(round);
            var context = new PlayerTurnContext(state, new Card(CardSuit.Club, CardType.Jack), 0);

            Assert.IsFalse(validater.IsValid(action, context, cards));
        }
    }
}
