using ChallengeExecutor.Challenges.Abstractions;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge63
{
    public class Challenge63 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            int result = 0;
            for (long number = 1; number < 10; number++)
            {
                for (int power = 1; power < 1000; power++)
                {
                    var newNumber = number.BigPower(power);

                    string numberString = newNumber.ToString();
                    if (numberString.Length > power)
                        break;

                    if (numberString.Length == power)
                    {
                        result++;
                        Console.WriteLine($"Result: {result}; Number: {number}, Power: {power}, calculatedNumer: {numberString}");
                    }
                }
            }

            return result;
        }
    }
}
