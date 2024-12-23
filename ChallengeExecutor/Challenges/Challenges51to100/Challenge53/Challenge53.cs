﻿using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;
using System.Numerics;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge53
{
    public class Challenge53 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            int result = 0;
            for (int n = 1; n <= 100; n++)
            {
                for (int r = 1; r <= n; r++)
                {
                    BigInteger combinationResult = AdvancedMath.GetBigCombination(n, r);
                    if (combinationResult > Constants.OneMilion)
                        result++;
                }
            }

            return result;
        }
    }
}
