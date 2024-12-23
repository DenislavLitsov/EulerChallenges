﻿using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;
using System.Runtime.CompilerServices;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge41
{
    public class Challenge41 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            int bestNumber = 0;
            int bestParts = 0;

            for (int i = 3; i < 1000000000; i += 2)
            {
                var iAsString = i.ToString();
                bool isPandigital = true;
                for (int j = 0; j < iAsString.Length; j++)
                {
                    if (iAsString.Contains(((char)(j + 49))) == false)
                    {
                        isPandigital = false;
                        break;
                    }
                }

                if (!isPandigital)
                    continue;

                bool isPrime = i.IsPrime();
                if (isPrime && bestNumber < i)
                {
                    bestNumber = i;
                    bestParts = iAsString.Length;
                }
            }

            return bestNumber;
        }
    }
}
