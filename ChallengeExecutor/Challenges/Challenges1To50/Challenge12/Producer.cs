using Common.ProducerConsumer;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge12
{
    public class Producer : BaseProducer<long>
    {
        private long TriangleNumber = 1;
        private long Iteration = 1;

        public Producer()
        {
        }

        protected override long GenerateNext()
        {
            Iteration++;
            TriangleNumber += Iteration;

            if (Iteration % 500 == 0)
            {
                SafePrint.Print(Iteration.ToString());
            }

            return TriangleNumber;
        }
    }
}
