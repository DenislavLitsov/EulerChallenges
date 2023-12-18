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

        public void Solve()
        {
            this.stopwatch = Stopwatch.StartNew();
            var res = this.SolveImplementation();
            stopwatch.Stop();

            this.Answer = res;

            Console.WriteLine($"Answer: {this.Answer.ToString()}. Solved for: {stopwatch.ElapsedMilliseconds}ms");
        }

        protected long GetTotalElapsedMiliseconds()
        {
            return this.stopwatch.ElapsedMilliseconds;
        }

        protected abstract T SolveImplementation();
    }
}
