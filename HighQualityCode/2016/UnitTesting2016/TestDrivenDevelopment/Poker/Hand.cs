namespace Poker
{
    using System.Collections.Generic;
    using System.Linq;
    using Poker.Contracts;

    public class Hand : IHand
    {
        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public IList<ICard> Cards { get; private set; }

        public override string ToString()
        {
            var cards = this.SortCards();
            return string.Join(", ", cards);
        }

        private IList<ICard> SortCards()
        {
            return this.Cards.OrderByDescending(c => c.Suit).ThenBy(c => c.Face).ToList();
        }
    }
}
