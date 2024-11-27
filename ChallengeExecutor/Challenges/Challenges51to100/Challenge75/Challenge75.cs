using ChallengeExecutor.Challenges.Abstractions;
using Common.AdvancedMath;
using Common.AdvancedMath.Geometry;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge75
{
    public class Challenge75 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            const int maxRopeLength = 1500000;
            int maxC = maxRopeLength / 2;

            for (int c = 1; c < maxC; c++)
            {
                int aAndB = maxRopeLength - c;

                int maxA = (aAndB / 2) + 1;
                for (int a = 1; a <= maxA; a++)
                {
                    int b = aAndB - a;

                }
            }

            return 0;
        }
    }
}