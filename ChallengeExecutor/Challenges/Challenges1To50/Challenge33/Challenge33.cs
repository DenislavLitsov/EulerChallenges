using ChallengeExecutor.Challenges.Abstractions;
using Common;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge33
{
    public class Challenge33 : BaseChallenge<decimal>
    {
        protected override decimal SolveImplementation()
        {
            List<decimal> possibleA = new List<decimal>();
            List<decimal> possibleB = new List<decimal>();

            List<decimal> results = new List<decimal>();

            for (decimal a = 10; a <= 99; a++)
            {
                for (decimal b = a + 1; b <= 99; b++)
                {
                    string aAsString = a.ToString();
                    string bAsString = b.ToString();
                    if (aAsString[1] != bAsString[0])
                        continue;

                    decimal newA = decimal.Parse(aAsString[0].ToString());
                    decimal newB = decimal.Parse(bAsString[1].ToString());
                    if (newB == 0)
                        continue;

                    decimal division1 = a / b;
                    decimal division2 = newA / newB;

                    if (division1 != division2)
                        continue;

                    possibleA.Add(a);
                    possibleB.Add(b);

                    results.Add(division1);
                }
            }

            possibleA.Print();
            possibleB.Print();

            results.Print();

            var product = results.Product();
            Console.WriteLine(product);

            var result = (int)(1 / product);
            return result;
        }
    }
}
