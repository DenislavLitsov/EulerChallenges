using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.NumberSequences;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge46
{
    public class Challenge46 : BaseChallenge<int>
    {
        private const int maxPrimeIndex = Constants.OneMilion;

        PrimeSequenceGenerator _PrimeSequenceGenerator;

        protected override void Setup()
        {
            this._PrimeSequenceGenerator = new PrimeSequenceGenerator(0, maxPrimeIndex);
        }

        protected override int SolveImplementation()
        {
            long lastPrime = this._PrimeSequenceGenerator.GetCachedValue(maxPrimeIndex-1);
            for (int i = 3; i < lastPrime; i += 2)
            {
                if (this._PrimeSequenceGenerator.ContainedInCachedSequence(i))
                    continue;

                bool isWritten = false;
                for (int primeIndex = 0; primeIndex < maxPrimeIndex - 1; primeIndex++)
                {
                    long primeNumber = this._PrimeSequenceGenerator.GetCachedValue(primeIndex);
                    for (int additionIndex = 0; additionIndex < lastPrime; additionIndex++)
                    {
                        long newNumber = primeNumber + 2 * (additionIndex * additionIndex);
                        if (newNumber > i)
                        {
                            break;
                        }
                        if (newNumber == i)
                        {
                            isWritten = true;
                        }
                    }

                    if (isWritten)
                    {
                        break;
                    }
                }

                if (!isWritten)
                {
                    return i;
                }
            }

            throw new Exception("Not solved");
        }
    }
}
