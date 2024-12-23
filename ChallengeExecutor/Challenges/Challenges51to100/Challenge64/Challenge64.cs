﻿using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.Exceptions;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge64
{
    public class Challenge64 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            const int maxPeriod = 10000;
            PeriodicSqareRootChainGenerator periodicSqareRootChainGenerator = new PeriodicSqareRootChainGenerator(23);

            periodicSqareRootChainGenerator.GenerateAmount(10000);


            var chain = new string(periodicSqareRootChainGenerator.Chain
                .Select(x => ((int)x).ToString()[0])
                .ToArray());

            Console.WriteLine();
            Console.WriteLine(chain);
            Console.WriteLine();

            return -1;
        }
    }
}