using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences
{
    public class OctagonalSequnceGenerator : BaseSequenceGenerator
    {
        public override long CalculateNumberAtExactIndex(int index)
        {
            this.AssertMaxSequenceIndex(index);
            long res = (long)index * ((long)3 * (long)index - (long)2);
            return res;
        }

        public override int GetMaximaValidIndex()
        {
            return 1753413056;
        }
    }
}
