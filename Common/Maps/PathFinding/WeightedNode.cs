namespace Common.Maps.PathFinding
{
    public class WeightedNode : BaseNode
    {
        public WeightedNode(int weight, Position position) : base(position)
        {
            Weight = weight;
            this.CalculatedPathWeight = -1;
        }

        public int Weight { get; private set; }

        public int CalculatedPathWeight { get; set; }

        public bool IsCalculated
        {
            get
            {
                if (this.CalculatedPathWeight == -1)
                {
                    return false;
                }

                return true;
            }
        }
    }
}
