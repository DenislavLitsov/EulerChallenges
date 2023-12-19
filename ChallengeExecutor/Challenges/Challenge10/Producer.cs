using Common.ProducerConsumer;

namespace ChallengeExecutor.Challenges.Challenge10
{
    public class Producer : BaseProducer<long>
    {
        private long i = 1;
        protected override long GenerateNext()
        {
            this.i++;
            return this.i;
        }
    }
}
