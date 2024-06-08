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
                var divisors = i.GetAllDivisorsExcludingSameNumber()
                    .Skip(1)
                    .ToList();
                this.allDivisors.Add(i, divisors);
            }
        }

        protected override int SolveImplementation()
        {
            int bestNumber = 0;
            double bestRatio = 0;

            List<int> bestRelativePrimes;

            for (int n = 2; n <= Constants.OneMilion; n++)
            {
                var nDivisors = this.allDivisors[n];
                List<int> relativePrimes = new List<int>(n / 2)
                {
                    1,
                };

                for (int i = 2; i < n; i++)
                {
                    var iDivisors = this.allDivisors[i];
                    bool areRelativePrimes = (nDivisors.Contains(i) == false && nDivisors.Any(x => iDivisors.Contains(x)) == false);
                    if (areRelativePrimes)
                    {
                        relativePrimes.Add(i);
                    }
                }

                int fN = relativePrimes.Count;
                double max = (double)n / (double)fN;
                if (max > bestRatio)
                {
                    bestNumber = n;
                    bestRatio = max;
                    bestRelativePrimes = relativePrimes;
                }
            }

            return bestNumber;
        }
    }
}
