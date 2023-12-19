using Common;

namespace ChallengeExecutor.Challenges.Challenge21
{
    public class Challenge21 : BaseChallenge<long>
    {
        public override string GetName()
        {
            return "Challenge21";
        }

        protected override long SolveImplementation()
        {
            long result = 0;
            for (int a = 1; a < 10000; a++)
            {
                var da = a.GetAllDivisorsExcludingSameNumber().Sum();
                if (da != a)
                {
                    var db = da.GetAllDivisorsExcludingSameNumber().Sum();
                    if (db == a)
                    {
                        result += a;
                    }
                }
            }

            return result;
        }
    }
}
