using Common.Maps;
using Common.Maps.PathFinding;
using Common.Maps.PathFinding.AStar;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge18
{
    public class AStarImplmentation : AStarAlgorithm
    {
        public AStarImplmentation(Map<WeightedNode> map) : base(map, new Position { X = 0, Y = 0 }, true)
        {
        }

        public int GetTotalWeight()
        {
            CalculateWeights();

            List<WeightedNode> nodes = new List<WeightedNode>();
            int maxY = map.GetMaxY();
            var bottomRow = map.GetRow(maxY);

            var maxWeight = bottomRow.Max(x => x.CalculatedPathWeight);
            return maxWeight;
        }

        protected override IEnumerable<WeightedNode> GetNextPossibleNodes(Position position)
        {
            if (position.Y == map.GetMaxY())
            {
                return null;
            }

            var node1 = map.GetNode(position.X, position.Y + 1);
            var node2 = map.GetNode(position.X + 1, position.Y + 1);

            List<WeightedNode> nodes = new List<WeightedNode>();
            nodes.Add(node1);
            nodes.Add(node2);

            return nodes;
        }

        protected override bool IsEnd(Position position)
        {
            if (position.Y == map.GetMaxY())
            {
                return true;
            }

            return false;
        }
    }
}
