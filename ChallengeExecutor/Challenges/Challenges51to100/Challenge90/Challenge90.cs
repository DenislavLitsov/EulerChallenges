using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.Combinatorics;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge90
{
    public class Challenge90 : BaseChallenge<int>
    {
        private IEnumerable<int> AllSquareNumbers = new List<int>()
        {
            1, 4, 9, 16, 25, 36, 49, 64, 81
        };

        protected override int SolveImplementation()
        {
            var engine1 = this.GetEngine();
            long combos = 0;

            while (!engine1.IsOverflown)
            {
                combos++;
                engine1.GetNextCombination();
                //var engine2 = this.GetEngine();
                //while (!engine2.IsOverflown)
                //{
                //    engine2.GetNextCombination();
                //}
            }

            Console.WriteLine(combos);
            Console.WriteLine(combos * combos);
            return 0;
        }

        private CombinatoricsEngine<int> GetEngine()
        {
            List<int> possibleValues = new List<int>()
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            CombinatoricsEngine<int> engine = new CombinatoricsEngine<int>(null, possibleValues, true);
            for (int i = 0; i < 5; i++)
            {
                var newEngine = new CombinatoricsEngine<int>(engine, possibleValues, true);
                engine = newEngine;
            }

            return engine;
        }
    }
}