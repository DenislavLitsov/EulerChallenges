using ChallengeExecutor.Challenges.Abstractions;
using Common;
using System.Numerics;

namespace ChallengeExecutor.Challenges.Challenge20
{
    public class Challenge20 : BaseChallenge<long>
    {
        public override string GetName()
        {
            return "Challenge20";
        }

        protected override long SolveImplementation()
        {
            BigInteger bigInteger = 1;
            for (int i = 100; i > 0; i--)
            {
                bigInteger *= i;
            }

            Console.WriteLine(bigInteger);

            long sum = bigInteger.ToString().GetSumOfNumbers();
            return sum;
        }
    }
}
