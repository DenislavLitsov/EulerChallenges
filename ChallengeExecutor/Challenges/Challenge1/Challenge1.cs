using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenge1
{
    public class Challenge1 : BaseChallenge<int>
    {
        private int[] possibleMultiples = new int[] { 3, 5 };
        private List<int> foundNumbers = new List<int>();
        public Challenge1()
        {
        }

        public override string GetName()
        {
            return "Challenge1";
        }

        protected override int SolveImplementation()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % possibleMultiples[0] == 0 || i % possibleMultiples[1] == 0)
                {
                    foundNumbers.Add(i);
                }
            }

            return foundNumbers.Sum();
        }
    }
}
