using System.Numerics;
using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge16
{
    public class Challenge16 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            BigInteger bigIntegerValue = 1;
            for (BigInteger i = 0; i < 1000; i++)
            {
                bigIntegerValue *= 2;
            }

            string stringifiedNumber = bigIntegerValue.ToString();
            int result = 0;
            for (int i = 0; i < stringifiedNumber.Length; i++)
            {
                result += int.Parse(stringifiedNumber[i].ToString());
            }

            return result;
        }
    }
}
