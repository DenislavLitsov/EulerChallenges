using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.NumberSequences;

namespace ChallengeExecutor.Challenges.Challenge44
{
    public class Challenge44 : BaseChallenge<long>
    {
        private PentagonalSequenceGenerator _PentagonalSquenceGenerator;

        public override string GetName()
        {
            return "Challenge44";
        }

        protected override void Setup()
        {
            this._PentagonalSquenceGenerator = new PentagonalSequenceGenerator();
            this._PentagonalSquenceGenerator.CacheSequence(0, this._PentagonalSquenceGenerator.GetMaximaValidIndex());
        }

        protected override long SolveImplementation()
        {
            long bestD = int.MaxValue;
            for (int index1 = 1; index1 < this._PentagonalSquenceGenerator.GetMaximaValidIndex(); index1++)
            {
                for (int index2 = 1; index2 < this._PentagonalSquenceGenerator.GetMaximaValidIndex(); index2++)
                {
                    if (index1 == index2)
                        continue;

                    long pentagonal1 = this._PentagonalSquenceGenerator.GetCachedValue(index1);
                    long pentagonal2 = this._PentagonalSquenceGenerator.GetCachedValue(index2);

                    long pentagonalSum = pentagonal1 + pentagonal2;
                    long pentagonalSubstraction = Math.Abs(pentagonal1 - pentagonal2);
                    if (this._PentagonalSquenceGenerator.ContainsInCachedSequence(pentagonalSum) &&
                        this._PentagonalSquenceGenerator.ContainsInCachedSequence(pentagonalSubstraction) &&
                        pentagonalSubstraction < bestD)
                    {
                        bestD = pentagonalSubstraction;
                        Console.WriteLine($"New best D found: {bestD}");
                    }
                }
            }

            return bestD;
        }
    }
}
