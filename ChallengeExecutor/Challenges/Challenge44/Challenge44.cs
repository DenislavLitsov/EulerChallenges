using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.NumberSequences;

namespace ChallengeExecutor.Challenges.Challenge44
{
    public class Challenge44 : BaseChallenge<int>
    {
        private PentagonalSequenceGenerator _PentagonalSquenceGenerator;

        public override string GetName()
        {
            return "Challenge44";
        }

        protected override void Setup()
        {
            this._PentagonalSquenceGenerator = new PentagonalSequenceGenerator();
            this._PentagonalSquenceGenerator.CacheSequence(0, Constants.MaximalPentagonalIndex);
        }

        protected override int SolveImplementation()
        {
            int bestD = int.MaxValue;
            for (int index1 = 1; index1 < Constants.MaximalPentagonalIndex; index1++)
            {
                for (int index2 = 1; index2 < Constants.MaximalPentagonalIndex; index2++)
                {
                    if (index1 == index2)
                        continue;

                    int pentagonal1 = this._PentagonalSquenceGenerator.GetCachedValue(index1);
                    int pentagonal2 = this._PentagonalSquenceGenerator.GetCachedValue(index2);

                    int pentagonalSum = pentagonal1 + pentagonal2;
                    int pentagonalSubstraction = Math.Abs(pentagonal1 - pentagonal2);
                    if (this._PentagonalSquenceGenerator.IsPartOfCachedSequence(pentagonalSum) &&
                        this._PentagonalSquenceGenerator.IsPartOfCachedSequence(pentagonalSubstraction) &&
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
