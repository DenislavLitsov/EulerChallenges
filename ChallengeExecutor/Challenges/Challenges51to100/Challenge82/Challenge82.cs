using ChallengeExecutor.Challenges.Abstractions;
using ChallengeExecutor.Challenges.Challenges51to100.Challenge81;
using Common.Maps.PathFinding;
using Common.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge82
{
    public class Challenge82 : FileReadingChallenge<long>
    {
        private IEnumerable<string> cachedFile;
        private PathFinding82 pathFinding;

        protected override string GetFilePath()
        {
            return @"Challenges\Challenges51to100\Challenge82\FullMatrix.txt";
        }

        protected override void Setup()
        {
            this.cachedFile = this.ReadFile();
        }

        protected override long SolveImplementation()
        {
            var yCount = 80;
            long best = long.MaxValue;

            var map = this.LoadMap();
            for (int y = 0; y < yCount; y++)
            {
                this.pathFinding = new PathFinding82(map, new Position() { X = 0, Y = y }, best);
                var weight = this.pathFinding.GetFastestWeight();
                if (best > weight)
                {
                    best = weight;
                }
            }

            return best;
        }

        private Map<WeightedNode> LoadMap()
        {
            var map = new Map<WeightedNode>();
            int y = 0;
            int x = 0;
            foreach (var row in this.cachedFile)
            {
                map.AddNewRow();
                var splited = row.Split(',');
                foreach (var node in splited)
                {
                    var weight = int.Parse(node);
                    var currNode = new WeightedNode(weight, new Position() { X = x, Y = y });
                    map.AddNewNodeToRow(currNode, y);
                    x++;
                }

                y++;
                x = 0;
            }

            return map;
        }
    }
}
