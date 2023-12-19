﻿using Common;
using Common.Maps;
using Common.Maps.PathFinding;

namespace ChallengeExecutor.Challenges.Challenge18
{
    public class Challenge67 : Challenge18
    {
        protected override string GetMapPath()
        {
            return "Challenges/Challenge67/map.txt";
        }

        public override string GetName()
        {
            return "Challenge67";
        }

        protected override long SolveImplementation()
        {
            this.InitAStarImplementation();
            var bestWeight = this.aStarImplmentation.GetTotalWeight();
            return bestWeight;
        }
    }
}