﻿using ChallengeExecutor.Challenges.Abstractions;
using Common;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge36
{
    public class Challenge36 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            int totalSum = 0;

            for (int i = 1; i < 1000000; i++)
            {
                string mainNumber = i.ToString();
                string toCheck = new string(mainNumber.Reverse().ToArray());
                if (mainNumber != toCheck)
                    continue;

                string zeroNumber = Convert.ToString(i, 2);
                toCheck = new string(zeroNumber.Reverse().ToArray());
                if (zeroNumber.Last() == '0')
                    continue;

                if (zeroNumber != toCheck)
                    continue;

                totalSum += i;
            }

            return totalSum;
        }
    }
}
