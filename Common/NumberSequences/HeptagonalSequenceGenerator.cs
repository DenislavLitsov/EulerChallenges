using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences
{
    public class HeptagonalSequenceGenerator : BaseSequenceGenerator
    {
        public override long CalculateNumberAtExactIndex(int index)
        {
            this.AssertMaxSequenceIndex(index);
            long index2 = index;
            long result = (index2 * ((long)5 * index2 - (long)3)) / (long)2;
            return result;
        }

        public override int GetMaximaValidIndex()
        {
            return 1358187913;
        }
    }
}