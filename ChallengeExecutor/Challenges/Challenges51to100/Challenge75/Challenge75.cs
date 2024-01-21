using ChallengeExecutor.Challenges.Abstractions;
using Common.AdvancedMath;
using Common.AdvancedMath.Geometry;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge75
{
    public class Challenge75 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge75";
        }

        protected override int SolveImplementation()
        {
            int answer = 0;

            int count = 0;
            for (int i = 3; i < 1500000; i += 2)
            {
                if (i.IsPrime())
                {
                    count++;
                }
            }

            Console.WriteLine(count);

            for (int p = 12; p <= 1500; p += 2)
            {
                if (p % 100 == 0)
                {
                    Console.WriteLine(p);
                }

                int currSolutions = 0;

                int maxA = p / 2 - 2;
                int printA = 0;
                int printB = 0;
                int printC = 0;

                for (int a = 1; a <= maxA; a++)
                {
                    int maxB = (p - a) / 2;
                    for (int b = a + 1; b <= maxB; b++)
                    {
                        int c = p - a - b;

                        //Triangle triangle = new Triangle(a, b, c);
                        if (a * a + b * b == c * c)
                        {
                            printA = a;
                            printB = b;
                            printC = c;
                            currSolutions++;

                            if (currSolutions > 1)
                                break;
                        }
                    }

                    if (currSolutions > 1)
                        break;
                }

                if (currSolutions == 1)
                {
                    Console.WriteLine($"Right angle P: {p}, A:{printA}, B:{printB}, C:{printC},  A to B = {printA / (decimal)printB}");
                    answer++;
                }
            }

            return answer;
        }
    }
}
