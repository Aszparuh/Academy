namespace Poker.Tests
{
    using Contracts;
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class HandsCompareTest
    {
        private static readonly IHand HighCardAce = new Hand(new List<ICard>()
        {
            new Card(CardFace.Ace, CardSuit.Diamonds),
            new Card(CardFace.Five, CardSuit.Diamonds),
            new Card(CardFace.Eight, CardSuit.Hearts),
            new Card(CardFace.Three, CardSuit.Clubs),
            new Card(CardFace.Seven, CardSuit.Spades)
        });

        private static readonly IHand HighCardJack = new Hand(new List<ICard>()
        {
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Five, CardSuit.Diamonds),
            new Card(CardFace.Eight, CardSuit.Hearts),
            new Card(CardFace.Three, CardSuit.Clubs),
            new Card(CardFace.Seven, CardSuit.Spades)
        });

        private static readonly IHand HighCardJackKickerTen = new Hand(new List<ICard>()
        {
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Ten, CardSuit.Diamonds),
            new Card(CardFace.Eight, CardSuit.Hearts),
            new Card(CardFace.Three, CardSuit.Clubs),
            new Card(CardFace.Seven, CardSuit.Spades)
        });

        private static readonly IHand OnePairJacks = new Hand(new List<ICard>()
        {
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Jack, CardSuit.Hearts),
            new Card(CardFace.Eight, CardSuit.Hearts),
            new Card(CardFace.Three, CardSuit.Clubs),
            new Card(CardFace.Seven, CardSuit.Spades)
        });

        private static readonly IHand OnePairQueens= new Hand(new List<ICard>()
        {
            new Card(CardFace.Queen, CardSuit.Diamonds),
            new Card(CardFace.Queen, CardSuit.Hearts),
            new Card(CardFace.Eight, CardSuit.Spades),
            new Card(CardFace.Three, CardSuit.Diamonds),
            new Card(CardFace.Seven, CardSuit.Clubs)
        });

        private static readonly IHand OnePairQueensKickerAce = new Hand(new List<ICard>()
        {
            new Card(CardFace.Queen, CardSuit.Clubs),
            new Card(CardFace.Queen, CardSuit.Spades),
            new Card(CardFace.Ace, CardSuit.Diamonds),
            new Card(CardFace.Three, CardSuit.Clubs),
            new Card(CardFace.Seven, CardSuit.Spades)
        });

        private static readonly IHand TwoPairsQueensAndAcesKickerSeven = new Hand(new List<ICard>()
        {
            new Card(CardFace.Queen, CardSuit.Clubs),
            new Card(CardFace.Queen, CardSuit.Spades),
            new Card(CardFace.Ace, CardSuit.Diamonds),
            new Card(CardFace.Ace, CardSuit.Clubs),
            new Card(CardFace.Seven, CardSuit.Spades)
        });

        private static readonly IHand TwoPairsJacksAndAcesKickerEight = new Hand(new List<ICard>()
        {
            new Card(CardFace.Queen, CardSuit.Clubs),
            new Card(CardFace.Queen, CardSuit.Spades),
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Jack, CardSuit.Clubs),
            new Card(CardFace.Eight, CardSuit.Spades)
        });

        private static readonly IHand TwoPairsJacksAndAcesKickerNine = new Hand(new List<ICard>()
        {
            new Card(CardFace.Queen, CardSuit.Clubs),
            new Card(CardFace.Queen, CardSuit.Spades),
            new Card(CardFace.Jack, CardSuit.Diamonds),
            new Card(CardFace.Jack, CardSuit.Clubs),
            new Card(CardFace.Nine, CardSuit.Spades)
        });

        private static readonly IHand ThreeOfKindQueensKickerJack = new Hand(new List<ICard>()
        {
            new Card(CardFace.Queen, CardSuit.Clubs),
            new Card(CardFace.Queen, CardSuit.Spades),
            new Card(CardFace.Queen, CardSuit.Diamonds),
            new Card(CardFace.Jack, CardSuit.Clubs),
            new Card(CardFace.Nine, CardSuit.Spades)
        });

        private static readonly IHand ThreeOfKindTensKickerAce = new Hand(new List<ICard>()
        {
            new Card(CardFace.Ten, CardSuit.Clubs),
            new Card(CardFace.Ten, CardSuit.Spades),
            new Card(CardFace.Ten, CardSuit.Diamonds),
            new Card(CardFace.Ace, CardSuit.Clubs),
            new Card(CardFace.Nine, CardSuit.Spades)
        });

        private static readonly IHand FourOfKindAces = new Hand(new List<ICard>()
        {
            new Card(CardFace.Ace, CardSuit.Clubs),
            new Card(CardFace.Ace, CardSuit.Spades),
            new Card(CardFace.Ace, CardSuit.Diamonds),
            new Card(CardFace.Ace, CardSuit.Hearts),
            new Card(CardFace.Nine, CardSuit.Spades)
        });

        private static readonly IHand FourOfKindKings = new Hand(new List<ICard>()
        {
            new Card(CardFace.King, CardSuit.Clubs),
            new Card(CardFace.King, CardSuit.Spades),
            new Card(CardFace.King, CardSuit.Diamonds),
            new Card(CardFace.King, CardSuit.Hearts),
            new Card(CardFace.Nine, CardSuit.Spades)
        });

        private static readonly IHand StraightAceToFive = new Hand(new List<ICard>()
        {
            new Card(CardFace.Ace, CardSuit.Spades),
            new Card(CardFace.Two, CardSuit.Spades),
            new Card(CardFace.Three, CardSuit.Diamonds),
            new Card(CardFace.Four, CardSuit.Hearts),
            new Card(CardFace.Five, CardSuit.Spades)
        });

        private static readonly IHand StraightTenToAce = new Hand(new List<ICard>()
        {
            new Card(CardFace.Ace, CardSuit.Clubs),
            new Card(CardFace.King, CardSuit.Spades),
            new Card(CardFace.Queen, CardSuit.Diamonds),
            new Card(CardFace.Jack, CardSuit.Hearts),
            new Card(CardFace.Ten, CardSuit.Spades)
        });

        private static readonly IHand FullHouseTwoKingsThreeAces = new Hand(new List<ICard>()
        {
            new Card(CardFace.King, CardSuit.Clubs),
            new Card(CardFace.King, CardSuit.Spades),
            new Card(CardFace.Ace, CardSuit.Diamonds),
            new Card(CardFace.Ace, CardSuit.Hearts),
            new Card(CardFace.Ace, CardSuit.Spades)
        });

        private static readonly IHand FullHouseTwoQueensThreeAces = new Hand(new List<ICard>()
        {
            new Card(CardFace.Queen, CardSuit.Clubs),
            new Card(CardFace.Queen, CardSuit.Spades),
            new Card(CardFace.Ace, CardSuit.Diamonds),
            new Card(CardFace.Ace, CardSuit.Hearts),
            new Card(CardFace.Ace, CardSuit.Spades)
        });

        private static readonly IHand FlushWithAce = new Hand(new List<ICard>()
        {
            new Card(CardFace.Ace, CardSuit.Clubs),
            new Card(CardFace.Ten, CardSuit.Clubs),
            new Card(CardFace.Seven, CardSuit.Clubs),
            new Card(CardFace.Four, CardSuit.Spades),
            new Card(CardFace.Five, CardSuit.Clubs)
        });

        private static readonly IHand FlushWithoutAce = new Hand(new List<ICard>()
        {
            new Card(CardFace.King, CardSuit.Clubs),
            new Card(CardFace.Ten, CardSuit.Clubs),
            new Card(CardFace.Seven, CardSuit.Clubs),
            new Card(CardFace.Four, CardSuit.Spades),
            new Card(CardFace.Five, CardSuit.Clubs)
        });

        private static readonly IHand StraightFlush = new Hand(new List<ICard>()
        {
            new Card(CardFace.King, CardSuit.Clubs),
            new Card(CardFace.Queen, CardSuit.Clubs),
            new Card(CardFace.Jack, CardSuit.Clubs),
            new Card(CardFace.Ten, CardSuit.Clubs),
            new Card(CardFace.Nine, CardSuit.Clubs)
        });

        private IPokerHandsChecker checker;
         
        [OneTimeSetUp]
        public void InitializeChecker()
        {
            checker = new PokerHandsChecker();
        }

        [Test]
        public void ComparingHighCards_WhenHighCardAceIsFirstSholdReturnOne()
        {
            Assert.AreEqual(1, checker.CompareHands(HighCardAce, HighCardJack));
        }

        [Test]
        public void ComparingHighCards_WhenSameHighCardKivkerShoudBeDecisive()
        {
            Assert.AreEqual(-1, checker.CompareHands(HighCardJack, HighCardJackKickerTen));
        }

        public void ComparingHigherOnePairTo_LowerOnePair()
        {
            Assert.AreEqual(1, checker.CompareHands(OnePairQueens, OnePairJacks));
        }

        [Test]
        public void ComparingOnePairTo_OnePairByKicker()
        {
            Assert.AreEqual(-1, checker.CompareHands(OnePairQueens, OnePairQueensKickerAce));
        }

        [Test]
        public void ComparingTwoPairTo_TwoPair()
        {
            Assert.AreEqual(1, checker.CompareHands(TwoPairsQueensAndAcesKickerSeven, TwoPairsJacksAndAcesKickerNine));
        }

        [Test]
        public void ComparingTwoPairTo_TwoPairByKicker()
        {
            Assert.AreEqual(1, checker.CompareHands(TwoPairsJacksAndAcesKickerNine, TwoPairsJacksAndAcesKickerEight));
        }

        [Test]
        public void ComparingThreeOfKind()
        {
            Assert.AreEqual(1, checker.CompareHands(ThreeOfKindQueensKickerJack, ThreeOfKindTensKickerAce));
        }

        [Test]
        public void ComparingFourOfKindReturnsOne()
        {
            Assert.AreEqual(1, checker.CompareHands(FourOfKindAces, FourOfKindKings));
        }

        [Test]
        public void ComparingFourOfKindReturns_MinusOne()
        {
            Assert.AreEqual(-1, checker.CompareHands(FourOfKindKings, FourOfKindAces));
        }

        [Test]
        public void ComparingStraightToStraight_Should_ReturnOne()
        {
            Assert.AreEqual(1, checker.CompareHands(StraightTenToAce, StraightAceToFive));
        }

        [Test]
        public void ComparingStraightToStraight_ShouldReturn_MinusOne()
        {
            Assert.AreEqual(-1, checker.CompareHands(StraightAceToFive, StraightTenToAce));
        }

        [Test]
        public void ComparingFullHouseToFullHouse_ShouldReturn_MinusOne()
        {
            Assert.AreEqual(-1, checker.CompareHands(FullHouseTwoQueensThreeAces, FullHouseTwoKingsThreeAces));
        }

        [Test]
        public void ComparingFullHouseToFullHouse_ShouldReturn_One()
        {
            Assert.AreEqual(1, checker.CompareHands(FullHouseTwoKingsThreeAces, FullHouseTwoQueensThreeAces));
        }

        [Test]
        public void ComparingFlushToFlush_SholdReturn_One()
        {
            Assert.AreEqual(1, checker.CompareHands(FlushWithAce, FlushWithoutAce));
        }

        [Test]
        public void ComparingFlushToFlush_SholdReturn_MinusOne()
        {
            Assert.AreEqual(-1, checker.CompareHands(FlushWithoutAce, FlushWithAce));
        }

        [Test]
        public void ComapringStraightFlushAndFlush_ShouldReturn_One()
        {
            Assert.AreEqual(1, checker.CompareHands(StraightFlush, FlushWithAce));
        }

        [Test]
        public void TwoPairsVsThreeofKindShouldReturn_MinusOne()
        {
            Assert.AreEqual(-1, checker.CompareHands(TwoPairsJacksAndAcesKickerEight, ThreeOfKindQueensKickerJack));
        }

        [Test]
        public void HighCardVsTwoPairsShouldReturn_MinusOne()
        {
            Assert.AreEqual(-1, checker.CompareHands(HighCardAce, TwoPairsJacksAndAcesKickerEight));
        }
    }
}
