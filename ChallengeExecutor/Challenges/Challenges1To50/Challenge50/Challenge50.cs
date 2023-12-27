using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.NumberSequences;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge50
{
    public class Challenge50 : BaseChallenge<long>
    {
        PrimeSequenceGenerator _PrimeSequenceGenerator;

        public override string GetName()
        {
            return "Challenge50";
        }

        protected override void Setup()
        {
            this._PrimeSequenceGenerator = new PrimeSequenceGenerator(0, Constants.OneMilion);
        }

        protected override long SolveImplementation()
        {
            long currNum = 0;
            long bestNum = 0;
            long bestTerms = 0;

            for (int s = 0; s < Constants.OneMilion; s++)
            {
                long index = 0;
                currNum = 0;
                for (int i = s; i < Constants.OneMilion; i++)
                {
                    index++;
                    long currPrime = this._PrimeSequenceGenerator.GetCachedValue(i);
                    if (currPrime > Constants.OneMilion)
                        break;

                    currNum += currPrime;
                    if (currNum > Constants.OneMilion)
                        break;

                    if (bestTerms < index && this._PrimeSequenceGenerator.ContainsInCachedSequence(currNum))
                    {
                        bestNum = currNum;
                        bestTerms = index;
                        Console.WriteLine($"Best number: {bestNum} terms: {bestTerms}");
                    }
                }
            }

            return bestNum;
        }
    }
}
