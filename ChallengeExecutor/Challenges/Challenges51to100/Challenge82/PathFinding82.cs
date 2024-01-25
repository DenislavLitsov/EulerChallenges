using Common.Maps;
using Common.Maps.PathFinding;
using Common.Maps.PathFinding.AStar;
using Common.Maps.PathFinding.AStar.Directions;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge81
{
    internal class PathFinding82 : AStarAlgorithm
    {
        public PathFinding82(Map<WeightedNode> map, Position startPosition, long startingMinValue)
            : base(map, startPosition, false, new IDirection[] { new RightDirection(), new DownDirection(), new UpDirection() })
        {
            this.bestFoundPathSum = startingMinValue;
        }

        public long GetFastestWeight()
        {
            this.CalculateWeights();

            return this.bestFoundPathSum;
        }

        protected override bool IsEnd(Position position)
        {
            if (this.map.GetMaxXAtY((int)position.Y) == position.X)
            {
                return true;
            }

            return false;
        }
    }
}
