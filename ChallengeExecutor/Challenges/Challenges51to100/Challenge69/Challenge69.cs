using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge69
{
    public class Challenge69 : BaseChallenge<int>
    {
        private Dictionary<int, IEnumerable<int>> allDivisors;

        protected override void Setup()
        {
            this.allDivisors = new Dictionary<int, IEnumerable<int>>();

            for (int i = 2; i <= Constants.OneMilion; i++)
            {
                var divisors = this.GetAllDivisorsExcept1(i);
                this.allDivisors.Add(i, divisors);
            }
        }

        protected override int SolveImplementation()
        {
            int bestNumber = 0;
            double bestRatio = 0;

            for (int i = 2; i <= Constants.OneMilion; i++)
            {
                //var relativePrimes = i.GetAllRelativePrimes();
                //var count = relativePrimes.Count();
                //
                //double ratio = (double)(i) / (double)(count);
                //if (ratio > bestRatio)
                //{
                //    bestRatio = ratio;
                //    bestNumber = i;
                //
                //    Console.WriteLine($"Best ratio: {bestRatio}; Best number: {bestNumber}");
                //}
            }

            return bestNumber;
        }

        private IEnumerable<int> GetAllDivisorsExcept1(int number)
        {
            List<int> res = new List<int>();
            int length = (number / 2) + 1;
            for (int i = 2; i < length; i++)
            {
                if (number % i == 0)
                {
                    res.Add(i);
                }
            }

            res.Add(number);
            return res;
        }
    }
}
