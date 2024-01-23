using ChallengeExecutor.Challenges.Abstractions;
using Common.NumberSequences.Spirals;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge58
{
    public class Challenge58 : BaseChallenge<long>
    {
        public override string GetName()
        {
            return "Challenge58";
        }

        protected override long SolveImplementation()
        {
            var generator = new TwoDSpiralNumberGenerator(1);

            double totalDiagonalNumbers = 0;
            double totalPrimes = 0;

            while (totalPrimes / totalDiagonalNumbers >= 0.1d || totalPrimes == 0)
            {
                var diagonals = generator.GetNextAngles();
                foreach (var diagonal in diagonals)
                {
                    totalDiagonalNumbers++;
                    if (diagonal.Value.IsPrime())
                        totalPrimes++;
                }
            }

            // Remove 2 because this will be the row size for the comming onion shell
            return generator.CurrSideSize - 2;
        }
    }
}
