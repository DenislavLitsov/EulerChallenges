using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge97
{
    public class Challenge97 : BaseChallenge<string>
    {
        protected override string SolveImplementation()
        {
            const int iterations = 7830457;
            long maxLongValue = 9999999999;
            long number = 2;
            for (int i = 0; i < iterations - 1; i++)
            {
                number *= 2;
                if (number > maxLongValue)
                {
                    var last10Digits = number.ToString().TakeLast(10);
                    var asString = new string(last10Digits.ToArray());
                    number = long.Parse(asString);
                }
            }

            var formulaResult = (28433 * number) + 1;
            var stringResult = new string (formulaResult.ToString().TakeLast(10).ToArray());
            return stringResult;
        }
    }
}
