using ChallengeExecutor.Challenges.Challenges1To50.Challenge18;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge67
{
    public class Challenge67 : Challenge18
    {
        protected override string GetMapPath()
        {
            return "Challenges/Challenges51To100/Challenge67/map.txt";
        }

        protected override long SolveImplementation()
        {
            InitAStarImplementation();
            var bestWeight = aStarImplmentation.GetTotalWeight();
            return bestWeight;
        }
    }
}
