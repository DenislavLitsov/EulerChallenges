using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge9
{
    public class Challenge9 : BaseChallenge<long>
    {
        public override string GetName()
        {
            return "Challenge9";
        }

        protected override long SolveImplementation()
        {
            for (int a = 0; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    for (int c = b + 1; c < 1000; c++)
                    {
                        if (a + b + c != 1000)
                        {
                            continue;
                        }

                        int product1 = a * a + b * b;
                        int product2 = c * c;

                        if (product1 != product2)
                        {
                            continue;
                        }

                        Console.WriteLine($"Triplets: {a}, {b}, {c}");
                        Console.WriteLine($"Product: {a * b * c}");

                        return a * b * c;
                    }
                }
            }

            throw new Exception();
        }
    }
}
