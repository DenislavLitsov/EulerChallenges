﻿using ChallengeExecutor.Challenges.Abstractions;
using Common.Maps;
using Common.Maps.PathFinding;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge81
{
    public class Challenge81 : FileReadingChallenge<long>
    {
        private readonly bool fullVersion;

        private PathFinding pathFinding;

        public Challenge81(bool fullVersion)
        {
            this.fullVersion = fullVersion;
        }

        protected override string GetFilePath()
        {
            if (this.fullVersion)
                return @"Challenges\Challenges51to100\Challenge81\FullMatrix.txt";

            return @"Challenges\Challenges51to100\Challenge81\TestMatrix.txt";
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

            this.pathFinding = new PathFinding(map, new Position() { X = 0, Y = 0 }, false);
        }

        protected override long SolveImplementation()
        {
            var smallest = this.pathFinding.GetFastestWeight();
            return smallest;
        }
    }
}
