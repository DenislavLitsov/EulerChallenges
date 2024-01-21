using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;
using System.Numerics;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge48
{
    public class Challenge48 : BaseChallenge<string>
    {
        public override string GetName()
        {
            return "Challenge48";
        }

        protected override string SolveImplementation()
        {
            BigInteger totalNumber = 0;
            for (int i = 1; i <= 1000; i++)
            {
                BigInteger toAdd = i.BigPower(i);
                totalNumber += toAdd;
            }

            Console.WriteLine($"Total number: {totalNumber}");
            var parsedAsString = totalNumber.ToString();

            return parsedAsString.Substring(parsedAsString.Length - 10, 10);
        }
    }
}
