using Common;
using System.Diagnostics;

namespace ChallengeExecutor.Challenges.Abstractions
{
    public abstract class BaseChallenge<T>
    {
        private Stopwatch stopwatch;
        public BaseChallenge()
        {
        }

        public T Answer { get; private set; }

        public string GetName()
        {
            return this.GetType().Name;
        }

        public T Solve()
        {
            Setup();

            stopwatch = Stopwatch.StartNew();
            var res = SolveImplementation();
            stopwatch.Stop();

            Answer = res;

            Console.WriteLine($"Challenge: {GetName()}, Answer: {Answer.ToString()}. Solved for: {stopwatch.ElapsedMilliseconds}ms");
            return Answer;
        }

        protected long GetTotalElapsedMiliseconds()
        {
            return stopwatch.ElapsedMilliseconds;
        }

        protected abstract T SolveImplementation();

        protected virtual void Setup()
        {
        }
    }
}
