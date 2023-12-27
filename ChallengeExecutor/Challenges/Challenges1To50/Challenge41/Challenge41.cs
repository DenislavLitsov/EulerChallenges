using ChallengeExecutor.Challenges.Abstractions;
using Common;
using System.Runtime.CompilerServices;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge41
{
    public class Challenge41 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge41";
        }

        protected override int SolveImplementation()
        {
            int bestNumber = 0;
            int bestParts = 0;

            for (int i = 3; i < 1000000000; i += 2)
            {
                var iAsString = i.ToString();
                bool isPandigital = true;
                for (int j = 0; j < iAsString.Length; j++)
                {
                    if (iAsString.Contains(((char)(j + 49))) == false)
                    {
                        isPandigital = false;
                        break;
                    }
                }

                if (!isPandigital)
                    continue;

                bool isPrime = i.IsPrime();
                if (isPrime && bestNumber < i)
                {
                    bestNumber = i;
                    bestParts = iAsString.Length;
                }
            }

            return bestNumber;
        }
    }
}
