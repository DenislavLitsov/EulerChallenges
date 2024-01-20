using Common.Cards.GameEngines.Utility;
using Common.Cards.Main;
using System.Linq;
using System.Net.Http.Headers;

namespace Common.Cards.GameEngines
{
    public class ClassicPokerGameEngine : CardGameEngine
    {
        public ClassicPokerGameEngine()
        {
            this.CreateCardDeck();
        }

        public override void CreateCardDeck()
        {
            ICollection<CardValues> possibleValues = new List<CardValues>();
            ICollection<CardTypes> possibleTypes = new List<CardTypes>();
            for (int i = 1; i <= (int)CardValues.Ace; i++)
            {
                possibleValues.Add((CardValues)i);
            }
            for (int i = 0; i <= 3; i++)
            {
                possibleTypes.Add((CardTypes)i);
            }

            ICollection<Card> deck = new List<Card>();
            foreach (var cardValue in possibleValues)
            {
                foreach (var cardType in possibleTypes)
                {
                    Card newCard = new Card(cardValue, cardType);
                    deck.Add(newCard);
                }
            }

            CardDeck newDeck = new CardDeck(deck);
            this.CardDeck = newDeck;
        }

        public override int WhoWins(IEnumerable<Hand> hands, TableHand tableHand)
        {
            IHandValue handValue1 = this.GetHandValue(hands.First());
            IHandValue handValue2 = this.GetHandValue(hands.Last());

            int whoWins = handValue1.WhoWins(handValue2);

            if (whoWins == 1)
            {
                return 0;
            }
            else if (whoWins == 2)
            {
                return 1;
            }
            else
            {
                CardValues highCard1 = CardValues.One;
                CardValues highCard2 = CardValues.One;
                List<CardValues> valuesToSkip = new List<CardValues>();
                while (highCard1 == highCard2)
                {
                    if (valuesToSkip.Count == hands.First().Cards.Count())
                    {
                        throw new NotImplementedException("NOT SUPPORTED EQUAL RESULT. EG: Both have same value/pairs and same high cards.");
                    }

                    highCard1 = this.GetHighCardValueExcept(hands.First().Cards, valuesToSkip);
                    highCard2 = this.GetHighCardValueExcept(hands.Last().Cards, valuesToSkip);

                    if (highCard1 != highCard2)
                        break;

                    valuesToSkip.Add(highCard1);
                }

                if (highCard1 > highCard2)
                {
                    return 0;
                }
                else if (highCard1 < highCard2)
                {
                    return 1;
                }
            }

            // Impossible to get to here
            throw new NotImplementedException();
        }

        private IHandValue GetHandValue(Hand hand)
        {
            if (this.HasRoyalStraightFlush(hand).IsFound())
            {
                return this.HasRoyalStraightFlush(hand);
            }
            else if (this.HasStraightFlush(hand).IsFound())
            {
                return this.HasStraightFlush(hand);
            }
            else if (this.HasFourOfAKind(hand).IsFound())
            {
                return this.HasFourOfAKind(hand);
            }
            else if (this.HasFullHouse(hand).IsFound())
            {
                return this.HasFullHouse(hand);
            }
            else if (this.HasFlush(hand).IsFound())
            {
                return this.HasFlush(hand);
            }
            else if (this.HasStraight(hand).IsFound())
            {
                return this.HasStraight(hand);
            }
            else if (this.HasThreeOfAKind(hand).IsFound())
            {
                return this.HasThreeOfAKind(hand);
            }
            else if (this.HasTwoPair(hand).IsFound())
            {
                return this.HasTwoPair(hand);
            }
            else if (this.HasOnePair(hand).IsFound())
            {
                return this.HasOnePair(hand);
            }
            else
            {
                return new ClassicPokerHandValue(0, 0, false);
            }
        }

        public IHandValue HasOnePair(Hand hand)
        {
            for (int x = 0; x < hand.Cards.Count(); x++)
            {
                Card card1 = hand.Cards.ElementAt(x);
                for (int y = 0; y < hand.Cards.Count(); y++)
                {
                    if (x == y)
                        continue;

                    Card card2 = hand.Cards.ElementAt(y);
                    if (card1.CardValue == card2.CardValue)
                        return new ClassicPokerHandValue(1, (int)card1.CardValue, true);
                }
            }

            return new ClassicPokerHandValue(0, 0, false);
        }

        public IHandValue HasTwoPair(Hand hand)
        {
            int pairOneValue = -1;
            for (int x = 0; x < hand.Cards.Count(); x++)
            {
                Card card1 = hand.Cards.ElementAt(x);
                for (int y = 0; y < hand.Cards.Count(); y++)
                {
                    if (x == y)
                        continue;

                    Card card2 = hand.Cards.ElementAt(y);
                    if (card1.CardValue == card2.CardValue)
                    {
                        if (pairOneValue == -1)
                            pairOneValue = (int)card1.CardValue;

                        else if (pairOneValue != -1 && pairOneValue != (int)card1.CardValue)
                            return new ClassicPokerHandValue(2, (int)card1.CardValue > pairOneValue ? (int)card1.CardValue : pairOneValue, true);
                    }
                }
            }

            return new ClassicPokerHandValue(0, 0, false);
        }

        public IHandValue HasThreeOfAKind(Hand hand)
        {
            for (int x = 0; x < hand.Cards.Count(); x++)
            {
                Card card1 = hand.Cards.ElementAt(x);
                for (int y = 0; y < hand.Cards.Count(); y++)
                {
                    if (x == y)
                        continue;

                    Card card2 = hand.Cards.ElementAt(y);
                    for (int z = 0; z < hand.Cards.Count(); z++)
                    {
                        if (x == z || y == z)
                            continue;


                        Card card3 = hand.Cards.ElementAt(z);
                        if (card1.CardValue == card2.CardValue && card2.CardValue == card3.CardValue)
                            return new ClassicPokerHandValue(3, (int)card1.CardValue, true);
                    }
                }
            }

            return new ClassicPokerHandValue(0, 0, false);
        }

        public IHandValue HasStraight(Hand hand)
        {
            bool straight = false;
            for (int x = 0; x < hand.Cards.Count(); x++)
            {
                Card currentCard = hand.Cards.ElementAt(x);
                int highsetValue = 0;

                for (int i = 1; i <= 4; i++)
                {
                    CardValues newValue = currentCard.CardValue + i;
                    if (hand.Cards.Any(x => x.CardValue == newValue) == false)
                    {
                        straight = false;
                        break;
                    }

                    highsetValue = (int)newValue;
                    straight = true;
                }

                if (straight)
                    return new ClassicPokerHandValue(4, highsetValue, true);
            }

            return new ClassicPokerHandValue(0, 0, false);
        }

        public IHandValue HasFlush(Hand hand)
        {
            Card currentCard = hand.Cards.First();
            bool areAllSameType = hand.Cards.All(x => x.CardType == currentCard.CardType);
            if (areAllSameType)
            {
                return new ClassicPokerHandValue(5, (int)hand.Cards.Max(x => x.CardValue), true);
            }
            else
            {
                return new ClassicPokerHandValue(0, 0, false);
            }
        }

        public IHandValue HasFullHouse(Hand hand)
        {
            int threeOfAKindCardValue = -1;

            for (int x = 0; x < hand.Cards.Count(); x++)
            {
                Card card1 = hand.Cards.ElementAt(x);
                for (int y = 0; y < hand.Cards.Count(); y++)
                {
                    if (x == y)
                        continue;

                    Card card2 = hand.Cards.ElementAt(y);
                    for (int z = 0; z < hand.Cards.Count(); z++)
                    {
                        if (x == z || y == z)
                            continue;


                        Card card3 = hand.Cards.ElementAt(z);
                        if (card1.CardValue == card2.CardValue && card2.CardValue == card3.CardValue)
                            threeOfAKindCardValue = (int)card1.CardValue;
                    }
                }
            }

            if (threeOfAKindCardValue == -1)
                return new ClassicPokerHandValue(0, 0, false);


            for (int x = 0; x < hand.Cards.Count(); x++)
            {
                Card card1 = hand.Cards.ElementAt(x);
                for (int y = 0; y < hand.Cards.Count(); y++)
                {
                    if (x == y)
                        continue;

                    Card card2 = hand.Cards.ElementAt(y);
                    if (card1.CardValue == card2.CardValue && threeOfAKindCardValue != (int)card2.CardValue)
                        return new ClassicPokerHandValue(6, threeOfAKindCardValue, true);
                }
            }

            return new ClassicPokerHandValue(0, 0, false);
        }

        public IHandValue HasFourOfAKind(Hand hand)
        {
            for (int x = 0; x < hand.Cards.Count(); x++)
            {
                Card card1 = hand.Cards.ElementAt(x);
                for (int y = 0; y < hand.Cards.Count(); y++)
                {
                    if (x == y)
                        continue;

                    Card card2 = hand.Cards.ElementAt(y);
                    for (int z = 0; z < hand.Cards.Count(); z++)
                    {
                        if (x == z || y == z)
                            continue;

                        Card card3 = hand.Cards.ElementAt(z);
                        for (int p = 0; p < hand.Cards.Count(); p++)
                        {
                            if (x == p || y == p || z == p)
                                continue;


                            Card card4 = hand.Cards.ElementAt(p);
                            if (card1.CardValue == card2.CardValue &&
                                card2.CardValue == card3.CardValue &&
                                card3.CardValue == card4.CardValue)
                                return new ClassicPokerHandValue(7, (int)card3.CardValue, true);
                        }
                    }
                }
            }

            return new ClassicPokerHandValue(0, 0, false);
        }

        public IHandValue HasStraightFlush(Hand hand)
        {
            bool hasStraight = this.HasStraight(hand).IsFound();
            bool hasFlush = this.HasFlush(hand).IsFound();

            if (hasStraight && hasFlush)
                return new ClassicPokerHandValue(8, (int)hand.Cards.Max(x => x.CardValue), true);

            return new ClassicPokerHandValue(0, 0, false);
        }

        public IHandValue HasRoyalStraightFlush(Hand hand)
        {
            bool hasStraight = this.HasStraight(hand).IsFound();
            bool hasFlush = this.HasFlush(hand).IsFound();

            if (hasStraight && hasFlush)
            {
                CardValues smallesValue = hand.Cards.Min(x => x.CardValue);
                if (smallesValue == CardValues.Ten)
                    return new ClassicPokerHandValue(9, (int)hand.Cards.Max(x => x.CardValue), true);
            }

            return new ClassicPokerHandValue(0, 0, false);
        }

        public CardValues GetHighCardValueExcept(IEnumerable<Card> cards, IEnumerable<CardValues> valuesSkip)
        {
            var maxValue = cards
                .Where(x => valuesSkip.Any(value => value == x.CardValue) == false)
                .Max(x => x.CardValue);

            return maxValue;
        }
    }
}