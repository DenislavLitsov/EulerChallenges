namespace Common.Maps.PathFinding
{
    public class WeightedNode : BaseNode
    {
        public WeightedNode(long weight, Position position) : base(position)
        {
            Weight = weight;
            this.CalculatedPathWeight = -1;
        }

        public long Weight { get; private set; }

        public long CalculatedPathWeight { get; set; }

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
