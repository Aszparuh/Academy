namespace Poker
{
    using System;
    using System.Linq;
    using Extensions;
    using Poker.Contracts;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const int ValidHandCardsCount = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                throw new ArgumentNullException();
            }

            if (hand.Cards.Count != ValidHandCardsCount)
            {
                return false;
            }

            if (hand.Cards.DistinctBy(c => new { c.Suit, c.Face }).Count() != ValidHandCardsCount)
            {
                return false;
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            var isStraight = true;

            var sorted = hand.Cards.Select(value => (int)value.Face).OrderBy(value => value).ToArray();

            if (sorted.Contains((int)CardFace.Ace) && sorted.Contains((int)CardFace.Two))
            {
                var index = Array.IndexOf(sorted, (int)CardFace.Ace);
                sorted[index] = 1;
                sorted = sorted.OrderBy(value => value).ToArray();
            }

            for (int ind = 0; ind < sorted.Length - 1; ind++)
            {
                if (sorted[ind] + 1 != sorted[ind + 1])
                {
                    isStraight = false;
                    break;
                }
            }

            bool isFlush = hand.Cards.GroupBy(card => card.Suit).Count() == 1;

            return isStraight && isFlush;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var group = hand.Cards.GroupBy(card => card.Face);
            return group.Any(gr => gr.Count() == 4);
        }

        public bool IsFullHouse(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var group = hand.Cards.GroupBy(card => card.Face);
            return group.Any(gr => gr.Count() == 3) && group.Any(gr => gr.Count() == 2);
        }

        public bool IsFlush(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }
            else
            {
                return (hand.Cards.GroupBy(c => c.Suit).Count() == 1) && !this.IsStraightFlush(hand);
            }
        }

        public bool IsStraight(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            if (hand.Cards.GroupBy(card => card.Suit).Count() == 1)
            {
                return false;
            }

            var sortedHand = hand.Cards.Select(value => (int)value.Face).OrderBy(value => value).ToArray();

            if (sortedHand.Contains((int)CardFace.Ace) && sortedHand.Contains((int)CardFace.Two))
            {
                var index = Array.IndexOf(sortedHand, (int)CardFace.Ace);
                sortedHand[index] = 1;
                sortedHand = sortedHand.OrderBy(value => value).ToArray();
            }

            for (int ind = 0; ind < sortedHand.Length - 1; ind++)
            {
                if (sortedHand[ind] + 1 != sortedHand[ind + 1])
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var group = hand.Cards.GroupBy(card => card.Face);
            return group.Any(gr => gr.Count() == 3) && !group.Any(gr => gr.Count() == 2);
        }

        public bool IsTwoPair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            return hand.Cards.GroupBy(card => card.Face).Count(group => group.Count() == 2) == 2;
        }

        public bool IsOnePair(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var group = hand.Cards.GroupBy(card => card.Face);
            return group.Count(gr => gr.Count() == 2) == 1 && !group.Any(gr => gr.Count() == 3);
        }

        public bool IsHighCard(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                return false;
            }

            var group = hand.Cards.GroupBy(card => card.Face);
            return !this.IsFlush(hand) && group.Count() == ValidHandCardsCount;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
