using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge56
{
    public class Challenge56 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge56";
        }

        protected override int SolveImplementation()
        {
            int bestCount = 0;
            for (int a = 1; a < 100; a++)
            {
                for (int b = 1; b < 100; b++)
                {
                    var bigNumberAsString = a.BigPower(b).ToString();
                    int currCount = 0;
                    foreach (var currChar in bigNumberAsString)
                    {
                        currCount += int.Parse(currChar.ToString());
                    }

                    if (currCount > bestCount)
                        bestCount = currCount;
                }
            }

            return bestCount;
        }
    }
}
