namespace ChallengeExecutor.Challenges.Challenge19
{
    public class Challenge19 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge19";
        }

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
