using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;
using Common.Exceptions;
using Common.NumberSequences;
using System.Net.NetworkInformation;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge60
{
    public class Challenge60 : BaseChallenge<long>
    {
        private const int max_index = 1200;
        //private const int max_index = 10000;

        private PrimeSequenceGenerator PrimeSequenceGenerator;

        protected override void Setup()
        {
            this.PrimeSequenceGenerator = new PrimeSequenceGenerator(0, max_index);
        }

        protected override long SolveImplementation()
        {
            long bestSum = long.MaxValue;

            for (int x1 = 0; x1 < max_index; x1++)
            {
                long prime1 = this.PrimeSequenceGenerator.GetCachedValue(x1);

                for (int x2 = 0; x2 < max_index; x2++)
                {
                    long prime2 = this.PrimeSequenceGenerator.GetCachedValue(x2);
                    if (this.IsSolution(new long[] { prime1, prime2 }) == false)
                        continue;

                    for (int x3 = 0; x3 < max_index; x3++)
                    {
                        long prime3 = this.PrimeSequenceGenerator.GetCachedValue(x3);
                        if (this.IsSolution(new long[] { prime1, prime2, prime3 }) == false)
                            continue;

                        for (int x4 = 0; x4 < max_index; x4++)
                        {
                            long prime4 = this.PrimeSequenceGenerator.GetCachedValue(x4);
                            if (this.IsSolution(new long[] { prime1, prime2, prime3, prime4 }) == false)
                                continue;

                            Console.WriteLine($"Found four: {prime1}, {prime2}, {prime3}, {prime4}");
                            for (int x5 = 0; x5 < max_index; x5++)
                            {
                                long prime5 = this.PrimeSequenceGenerator.GetCachedValue(x5);
                                if (this.IsSolution(new long[] { prime1, prime2, prime3, prime4, prime5 }) == false)
                                    continue;

                                Console.WriteLine($"Found five: {prime1}, {prime2}, {prime3}, {prime4}, {prime5}");
                                var newSum = prime1 + prime2 + prime3 + prime4 + prime5;
                                return newSum;
                            }
                        }
                    }
                }
            }

            throw new NoSolutionFound();
        }

        private bool IsSolution(long[] primes)
        {
            if (primes.Distinct().Count() != primes.Length)
                return false;

            for (int x = 0; x < primes.Length; x++)
            {
                for (int y = 0; y < primes.Length; y++)
                {
                    if (x == y)
                        continue;

                    var currPrime1 = primes[x].ToString();
                    var currPrime2 = primes[y].ToString();

                    var buildedPrime1 = currPrime1 + currPrime2;
                    var buildedPrime2 = currPrime2 + currPrime1;

                    var parsedPrime1 = long.Parse(buildedPrime1);
                    var parsedPrime2 = long.Parse(buildedPrime2);

                    if (parsedPrime1 < 0 || parsedPrime2 < 0)
                        throw new OverflowException();

                    var isFirstPrime = parsedPrime1.IsPrime();
                    if (!isFirstPrime)
                        return false;

                    var isSecondtPrime = parsedPrime2.IsPrime();
                    if (!isSecondtPrime)
                        return false;
                }
            }

            return true;
        }

        private IEnumerable<KeyValuePair<long, long>> GetPossibleSplits(long number)
        {
            List<KeyValuePair<long, long>> result = new();

            string numAsString = number.ToString();
            for (int i = 1; i <= numAsString.Length - 1; i++)
            {
                string str1 = new string(numAsString.Take(i).ToArray());
                string str2 = new string(numAsString.TakeLast(numAsString.Length - i).ToArray());

                if (str1[0] == '0' || str2[0] == '0')
                    continue;

                long number1 = long.Parse(str1);
                long number2 = long.Parse(str2);

                if (number1.IsPrime() == false ||
                    number2.IsPrime() == false ||
                    this.IsSolution(new long[] { number1, number2 }) == false)
                    continue;

                result.Add(new KeyValuePair<long, long>(number1, number2));
            }

            return result;
        }
    }
}
