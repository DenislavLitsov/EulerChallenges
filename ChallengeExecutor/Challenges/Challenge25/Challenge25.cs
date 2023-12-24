using System.Numerics;
using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenge25
{
    public class Challenge25 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge25";
        }

        protected override int SolveImplementation()
        {
            BigInteger num1 = 1;
            BigInteger num2 = 1;

            int index = 2;
            do
            {
                BigInteger temp = num2;
                num2 += num1;
                num1 = temp;

                index++;
            } while (num2.ToString().Length < 1000);

            return index;
        }
    }
}
