namespace Common.Maps.PathFinding.AStar
{
    public abstract class AStarAlgorithm
    {
        protected readonly Map<WeightedNode> map;
        protected readonly Position startPosition;
        private readonly bool searchingHeaviest;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="map"></param>
        /// <param name="startPosition"></param>
        /// <param name="searchingHaviest">Sets if we search the slowest or fastest road</param>
        public AStarAlgorithm(Map<WeightedNode> map, Position startPosition, bool searchingHeaviest)
        {
            this.map = map;
            this.startPosition = startPosition;
            this.searchingHeaviest = searchingHeaviest;
        }

        protected abstract IEnumerable<WeightedNode> GetNextPossibleNodes(Position position);

        protected abstract bool IsEnd(Position position);

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
                if (possibleNode.IsCalculated)
                {
                    var newPotentialWeight = currentNode.CalculatedPathWeight + possibleNode.Weight;
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

                this.CalculateNextAndGo(possibleNode);
            }
        }
    }
}
