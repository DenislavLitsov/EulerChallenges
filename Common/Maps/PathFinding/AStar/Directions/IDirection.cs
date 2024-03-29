namespace Common.Maps.PathFinding.AStar.Directions
{
    public interface IDirection
    {
        WeightedNode GetNextPossibleWightedNode(Position currPosition, Map<WeightedNode> map);
    }
}
