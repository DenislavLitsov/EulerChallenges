using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenges101To150.Challenge145
{
    public class Challenge145 : BaseChallenge<long>
    {
        protected override long SolveImplementation()
        {
            const long maxValue = 1000000000;
            //long maxValue = 1000;

            List<ParallelRule> rules = new List<ParallelRule>();
            List<ParallelSolver> solvers = new List<ParallelSolver>();


            const long ruleSize = 100000000;
            for (int i = 0; i < 10; i++)
            {
                rules.Add(new ParallelRule(i*ruleSize, ((i+1)*ruleSize) - 1));
                solvers.Add(new ParallelSolver(rules[i]));
            }

            List<Thread> threads = new List<Thread>();

            foreach (var solver in solvers)
            {
                Thread thread = new Thread(solver.Start);
                threads.Add(thread);
                thread.Start();   
            }
            
            foreach (var thread in threads)
            {
                thread.Join();
            }

            var sum = solvers.Sum(x => x.FoundCount);
            return sum * 2;
        }
    }
}