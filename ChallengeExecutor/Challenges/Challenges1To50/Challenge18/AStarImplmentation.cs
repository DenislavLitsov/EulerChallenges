using Common.Maps;
using Common.Maps.PathFinding;
using Common.Maps.PathFinding.AStar;
using Common.Maps.PathFinding.AStar.Directions;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge18
{
    public class AStarImplmentation : AStarAlgorithm
    {
        public AStarImplmentation(Map<WeightedNode> map) : base(map, new Position { X = 0, Y = 0 }, true,
            new IDirection[] { new DownDirection(), new DiagonalDownRight()})
        {
        }

        public long GetTotalWeight()
        {
            CalculateWeights();

            List<WeightedNode> nodes = new List<WeightedNode>();
            int maxY = map.GetMaxY();
            var bottomRow = map.GetRow(maxY);

            var maxWeight = bottomRow.Max(x => x.CalculatedPathWeight);
            return maxWeight;
        }

        protected override bool IsEnd(Position position)
        {
            return position.Y == this.map.GetMaxY();
        }
    }
}
