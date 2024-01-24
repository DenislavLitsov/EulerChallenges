using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge19
{
    public class Challenge19 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            var date = new DateTime(1901, 1, 1);
            var maxDate = new DateTime(2000, 12, 31);

            int totalSundays = 0;
            while (date < maxDate)
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    totalSundays++;
                }

                date = date.AddMonths(1);
            }

            return totalSundays;
        }
    }
}
