﻿using Common.ProducerConsumer;

namespace ChallengeExecutor.Challenges.Challenge12
{
    public class Consumer : BaseConsumer<long>
    {
        static long biggestTriangle = 0;
        static long biggsetDivision= 0;

        public Consumer(BaseProducer<long> producer) : base(producer)
        {
        }

        protected override bool Test(long item)
        {
            long divisibles = this.TotalNumberOfDivisors(item);
            if (divisibles > biggsetDivision)
            {
                BaseConsumer<long>.mutex.WaitOne();
                biggsetDivision = divisibles;
                biggestTriangle = item;
                SafePrint.Print($"Current best: {biggsetDivision}, Triangle Value: {biggestTriangle}");
                BaseConsumer<long>.mutex.ReleaseMutex();
            }

            if (divisibles > 500)
            {
                BaseConsumer<long>.mutex.WaitOne();
                return true;
                BaseConsumer<long>.mutex.ReleaseMutex();
            }

            return false;
        }

        private long TotalNumberOfDivisors(long number)
        {
            long totalNumber = 0;
            for (long i = 1; i < (number / 2) + 1; i++)
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
