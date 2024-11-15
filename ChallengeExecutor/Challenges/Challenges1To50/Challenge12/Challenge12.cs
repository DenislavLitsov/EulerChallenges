﻿using ChallengeExecutor.Challenges.Abstractions;
using ChallengeExecutor.Challenges.Challenges1To50.Challenge12;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge12
{
    public class Challenge12 : BaseChallenge<long>
    {
        protected override long SolveImplementation()
        {
            var producer = new Producer();
            List<Thread> threads = new List<Thread>();
            List<Consumer> consumers = new List<Consumer>();
            for (int i = 0; i < 8; i++)
            {
                var consumer = new Consumer(producer);
                consumers.Add(consumer);
                Thread thread = new Thread(consumer.Start);
                threads.Add(thread);
                thread.Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            return Consumer.Answer;
        }
    }
}
