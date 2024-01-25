using Common.Maps.PathFinding.AStar.Directions;

namespace Common.Maps.PathFinding.AStar
{
    public abstract class AStarAlgorithm
    {
        public readonly Map<WeightedNode> map;
        protected readonly Position startPosition;
        protected long bestFoundPathSum = -1;

        private readonly bool searchingHeaviest;
        private readonly IDirection[] directions;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="map"></param>
        /// <param name="startPosition"></param>
        /// <param name="searchingHaviest">Sets if we search the slowest or fastest road</param>
        public AStarAlgorithm(Map<WeightedNode> map, Position startPosition, bool searchingHeaviest, IDirection[] directions)
        {
            this.map = map;
            this.startPosition = startPosition;
            this.searchingHeaviest = searchingHeaviest;
            this.directions = directions;
        }

        public int GetMapHeight()
        {
            return this.map.GetMaxY() + 1;
        }

        public int GetMapWidthAtY(int y)
        {
            return this.map.GetMaxXAtY(y) + 1;
        }

        protected abstract bool IsEnd(Position position);

        protected IEnumerable<WeightedNode> GetNextPossibleNodes(Position currPosition)
        {
            List<WeightedNode> nodes = new List<WeightedNode>();
            foreach (var direction in this.directions)
            {
                var node = direction.GetNextPossibleWightedNode(currPosition, this.map);
                if (node == null)
                    continue;

                //Console.WriteLine($"X: {node.Position.X} Y: {node.Position.Y}");
                nodes.Add(node);
            }

            return nodes;
        }

        protected void CalculateWeights()
        {
            var initNode = this.map.GetNode(this.startPosition);
            initNode.CalculatedPathWeight = initNode.Weight;

            this.CalculateNextAndGo(initNode);
        }

        private void CalculateNextAndGo(WeightedNode currentNode)
        {
            var possibleNodes = this.GetNextPossibleNodes(currentNode.Position);
            if (possibleNodes == null)
                return;

            foreach (var possibleNode in possibleNodes)
            {
                var newPotentialWeight = currentNode.CalculatedPathWeight + possibleNode.Weight;
                if (possibleNode.IsCalculated)
                {
                    if (this.searchingHeaviest)
                    {
                        if (newPotentialWeight > possibleNode.CalculatedPathWeight)
                        {
                            possibleNode.CalculatedPathWeight = newPotentialWeight;
                        }
                        else if (newPotentialWeight == possibleNode.CalculatedPathWeight)
                        {

                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (newPotentialWeight < possibleNode.CalculatedPathWeight)
                        {
                            possibleNode.CalculatedPathWeight = newPotentialWeight;
                        }
                        else if (newPotentialWeight == possibleNode.CalculatedPathWeight)
                        {

                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else
                {
                    possibleNode.CalculatedPathWeight = currentNode.CalculatedPathWeight + possibleNode.Weight;
                }

                if (this.IsEnd(possibleNode.Position))
                {
                    if (this.bestFoundPathSum == -1)
                        this.bestFoundPathSum = possibleNode.CalculatedPathWeight;
                    else
                    {
                        if (this.searchingHeaviest && this.bestFoundPathSum < possibleNode.CalculatedPathWeight)
                        {
                            this.bestFoundPathSum = possibleNode.CalculatedPathWeight;
                        }
                        else if(!this.searchingHeaviest && this.bestFoundPathSum > possibleNode.CalculatedPathWeight)
                        {
                            this.bestFoundPathSum = possibleNode.CalculatedPathWeight;
                        }
                    }
                }

                if (!this.searchingHeaviest && this.bestFoundPathSum != -1
                    && newPotentialWeight > this.bestFoundPathSum)
                {
                    continue;
                }
                this.CalculateNextAndGo(possibleNode);
            }
        }
    }
}
