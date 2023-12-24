using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenge32
{
    public class Challenge32 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge32";
        }

        protected override int SolveImplementation()
        {
            List<int> products = new List<int>();

            for (int multiplicand = 1; multiplicand < 9999; multiplicand++)
            {
                for (int multiplier = 1; multiplier < 9999; multiplier++)
                {
                    int product = multiplicand * multiplier;
                    string wholeNumber = multiplicand.ToString() + multiplier.ToString() + product.ToString();

                    if (wholeNumber.Length > 9)
                        break;

                    if (wholeNumber.Contains('0') || wholeNumber.Length != 9)
                        continue;

                    bool correct = true;
                    for (int i = 1; i <= 9; i++)
                    {
                        if (!wholeNumber.Contains(i.ToString()))
                        {
                            correct = false;
                            break;
                        }
                    }

                    if (!correct)
                        continue;

                    if (!products.Contains(product))
                        products.Add(product);
                }
            }

            int sum = products.Sum();
            return sum;
        }
    }
}
