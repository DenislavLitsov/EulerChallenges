using Common.Maps;
using Common.Maps.PathFinding;
using Common.Maps.PathFinding.AStar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeExecutor.Challenges.Challenge18
{
    public class AStarImplmentation : AStarAlgorithm
    {
        public AStarImplmentation(Map<WeightedNode> map) : base(map, new Position { X = 0, Y = 0 }, true)
        {
        }

        public int GetTotalWeight()
        {
            this.CalculateWeights();

            List<WeightedNode> nodes = new List<WeightedNode>();
            int maxY = this.map.GetMaxY();
            var bottomRow = this.map.GetRow(maxY);

            var maxWeight = bottomRow.Max(x => x.CalculatedPathWeight);
            return maxWeight;
        }

        protected override IEnumerable<WeightedNode> GetNextPossibleNodes(Position position)
        {
            if (position.Y == this.map.GetMaxY())
            {
                return null;
            }

            var node1 = this.map.GetNode(position.X, position.Y + 1);
            var node2 = this.map.GetNode(position.X + 1, position.Y + 1);

            List<WeightedNode> nodes = new List<WeightedNode>();
            nodes.Add(node1);
            nodes.Add(node2);

            return nodes;
        }

        protected override bool IsEnd(Position position)
        {
            if (position.Y == this.map.GetMaxY())
            {
                return true;
            }

            return false;
        }
    }
}
