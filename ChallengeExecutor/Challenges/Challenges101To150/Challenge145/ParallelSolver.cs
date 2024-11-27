using Common.MultiThreading.RuleMultithreading;
using Common.ProducerConsumer;

namespace ChallengeExecutor.Challenges.Challenges101To150.Challenge145
{
    public class ParallelSolver : Common.MultiThreading.RuleMultithreading.BaseConsumer<long>
    {
        public ParallelSolver(IRuleEnumarator<long> ruleEnumarator) : base(ruleEnumarator)
        {
            this.FoundCount = 0;
        }

        public long FoundCount { get; private set; }
        
        protected override void Test(long item)
        {
            if (item % 1000000 == 0)
            {
                SafePrint.Print(item.ToString());
            }

            if (item % 10 == 0)
                return;

            var reverse = Reverse(item);

            if (reverse < item)
            {
                return;
            }
                
            long sum = reverse + item;
            if (IsOnlyOdds(sum))
            {
                this.FoundCount++;
            }
        }
        
        private long Reverse(long toReverse)
        {
            return long.Parse(new string(toReverse.ToString().Reverse().ToArray()));   
        }

        private bool IsOnlyOdds(long number)
        {
            do
            {
                if (number % 2 == 0)
                {
                    return false;
                }

                number /= 10;
            } while (number > 0);

            return true;
        }
    }
}