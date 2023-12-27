using Common;
using Common.ProducerConsumer;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge12
{
    public class Consumer : BaseConsumer<long>
    {
        static long biggestTriangle = 0;
        static long biggsetDivision = 0;

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
            long divisibles = TotalNumberOfDivisors(item);
            //if (divisibles > biggsetDivision)
            //{
            //    BaseConsumer<long>.mutex.WaitOne();
            //    biggsetDivision = divisibles;
            //    biggestTriangle = item;
            //    SafePrint.Print($"Current best: {biggsetDivision}, Triangle Value: {biggestTriangle}");
            //    BaseConsumer<long>.mutex.ReleaseMutex();
            //}

            if (divisibles > 500)
            {
                mutex.WaitOne();
                biggsetDivision = divisibles;
                biggestTriangle = item;
                return true;
                mutex.ReleaseMutex();
            }

            return false;
        }

        private long TotalNumberOfDivisors(long number)
        {
            var divisors = number.GetAllDivisorsExcludingSameNumber();
            return divisors.Count();

            long totalNumber = 0;
            for (long i = 1; i < number / 2 + 1; i++)
            {
                if (number % i == 0)
                {
                    totalNumber++;
                }
            }

            return totalNumber;
        }
    }
}
