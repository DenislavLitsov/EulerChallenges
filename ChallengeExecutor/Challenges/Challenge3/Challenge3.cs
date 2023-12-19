using Common;

namespace ChallengeExecutor.Challenges.Challenge3
{
    public class Challenge3 : BaseChallenge<long>
    {
        public Challenge3()
        {
        }

        public override string GetName()
        {
            return "Challenge3";
        }

        protected override long SolveImplementation()
        {
            long number = 600851475143;
            List<long> dividers = new List<long>();

            do
            {
                for (int i = 2; i < (number / 2) + 1; i++)
                {
                    if (number % i == 0)
                    {
                        dividers.Add(i);
                        number = number / i;
                        Console.WriteLine($"Number: {number}, divider: {i}");
                        break;
                    }

                    if (AdvancedMath.IsPrime(number))
                    {
                        dividers.Add(number);
                        number = 1;
                        break;
                    }
                }
            } while (number != 1);


            // 6857 is the answer
            dividers.Print();

            return dividers.Max();
        }
    }
}
