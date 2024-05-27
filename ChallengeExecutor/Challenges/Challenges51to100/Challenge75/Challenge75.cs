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
            Dictionary<int, RightTrianglesWrapper> triangles = new Dictionary<int, RightTrianglesWrapper>();

            for (int c = 1; c < maxRopeLength; c++)
            {
                Console.WriteLine(c);
                int maxA = maxRopeLength - c - 1;
                for (int a = 1; a < maxRopeLength; a++)
                {
                    if (a + c > maxRopeLength)
                        break;

                    for (int b = 1; b < maxRopeLength; b++)
                    {
                        int currRopeLength = a + c + b;
                        if (a + c + b > currRopeLength)
                            break;

                        if (c*c != a*a + b*b)
                            continue;

                        var stringifiedTriangle =
                            c.ToString() + (a > b ? a : b).ToString() + (a > b ? b : a).ToString();

                        if (triangles.ContainsKey(currRopeLength))
                        {
                            var wrapper = triangles[currRopeLength];
                            if (wrapper.RightTriangles.Any(x=>x == stringifiedTriangle) == false)
                            {
                                wrapper.RightTriangles.Add(stringifiedTriangle);
                            }
                        }
                        else
                        {
                            triangles.Add(currRopeLength, new RightTrianglesWrapper(stringifiedTriangle));
                        }
                    }
                }
            }

            var count = triangles.Count(x => x.Value.RightTriangles.Count == 1);
            return count;
        }
    }
}