using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Maps.PathFinding.AStar.Directions
{
    public interface IDirection
    {
        WeightedNode GetNextPossibleWightedNode(Position currPosition, Map<WeightedNode> map);
    }
}
