using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge72
{
    public class Challenge72 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            int res = 0;
            for (int d = 2; d < Constants.OneMilion; d++)
            {
                Console.WriteLine(d);
                for (int number = d - 1; number > 0; number--)
                {
                    if (d.HasCommonFactorExcept1(number))
                    {
                        continue;
                    }

                    res++;
                }
            }

            return res;
        }
    }
}
