using ChallengeExecutor.Challenges.Abstractions;
using Common.AdvancedMath.Geometry;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge39
{
    public class Challenge39 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            int bestP = 0;
            int mostSolutions = 0;

            for (int p = 3; p <= 1000; p++)
            {
                int currSolutions = 0;

                for (int a = 1; a <= p - 2; a++)
                {
                    for (int b = 1; b <= p - a - 1; b++)
                    {
                        int c = p - a - b;
                        Triangle triangle = new Triangle(a, b, c);
                        if (triangle.IsRightAngle)
                            currSolutions++;
                    }
                }

                if (currSolutions > mostSolutions)
                {
                    mostSolutions = currSolutions;
                    bestP = p;
                }
            }

            return bestP;
        }
    }
}
