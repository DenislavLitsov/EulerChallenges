using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge27
{
    public class Challenge27 : BaseChallenge<long>
    {
        public override string GetName()
        {
            return "Challenge27";
        }

        protected override long SolveImplementation()
        {
            long bestA = 0;
            long bestB = 0;

            long bestSequence = 0;

            for (long a = -999; a < 1000; a++)
            {
                for (long b = -1000; b <= 1000; b++)
                {
                    int sequence = this.GetSequenceCount(a, b);
                    if (sequence > bestSequence)
                    {
                        bestSequence = sequence;
                        bestA = a;
                        bestB = b;
                    }
                }
            }

            Console.WriteLine($"BestA: {bestA}");
            Console.WriteLine($"BestB: {bestB}");
            Console.WriteLine($"Best Seqence: {bestSequence}");

            return bestA * bestB;
        }

        private int GetSequenceCount(long a, long b)
        {
            bool isPrime = false;
            int index = 0;

            do
            {
                long number = (index * index) + (a * index) + b;
                isPrime = number.IsPrime();
                index++;
            } while (isPrime);

            index--;
            return index;
        }
    }
}
