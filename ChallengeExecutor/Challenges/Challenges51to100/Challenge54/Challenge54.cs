using ChallengeExecutor.Challenges.Abstractions;
using Common.Cards.GameEngines;
using Common.Cards.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge54
{
    public class Challenge54 : FileReadingChallenge<int>
    {
        private CardGameEngine CardGameEngine;

        private List<List<Hand>> GameHands;

        public Challenge54()
        {
            this.CardGameEngine = new ClassicPokerGameEngine();
            this.GameHands = new List<List<Hand>>();
        }

        protected override string GetFilePath()
        {
            return "Challenges/Challenges51to100/Challenge54/Poker.txt";
        }

        protected override void Setup()
        {
            var readFile = this.ReadFile();
            foreach (var line in readFile)
            {
                var cards = line.Split(' ');
                List<Card> parsedCards = new List<Card>();
                foreach (var card in cards)
                {
                    CardValues cardValue = CardValues.One;
                    CardTypes cardType = CardTypes.Hearts;

                    if ((int)card[0] >= (int)'1' && (int)card[0] <= (int)'9')
                    {
                        var currChar = card[0];
                        var parsedChar = int.Parse(currChar.ToString());

                        cardValue = (CardValues)(parsedChar - 1);
                    }
                    else if (card[0] == 'T')
                    {
                        cardValue = CardValues.Ten;
                    }
                    else if (card[0] == 'J')
                    {
                        cardValue = CardValues.Jack;
                    }
                    else if (card[0] == 'Q')
                    {
                        cardValue = CardValues.Queen;
                    }
                    else if (card[0] == 'K')
                    {
                        cardValue = CardValues.King;
                    }
                    else if (card[0] == 'A')
                    {
                        cardValue = CardValues.Ace;
                    }
                    else
                    {
                        throw new Exception("Not parsed card");
                    }

                    if (card[1] == 'C')
                    {
                        cardType = CardTypes.Clubs;
                    }
                    else if (card[1] == 'D')
                    {
                        cardType = CardTypes.Diamonds;
                    }
                    else if (card[1] == 'H')
                    {
                        cardType = CardTypes.Hearts;
                    }
                    else if (card[1] == 'S')
                    {
                        cardType = CardTypes.Spades;
                    }
                    else
                    {
                        throw new Exception("Not parsed card");
                    }

                    var parsedCard = new Card(cardValue, cardType);
                    parsedCards.Add(parsedCard);
                }

                Hand hand1 = new Hand(parsedCards.Take(5));
                Hand hand2 = new Hand(parsedCards.Skip(5).Take(5));
                List<Hand> toAdd = new List<Hand>();
                toAdd.Add(hand1);
                toAdd.Add(hand2);
                this.GameHands.Add(toAdd);
            }
        }

        protected override int SolveImplementation()
        {
            int totalWinsOf1 = 0;
            int index = 0;
            foreach (var gameHand in GameHands)
            {
                var WhoWins = this.CardGameEngine.WhoWins(gameHand, null);
                if (WhoWins == 0)
                    totalWinsOf1++;

                index++;
            }

            return totalWinsOf1;
        }
    }
}
