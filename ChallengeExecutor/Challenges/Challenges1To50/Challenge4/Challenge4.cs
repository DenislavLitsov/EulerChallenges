using ChallengeExecutor.Challenges.Abstractions;
using Common;
using System.Numerics;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge4
{
    public class Challenge4 : BaseChallenge<long>
    {
        public Challenge4()
        {
        }

        protected override long SolveImplementation()
        {

            int currentMaxPalidrome = 0;

            for (int number1 = 100; number1 < 1000; number1++)
            {
                for (int number2 = 100; number2 < 1000; number2++)
                {
                    int multiple = number1 * number2;
                    if (isPalidrome(multiple))
                    {
                        if (multiple > currentMaxPalidrome)
                        {
                            currentMaxPalidrome = multiple;
                        }
                    }
                }
            }

            return currentMaxPalidrome;
        }

        private bool isPalidrome(int number)
        {
            string stringified = number.ToString();
            if (stringified.Length % 2 != 0)
            {
                //Console.WriteLine("ITS NOT EVEN");
                return false;
            }

            int size = stringified.Length;
            string firstPart = stringified.Substring(0, size / 2);
            string secondPart = stringified.Substring((size / 2), size / 2);


            if (firstPart + secondPart != stringified)
            {
                throw new Exception("falsly divided");
            }

            string reversed = secondPart.ToCharArray().Reverse().Stringify();

            if (firstPart == reversed)
            {
                return true;
            }
            return false;
        }
    }
}
