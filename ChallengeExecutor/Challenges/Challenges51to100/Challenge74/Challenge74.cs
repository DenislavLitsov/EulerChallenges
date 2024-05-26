using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge74
{
    public class Challenge74 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            int result = 0;
            for (int i = 2; i < Constants.OneMilion; i++)
            {
                int repeats = this.GetNonRepeatingChainCount(i);
                if (repeats == 60)
                {
                    result++;
                }
            }

            return result;
        }

        private int GetNonRepeatingChainCount(int startingNumber)
        {
            List<int> chain = new List<int>();
            int number = startingNumber;
            while (chain.Contains(number) == false)
            {
                chain.Add(number);
                string parsedNumber = number.ToString();
                number = 0;

                for (int i = 0; i < parsedNumber.Length; i++)
                {
                    int fact = int.Parse(parsedNumber[i].ToString()).Factorial();
                    number += fact;
                }
            }

            return chain.Count;
        }
    }
}
