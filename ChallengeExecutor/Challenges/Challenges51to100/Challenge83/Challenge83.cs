using ChallengeExecutor.Challenges.Abstractions;
using ChallengeExecutor.Challenges.Challenges51to100.Challenge81;
using Common.Maps.PathFinding;
using Common.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge83
{
    public class Challenge83 : FileReadingChallenge<long>
    {
        private PathFinding83 pathFinding;

        protected override string GetFilePath()
        {
            return @"Challenges\Challenges51to100\Challenge83\FullMatrix.txt";
        }

        protected override void Setup()
        {
            var file = this.ReadFile();
            var map = new Map<WeightedNode>();
            int y = 0;
            int x = 0;
            foreach (var row in file)
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

            this.pathFinding = new PathFinding83(map, new Position() { X = 0, Y = 0 });
        }
        protected override long SolveImplementation()
        {
            var smallest = this.pathFinding.GetFastestWeight();
            return smallest;
        }
    }
}
