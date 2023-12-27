using Common.ProducerConsumer;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge10
{
    public class Producer : BaseProducer<long>
    {
        private long i = 1;
        protected override long GenerateNext()
        {
            i++;
            return i;
        }
    }
}
