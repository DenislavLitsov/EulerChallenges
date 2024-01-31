using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;
using Common.Exceptions;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge71
{
    public class Challenge71 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            double numberToCheck = 3.0d / 7.0d;
            double bestFound = 0;
            double bestNumerator = 0;

            for (double d = 2; d < Constants.OneMilion; d++)
            {
                int start = (int)(numberToCheck * d) - 1;
                for (double n = start; n < d; n++)
                {
                    double value = n / d;
                    if (value >= numberToCheck)
                        break;

                    if (value > bestFound)
                    {
                        bestFound = value;
                        bestNumerator = n;
                    }
                }
            }

            return (int)bestNumerator;
        }
    }
}
