using Common.Maps;
using Common.Maps.PathFinding;
using Common.Maps.PathFinding.AStar;
using Common.Maps.PathFinding.AStar.Directions;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge81
{
    internal class PathFinding : AStarAlgorithm
    {
        public PathFinding(Map<WeightedNode> map, Position startPosition, bool searchingHeaviest) 
            : base(map, startPosition, searchingHeaviest, new IDirection[] { new DownDirection(), new RightDirection() })
        {
        }

        public long GetFastestWeight()
        {
            CalculateWeights();

            var node = this.map.GetRow(this.map.GetMaxY())[this.map.GetMaxXAtY(0)];
            return node.CalculatedPathWeight;
        }

        protected override bool IsEnd(Position position)
        {
            if (this.map.GetMaxY() == position.Y 
                && this.map.GetMaxXAtY((int)position.Y) == position.X)
            {
                return true;
            }

            return false;
        }
    }
}
