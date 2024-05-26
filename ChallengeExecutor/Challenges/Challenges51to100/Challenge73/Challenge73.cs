using System.Numerics;
using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge73
{
    public class Challenge73 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            List<NumberFraction> fractions = new List<NumberFraction>();

            double minValue = 1d / 3d;
            double maxValue = 1d / 2d;

            int maxDCount = 12000;
            int res = 0;

            for (double number = 1; number <= maxDCount; number++)
            {
                double startDenominator = (int)(number / maxValue);
                bool isDivByTwo = number % 2 == 0;
                for (double denominator = startDenominator; denominator <= maxDCount; denominator++)
                {
                    if (isDivByTwo && denominator % 2 == 0)
                    {
                        continue;
                    }

                    double currValue = number / denominator;
                    if (currValue >= maxValue)
                        continue;

                    if (currValue <= minValue)
                        break;

                    if (number.HasCommonFactorExcept1(denominator))
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