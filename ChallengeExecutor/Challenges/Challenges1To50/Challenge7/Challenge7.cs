using ChallengeExecutor.Challenges.Abstractions;
using Common;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge7
{
    public class Challenge7 : BaseChallenge<long>
    {
        public Challenge7()
        {
        }

        public override string GetName()
        {
            return "Challenge7";
        }

        protected override long SolveImplementation()
        {
            List<long> primes = new List<long>();
            for (long i = 3; i < long.MaxValue; i += 2)
            {
                if (i.IsPrime())
                {
                    primes.Add(i);

                    //Console.WriteLine($"New prime: {i}, TotalSize: {primes.Count}");
                }

                if (primes.Count >= 10000)
                {
                    break;
                }
            }

            //Console.WriteLine("Result: ");
            //Console.WriteLine(primes.Last());

            var res = primes.Last();
            return res;
        }
    }
}
