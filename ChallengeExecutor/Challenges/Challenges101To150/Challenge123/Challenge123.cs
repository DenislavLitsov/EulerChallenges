using System.Numerics;
using ChallengeExecutor.Challenges.Abstractions;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges101To150.Challenge123
{
    public class Challenge123 : BaseChallenge<long>
    {
        protected override long SolveImplementation()
        {
            BigInteger numberToExceed = 10000000000;
            BigInteger remainder = 0;

            int currentPrimeIndex = 2;
            long currentPrimeNumber = 3;
            var smallerPrimes = new List<long>() { 2, 3 };

            do
            {
                do
                {
                    currentPrimeNumber += 2;
                } while (currentPrimeNumber.IsPrime(smallerPrimes) == false);

                smallerPrimes.Add(currentPrimeNumber);
                currentPrimeIndex++;
                remainder = this.GetRemainder(currentPrimeIndex, currentPrimeNumber, smallerPrimes);

                Console.WriteLine(currentPrimeIndex);
            } while (remainder < numberToExceed);

            return currentPrimeIndex;
        }

        private BigInteger GetRemainder(int index, long prime, IEnumerable<long> calculatedPrimes)
        {
            BigInteger firstFirst = (prime - 1).BigPower(index, calculatedPrimes);
            BigInteger firstSecond = (prime + 1).BigPower(index, calculatedPrimes);

            BigInteger first = firstFirst + firstSecond;
            BigInteger second = prime.BigPower(2);
            
            BigInteger remainder = first % second;
            return remainder;
        }
    }
}