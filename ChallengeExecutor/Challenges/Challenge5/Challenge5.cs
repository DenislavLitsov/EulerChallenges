namespace ChallengeExecutor.Challenges.Challenge5
{
    public class Challenge5 : BaseChallenge<long>
    {
        public Challenge5()
        {
        }

        public override string GetName()
        {
            return "Challenge5";
        }

        protected override long SolveImplementation()
        {
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (IsRight(i))
                {
                    return i;
                }
            }
            throw new Exception("NOT FOUND!");
        }
        private bool IsRight(int x)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (x % i != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
