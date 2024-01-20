using Common.Cards.GameEngines;
using Common.Cards.GameEngines.Utility;
using Common.Cards.Main;

namespace Testing
{
    public class ClassicPokerTests
    {
        private ClassicPokerGameEngine GameEngine;

        [SetUp]
        public void Setup()
        {
            this.GameEngine = new ClassicPokerGameEngine();
        }

        [Test]
        public void TestOnePair()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();

            handCards1.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Four, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Ace, CardTypes.Hearts));
            handCards1.Add(new Card(CardValues.Two, CardTypes.Spades));

            handCards2.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Four, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Ace, CardTypes.Hearts));
            handCards2.Add(new Card(CardValues.King, CardTypes.Spades));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);

            var handValue1 = (ClassicPokerHandValue)this.GameEngine.HasOnePair(hand1);
            var handValue2 = (ClassicPokerHandValue)this.GameEngine.HasOnePair(hand2);

            Assert.That(handValue1.MainValue, Is.EqualTo(1));
            Assert.That(handValue2._IsFound, Is.EqualTo(false));
        }

        [Test]
        public void TestTwoPair()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();

            handCards1.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Ace, CardTypes.Hearts));
            handCards1.Add(new Card(CardValues.Two, CardTypes.Spades));

            handCards2.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Ace, CardTypes.Hearts));
            handCards2.Add(new Card(CardValues.King, CardTypes.Spades));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);

            var handValue1 = (ClassicPokerHandValue)this.GameEngine.HasTwoPair(hand1);
            var handValue2 = (ClassicPokerHandValue)this.GameEngine.HasTwoPair(hand2);

            Assert.That(handValue1.MainValue, Is.EqualTo(2));
            Assert.That(handValue2._IsFound, Is.EqualTo(false));
        }

        [Test]
        public void TestThreeOfAKind()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();

            handCards1.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Four, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Two, CardTypes.Hearts));
            handCards1.Add(new Card(CardValues.Two, CardTypes.Spades));

            handCards2.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Four, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Ace, CardTypes.Hearts));
            handCards2.Add(new Card(CardValues.King, CardTypes.Spades));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);

            var handValue1 = (ClassicPokerHandValue)this.GameEngine.HasThreeOfAKind(hand1);
            var handValue2 = (ClassicPokerHandValue)this.GameEngine.HasThreeOfAKind(hand2);

            Assert.That(handValue1.MainValue, Is.EqualTo(3));
            Assert.That(handValue2._IsFound, Is.EqualTo(false));
        }

        [Test]
        public void TestStraight()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();

            handCards1.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Six, CardTypes.Spades));
            handCards1.Add(new Card(CardValues.Five, CardTypes.Hearts));
            handCards1.Add(new Card(CardValues.Four, CardTypes.Diamonds));

            handCards2.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Four, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Ace, CardTypes.Hearts));
            handCards2.Add(new Card(CardValues.King, CardTypes.Spades));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);

            var handValue1 = (ClassicPokerHandValue)this.GameEngine.HasStraight(hand1);
            var handValue2 = (ClassicPokerHandValue)this.GameEngine.HasStraight(hand2);

            Assert.That(handValue1.MainValue, Is.EqualTo(4));
            Assert.That(handValue2._IsFound, Is.EqualTo(false));
        }

        [Test]
        public void TestFlush()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();

            handCards1.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Six, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Ace, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.King, CardTypes.Diamonds));

            handCards2.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Ace, CardTypes.Hearts));
            handCards2.Add(new Card(CardValues.King, CardTypes.Spades));
            handCards2.Add(new Card(CardValues.Four, CardTypes.Diamonds));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);

            var handValue1 = (ClassicPokerHandValue)this.GameEngine.HasFlush(hand1);
            var handValue2 = (ClassicPokerHandValue)this.GameEngine.HasFlush(hand2);

            Assert.That(handValue1.MainValue, Is.EqualTo(5));
            Assert.That(handValue2._IsFound, Is.EqualTo(false));
        }

        [Test]
        public void TestFullHouse()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();

            handCards1.Add(new Card(CardValues.King, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Two, CardTypes.Hearts));
            handCards1.Add(new Card(CardValues.King, CardTypes.Spades));
            handCards1.Add(new Card(CardValues.Two, CardTypes.Clubs));
            handCards1.Add(new Card(CardValues.King, CardTypes.Diamonds));

            handCards2.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.King, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.King, CardTypes.Hearts));
            handCards2.Add(new Card(CardValues.King, CardTypes.Spades));
            handCards2.Add(new Card(CardValues.Four, CardTypes.Diamonds));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);

            var handValue1 = (ClassicPokerHandValue)this.GameEngine.HasFullHouse(hand1);
            var handValue2 = (ClassicPokerHandValue)this.GameEngine.HasFullHouse(hand2);

            Assert.That(handValue1.MainValue, Is.EqualTo(6));
            Assert.That(handValue2._IsFound, Is.EqualTo(false));
        }

        [Test]
        public void TestFourOfAKind()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();

            handCards1.Add(new Card(CardValues.King, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.King, CardTypes.Hearts));
            handCards1.Add(new Card(CardValues.King, CardTypes.Spades));
            handCards1.Add(new Card(CardValues.Two, CardTypes.Clubs));
            handCards1.Add(new Card(CardValues.King, CardTypes.Clubs));

            handCards2.Add(new Card(CardValues.King, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.King, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.King, CardTypes.Hearts));
            handCards2.Add(new Card(CardValues.Two, CardTypes.Spades));
            handCards2.Add(new Card(CardValues.Four, CardTypes.Diamonds));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);

            var handValue1 = (ClassicPokerHandValue)this.GameEngine.HasFourOfAKind(hand1);
            var handValue2 = (ClassicPokerHandValue)this.GameEngine.HasFourOfAKind(hand2);

            Assert.That(handValue1.MainValue, Is.EqualTo(7));
            Assert.That(handValue2._IsFound, Is.EqualTo(false));
        }

        [Test]
        public void TestStraightFlush()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();
            List<Card> handCards3 = new List<Card>();

            handCards1.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Six, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Five, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Four, CardTypes.Diamonds));

            handCards2.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Six, CardTypes.Clubs));
            handCards2.Add(new Card(CardValues.Five, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Four, CardTypes.Diamonds)); ;

            handCards3.Add(new Card(CardValues.King, CardTypes.Diamonds));
            handCards3.Add(new Card(CardValues.King, CardTypes.Diamonds));
            handCards3.Add(new Card(CardValues.King, CardTypes.Hearts));
            handCards3.Add(new Card(CardValues.Two, CardTypes.Spades));
            handCards3.Add(new Card(CardValues.Four, CardTypes.Diamonds));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);
            Hand hand3 = new Hand(handCards3);

            var handValue1 = (ClassicPokerHandValue)this.GameEngine.HasStraightFlush(hand1);
            var handValue2 = (ClassicPokerHandValue)this.GameEngine.HasStraightFlush(hand2);
            var handValue3 = (ClassicPokerHandValue)this.GameEngine.HasStraightFlush(hand3);

            Assert.That(handValue1.MainValue, Is.EqualTo(8));
            Assert.That(handValue2._IsFound, Is.EqualTo(false));
            Assert.That(handValue3._IsFound, Is.EqualTo(false));
        }

        [Test]
        public void TestRoyalStraightFlush()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();
            List<Card> handCards3 = new List<Card>();
            List<Card> handCards4 = new List<Card>();

            handCards1.Add(new Card(CardValues.Jack, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Ten, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Ace, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.King, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Queen, CardTypes.Diamonds));

            handCards2.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Six, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Five, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Four, CardTypes.Diamonds));

            handCards3.Add(new Card(CardValues.One, CardTypes.Diamonds));
            handCards3.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards3.Add(new Card(CardValues.Three, CardTypes.Clubs));
            handCards3.Add(new Card(CardValues.Four, CardTypes.Diamonds));
            handCards3.Add(new Card(CardValues.Five, CardTypes.Diamonds)); ;

            handCards4.Add(new Card(CardValues.King, CardTypes.Diamonds));
            handCards4.Add(new Card(CardValues.King, CardTypes.Diamonds));
            handCards4.Add(new Card(CardValues.King, CardTypes.Hearts));
            handCards4.Add(new Card(CardValues.Two, CardTypes.Spades));
            handCards4.Add(new Card(CardValues.Four, CardTypes.Diamonds));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);
            Hand hand3 = new Hand(handCards3);
            Hand hand4 = new Hand(handCards4);

            var handValue1 = (ClassicPokerHandValue)this.GameEngine.HasRoyalStraightFlush(hand1);
            var handValue2 = (ClassicPokerHandValue)this.GameEngine.HasRoyalStraightFlush(hand2);
            var handValue3 = (ClassicPokerHandValue)this.GameEngine.HasRoyalStraightFlush(hand3);
            var handValue4 = (ClassicPokerHandValue)this.GameEngine.HasRoyalStraightFlush(hand4);

            Assert.That(handValue1.MainValue, Is.EqualTo(9));
            Assert.That(handValue2._IsFound, Is.EqualTo(false));
            Assert.That(handValue3._IsFound, Is.EqualTo(false));
            Assert.That(handValue4._IsFound, Is.EqualTo(false));
        }

        [Test]
        public void TestGameOne()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();

            handCards1.Add(new Card(CardValues.Five, CardTypes.Hearts));
            handCards1.Add(new Card(CardValues.Five, CardTypes.Clubs));
            handCards1.Add(new Card(CardValues.Six, CardTypes.Spades));
            handCards1.Add(new Card(CardValues.Seven, CardTypes.Spades));
            handCards1.Add(new Card(CardValues.King, CardTypes.Diamonds));

            handCards2.Add(new Card(CardValues.Two, CardTypes.Clubs));
            handCards2.Add(new Card(CardValues.Three, CardTypes.Spades));
            handCards2.Add(new Card(CardValues.Eight, CardTypes.Spades));
            handCards2.Add(new Card(CardValues.Eight, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Ten, CardTypes.Diamonds));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);

            var handsList = new List<Hand>();
            handsList.Add(hand1);
            handsList.Add(hand2);

            Assert.That(this.GameEngine.WhoWins(handsList, null), Is.EqualTo(1));
        }

        [Test]
        public void TestGameTwo()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();

            handCards1.Add(new Card(CardValues.Five, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Eight, CardTypes.Clubs));
            handCards1.Add(new Card(CardValues.Nine, CardTypes.Spades));
            handCards1.Add(new Card(CardValues.Jack, CardTypes.Spades));
            handCards1.Add(new Card(CardValues.Ace, CardTypes.Clubs));

            handCards2.Add(new Card(CardValues.Two, CardTypes.Clubs));
            handCards2.Add(new Card(CardValues.Five, CardTypes.Clubs));
            handCards2.Add(new Card(CardValues.Seven, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Eight, CardTypes.Spades));
            handCards2.Add(new Card(CardValues.Queen, CardTypes.Hearts));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);

            var handsList = new List<Hand>();
            handsList.Add(hand1);
            handsList.Add(hand2);

            Assert.That(this.GameEngine.WhoWins(handsList, null), Is.EqualTo(0));
        }

        [Test]
        public void TestGameThree()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();

            handCards1.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Nine, CardTypes.Clubs));
            handCards1.Add(new Card(CardValues.Ace, CardTypes.Spades));
            handCards1.Add(new Card(CardValues.Ace, CardTypes.Hearts));
            handCards1.Add(new Card(CardValues.Ace, CardTypes.Clubs));

            handCards2.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Six, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Seven, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Ten, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Queen, CardTypes.Diamonds));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);

            var handsList = new List<Hand>();
            handsList.Add(hand1);
            handsList.Add(hand2);

            Assert.That(this.GameEngine.WhoWins(handsList, null), Is.EqualTo(1));
        }

        [Test]
        public void TestGameFour()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();

            handCards1.Add(new Card(CardValues.Four, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Six, CardTypes.Spades));
            handCards1.Add(new Card(CardValues.Nine, CardTypes.Hearts));
            handCards1.Add(new Card(CardValues.Queen, CardTypes.Hearts));
            handCards1.Add(new Card(CardValues.Queen, CardTypes.Clubs));

            handCards2.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Six, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Seven, CardTypes.Hearts));
            handCards2.Add(new Card(CardValues.Queen, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Queen, CardTypes.Spades));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);

            var handsList = new List<Hand>();
            handsList.Add(hand1);
            handsList.Add(hand2);

            Assert.That(this.GameEngine.WhoWins(handsList, null), Is.EqualTo(0));
        }

        [Test]
        public void TestGameFive()
        {
            List<Card> handCards1 = new List<Card>();
            List<Card> handCards2 = new List<Card>();

            handCards1.Add(new Card(CardValues.Two, CardTypes.Hearts));
            handCards1.Add(new Card(CardValues.Two, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Four, CardTypes.Clubs));
            handCards1.Add(new Card(CardValues.Four, CardTypes.Diamonds));
            handCards1.Add(new Card(CardValues.Four, CardTypes.Spades));

            handCards2.Add(new Card(CardValues.Three, CardTypes.Clubs));
            handCards2.Add(new Card(CardValues.Three, CardTypes.Diamonds));
            handCards2.Add(new Card(CardValues.Three, CardTypes.Spades));
            handCards2.Add(new Card(CardValues.Nine, CardTypes.Spades));
            handCards2.Add(new Card(CardValues.Nine, CardTypes.Diamonds));

            Hand hand1 = new Hand(handCards1);
            Hand hand2 = new Hand(handCards2);

            var handsList = new List<Hand>();
            handsList.Add(hand1);
            handsList.Add(hand2);

            Assert.That(this.GameEngine.WhoWins(handsList, null), Is.EqualTo(0));
        }
    }
}
