namespace Common.Maps.PathFinding.AStar.Directions
{
    public class DownDirection : IDirection
    {
        public WeightedNode GetNextPossibleWightedNode(Position currPosition, Map<WeightedNode> map)
        {
            var newPosition = new Position() { X = currPosition.X, Y = currPosition.Y + 1 };
            if (map.AssertPositin(newPosition) == false)
                return null;

            var result = map.GetRow((int)newPosition.Y)[(int)newPosition.X];
            return result;
        }
    }
}
