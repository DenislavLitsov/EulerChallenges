using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenge14
{
    public class Challenge14 : BaseChallenge<long>
    {
        public override string GetName()
        {
            return "Challenge14";
        }

        protected override long SolveImplementation()
        {
            long bestNumber = 0;
            long bestIterations = 0;
            for (long i = 2; i < 1000000; i++)
            {
                long currNum = i;
                long totalIterations = 1;

                while (currNum != 1)
                {
                    totalIterations++;
                    currNum = GetNext(currNum);
                }

                if (totalIterations > bestIterations)
                {
                    bestIterations = totalIterations;
                    bestNumber = i;

                    Console.WriteLine($"New best iterations: {bestIterations}, number: {bestNumber}");
                }
            }

            return bestNumber;
        }
        private long GetNext(long num)
        {
            if (num % 2 == 0)
            {
                return num / 2;
            }

            return (3 * num) + 1;
        }
    }
}
