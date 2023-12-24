using ChallengeExecutor.Challenges.Abstractions;
using Common;
using System.Numerics;

namespace ChallengeExecutor.Challenges.Challenge2
{
    public class Challenge2 : BaseChallenge<int>
    {
        public Challenge2()
        {
        }

        public override string GetName()
        {
            return "Challenge2";
        }

        protected override int SolveImplementation()
        {
            List<int> fibonacciNumbers = new List<int>();
            List<int> foundNumbers = new List<int>();

            this.GenerateFibs(fibonacciNumbers);
            fibonacciNumbers.ForEach(fibonacci => { Console.WriteLine(fibonacci); });

            foundNumbers = fibonacciNumbers.Where(x => x % 2 == 0).ToList();
            return foundNumbers.Sum();
        }
        void GenerateFibs(IList<int> container)
        {
            container.Add(1);
            container.Add(2);
            int currentFib = 3;
            do
            {
                container.Add(currentFib);

                currentFib += container[container.Count - 2];
            } while (currentFib <= 4000000);
        }
    }
}
