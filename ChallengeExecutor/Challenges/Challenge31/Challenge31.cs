using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenge31
{
    public class Challenge31 : BaseChallenge<int>
    {
        private readonly int[] PossibleNumbers = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };

        public override string GetName()
        {
            return "Challenge31";
        }

        protected override int SolveImplementation()
        {
            var count = this.GetPossibleCount(200, 0);

            return count;
        }

        private int GetPossibleCount(int maxSize, int minNum)
        {
            int possibilities = 0;
            foreach (var num in PossibleNumbers)
            {
                if (num < minNum)
                {
                    continue;
                }

                int diff = maxSize - num;
                if (diff< 0)
                {
                    break;
                }
                else if (diff > 0)
                {
                    //possibilities++;
                    int toAdd = GetPossibleCount(diff, num);
                    possibilities += toAdd;
                }
                if (diff == 0)
                {
                    possibilities++;
                    break;
                }
            }

            return possibilities;
        }
    }
}
