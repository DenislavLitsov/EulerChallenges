using ChallengeExecutor.Challenges.Abstractions;
using Common.AdvancedMath;
using Common.Exceptions;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge57
{
    public class Challenge57 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            int result = 0;

            for (int i = 1; i <= 1000; i++)
            {
                NumberFraction fractionResult = new NumberFraction(1, 2);
                for (int x = 0; x < i; x++)
                {
                    fractionResult = this.Expand(fractionResult);
                }

                fractionResult = fractionResult + 1;

                if (fractionResult.Number.ToString().Length > fractionResult.Denominator.ToString().Length)
                    result++;
            }

            return result;
        }

        private NumberFraction Expand(NumberFraction currFraction)
        {
            var plus2 = currFraction + 2;
            var divide1 = new NumberFraction(1) / plus2;
            return divide1;
        }
    }
}
