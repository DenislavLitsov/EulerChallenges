using ChallengeExecutor.Challenges.Abstractions;
using ChallengeExecutor.Challenges.Challenges1To50.Challenge10;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge10
{
    public class Challenge10 : BaseChallenge<long>
    {
        protected override long SolveImplementation()
        {
            var producer = new Producer();
            List<Thread> threads = new List<Thread>();
            List<Consumer> consumers = new List<Consumer>();
            for (int i = 0; i < 7; i++)
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

            return Consumer.Primes.Sum();
        }
    }
}
