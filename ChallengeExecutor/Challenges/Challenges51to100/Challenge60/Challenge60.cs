using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;
using Common.Exceptions;
using Common.NumberSequences;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge60
{
    public class Challenge60 : BaseChallenge<long>
    {
        private const int max_index = Constants.OneMilion;

        private PrimeSequenceGenerator PrimeSequenceGenerator;

        protected override void Setup()
        {
            this.PrimeSequenceGenerator = new PrimeSequenceGenerator(0, max_index);
        }

        protected override long SolveImplementation()
        {
            throw new NotImplementedException();
        }

        private bool IsSolution(List<long> primes)
        {
            for (int x = 0; x < primes.Count; x++)
            {
                for (int y = 0; y < primes.Count; y++)
                {
                    if (x == y)
                        continue;

                    var currPrime1 = primes[x].ToString();
                    var currPrime2 = primes[y].ToString();

                    var buildedPrime1 = currPrime1 + currPrime2;
                    var buildedPrime2 = currPrime2 + currPrime1;

                    var parsedPrime1 = long.Parse(buildedPrime1);
                    var parsedPrime2 = long.Parse(buildedPrime2);

                    if (parsedPrime1 < 0)
                        throw new OverflowException();

                    var isFirstPrime = parsedPrime1.IsPrime();
                    var isSecondtPrime = parsedPrime2.IsPrime();

                    if (!isFirstPrime || !isSecondtPrime)
                        return false;
                }
            }

            return true;
        }
    }
}
