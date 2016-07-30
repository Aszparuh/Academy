namespace Poker
{
    using System;
    using System.Collections.Generic;
    using Poker.Contracts;

    public class Hand : IHand
    {
        private List<Card> cardList;

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public IList<ICard> Cards { get; private set; }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
