using Common;
using Common.ProducerConsumer;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge10
{
    public class Consumer : BaseConsumer<long>
    {
        public static List<long> Primes = new List<long>();

        public Consumer(BaseProducer<long> producer) : base(producer)
        {
        }

        protected override void NullAnswers()
        {
            Solved = false;
            Answer = 0;
        }

        protected override bool Test(long item)
        {
            if (2000000 <= item)
            {
                return true;
            }

            if (item.IsPrime())
            {
                mutex.WaitOne();
                Primes.Add(item);
                mutex.ReleaseMutex();
                if (Primes.Count % 1000 == 0)
                {
                    SafePrint.Print(item.ToString());
                }
            }

            return false;
        }
    }
}
