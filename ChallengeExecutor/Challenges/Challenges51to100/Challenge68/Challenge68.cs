using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.Combinatorics;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge68
{
    public class Challenge68 : BaseChallenge<string>
    {
        protected override string SolveImplementation()
        {
            List<int> values = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CombinatoricsEngine<int> engine = new CombinatoricsEngine<int>(null, values, true);
            for (int i = 0; i < 9; i++)
            {
                var newEngine = new CombinatoricsEngine<int>(engine, values, true);
                engine = newEngine;
            }

            List<IEnumerable<int>> possibleSolutions = new List<IEnumerable<int>>();

            while (engine.IsOverflown == false)
            {
                var next = engine.GetNextCombination();
                if (next.Count() != 10)
                {
                    continue;
                }

                var magicRing = new MagicFiveGonRing(next.ToArray());
                if (magicRing.IsMagicRing())
                {
                    possibleSolutions.Add(next);
                }
            }

            var result = possibleSolutions
                .Select(x=>x.ConcentrateArray())
                .ToList()
                .Max();

            return result;
        }
    }
}
