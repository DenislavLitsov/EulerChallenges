using Common;
using System.Diagnostics;

namespace ChallengeExecutor.Challenges
{
    public abstract class BaseChallenge<T>
    {
        private Stopwatch stopwatch;
        public BaseChallenge()
        {
        }

        public T Answer { get; private set; }

        public abstract string GetName();

        public T Solve()
        {
            this.Setup();

            this.stopwatch = Stopwatch.StartNew();
            var res = this.SolveImplementation();
            stopwatch.Stop();

            this.Answer = res;

            Console.WriteLine($"Challenge: {this.GetName()}, Answer: {this.Answer.ToString()}. Solved for: {stopwatch.ElapsedMilliseconds}ms");
            return this.Answer;
        }

        protected long GetTotalElapsedMiliseconds()
        {
            return this.stopwatch.ElapsedMilliseconds;
        }

        protected abstract T SolveImplementation();

        protected virtual void Setup()
        {
        }
    }
}
