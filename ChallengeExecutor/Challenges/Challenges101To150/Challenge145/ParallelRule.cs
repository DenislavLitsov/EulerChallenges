using Common.MultiThreading.RuleMultithreading;

namespace ChallengeExecutor.Challenges.Challenges101To150.Challenge145
{
    public class ParallelRule : IRuleEnumarator<long>
    {
        private readonly long _start;
        private readonly long _end;

        private long _currentIndex;

        public ParallelRule(long start, long end)
        {
            _start = start;
            _end = end;
            _currentIndex = start - 1;
        }

        public bool ShouldContinue()
        {
            return _currentIndex <= _end;
        }

        public long GetNext()
        {
            _currentIndex++;
            return _currentIndex;
        }
    }
}