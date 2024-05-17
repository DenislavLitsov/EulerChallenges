using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.Combinatorics;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge68
{
    public class Challenge68 : BaseChallenge<long>
    {
        protected override long SolveImplementation()
        {
            List<int> values = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            CombinatoricsEngine<int> engine = new CombinatoricsEngine<int>(null, values, true);
            for (int i = 0; i < 9; i++)
            {
                var newEngine = new CombinatoricsEngine<int>(engine, values, true);
                engine = newEngine;
            }

            List<MagicFiveGonRing> possibleSolutions = new List<MagicFiveGonRing>();

            while (engine.IsOverflown == false)
            {
                var next = engine.GetNextCombination()
                    .ToArray();

                if (next.Length != 10)
                {
                    continue;
                }

                var magicRing = new MagicFiveGonRing(next);
                if (magicRing.IsMagicRing())
                {
                    possibleSolutions.Add(magicRing);
                }
            }

            var result = possibleSolutions
                .OrderBy(x => x.GetFirstValue())
                .Select(x => x.GetConcentratedString())
                .Where(x => x.Count() == 16)
                .Select(x => long.Parse(x))
                .ToList();

            var res = result
                .Max();

            return res;
        }

        protected long ThreeGonRing()
        {
            List<int> values = new List<int>() { 1, 2, 3, 4, 5, 6 };
            CombinatoricsEngine<int> engine = new CombinatoricsEngine<int>(null, values, true);
            for (int i = 0; i < 5; i++)
            {
                var newEngine = new CombinatoricsEngine<int>(engine, values, true);
                engine = newEngine;
            }

            List<MagicThreeGonRing> possibleSolutions = new List<MagicThreeGonRing>();

            while (engine.IsOverflown == false)
            {
                var next = engine.GetNextCombination()
                    .ToArray();

                if (next.Length != 6)
                {
                    continue;
                }

                var magicRing = new MagicThreeGonRing(next);
                if (magicRing.IsMagicRing())
                {
                    possibleSolutions.Add(magicRing);
                }
            }

            var result = possibleSolutions
                .Where(x => x.GetLineValue() == 9)
                .OrderBy(x => x.GetFirstValue())
                .Select(x => x.GetConcentratedString())
                .Select(x => long.Parse(x))
                .ToList();

            var first = result.First().ToString()[0];
            var res = result.Where(x => x.ToString()[0] == first)
                .Last();

            return res;
            return 3;
            //return result;
        }
    }
}
