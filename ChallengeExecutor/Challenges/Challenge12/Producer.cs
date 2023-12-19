using Common.ProducerConsumer;

namespace ChallengeExecutor.Challenges.Challenge12
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
            this.Iteration++;
            this.TriangleNumber += Iteration;

            if (this.Iteration % 500 == 0)
            {
                SafePrint.Print(this.Iteration.ToString());
            }

            return TriangleNumber;
        }
    }
}
