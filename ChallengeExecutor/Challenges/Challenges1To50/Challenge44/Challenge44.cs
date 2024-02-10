using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.NumberSequences;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge44
{
    public class Challenge44 : BaseChallenge<long>
    {
        private PentagonalSequenceGenerator _PentagonalSquenceGenerator;

        private const int MaxIndex = Constants.OneMilion * 60;

        protected override void Setup()
        {
            this._PentagonalSquenceGenerator = new PentagonalSequenceGenerator();
            this._PentagonalSquenceGenerator.CacheSequence(0, MaxIndex);
            Console.WriteLine("Setup finished");
        }

        protected override long SolveImplementation()
        {
            long bestD = int.MaxValue;
            for (int index1 = 1; index1 < MaxIndex; index1++)
            {
                for (int index2 = 1; index2 < MaxIndex; index2++)
                {
                    if (index1 == index2)
                        continue;

                    long pentagonal1 = this._PentagonalSquenceGenerator.GetCachedValue(index1);
                    long pentagonal2 = this._PentagonalSquenceGenerator.GetCachedValue(index2);

                    long pentagonalSum = pentagonal1 + pentagonal2;
                    long pentagonalSubstraction = pentagonal1 - pentagonal2;
                    if (pentagonalSubstraction < 0)
                        break;

                    if (this._PentagonalSquenceGenerator.ContainedInCachedSequence(pentagonalSum) &&
                        this._PentagonalSquenceGenerator.ContainedInCachedSequence(pentagonalSubstraction) &&
                        pentagonalSubstraction < bestD)
                    {
                        bestD = pentagonalSubstraction;
                        Console.WriteLine($"New best D found: {bestD}");
                        return bestD;
                    }
                }
            }

            return bestD;
        }
    }
}
