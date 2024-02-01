using ChallengeExecutor.Challenges.Abstractions;
using Common;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge92
{
    public class Challenge92 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            int totalCount = 0;
            for (int i = 1; i < Constants.OneMilion * 10; i++)
            {
                SquareDigitSequenceGenerator generator = new(i);
                while (true)
                {
                    var nextNum = generator.GetNext();
                    if (nextNum == 1)
                        break;

                    if (nextNum == 89)
                    {
                        totalCount++;
                        break;
                    }
                }
            }

            return totalCount;
        }
    }
}
