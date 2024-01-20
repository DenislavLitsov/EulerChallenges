using ChallengeExecutor.Challenges.Abstractions;
using Common;
using System.Numerics;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge55
{
    public class Challenge55 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge55";
        }

        protected override int SolveImplementation()
        {
            int totalLychrelNumberCount = 0;
            for (int i = 1; i < 10000; i++)
            {
                if (this.IsLychrelNumber(i))
                    totalLychrelNumberCount++;
            }

            return totalLychrelNumberCount;
        }

        private bool IsLychrelNumber(BigInteger number)
        {
            BigInteger currNumber = number;
            for (int i = 0; i < 50; i++)
            {
                var reversedNumber = new String(currNumber.ToString().Reverse().ToArray());
                BigInteger toAdd = BigInteger.Parse(reversedNumber);
                currNumber += toAdd;

                if (currNumber.ToString().IsPalindrome())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
