using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge6
{
    public class Challenge6 : BaseChallenge<long>
    {
        public Challenge6()
        {
        }

        protected override long SolveImplementation()
        {
            long sumOfSquares = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
            }


            long squareOfSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                squareOfSum += i;
            }

            squareOfSum *= squareOfSum;

            Console.WriteLine($"sumOfSquares: {sumOfSquares}");
            Console.WriteLine($"squareOfSum: {squareOfSum}");

            Console.WriteLine($"Difference: {squareOfSum - sumOfSquares}");

            return squareOfSum - sumOfSquares;
        }
    }
}
