namespace Common.Maps.PathFinding.AStar
{
    public class Path
    {
        public Path(IEnumerable<WeightedNode> nodePath)
        {
            this.NodePath = nodePath;
        }

        private IEnumerable<WeightedNode> NodePath { get; set; }

        public long GetTotalSum()
        {
            var sum = this.NodePath.Sum(x => x.Weight);
            return sum;
        }

        public long GetTotalProduct()
        {
            long res = 1;
            var parsedPath = this.NodePath.ToList();
            for (int i = 0; i < parsedPath.Count; i++)
            {
                var node = parsedPath[i];
                res *= (long)node.Weight;
            }

            return res;
        }
    }
}
