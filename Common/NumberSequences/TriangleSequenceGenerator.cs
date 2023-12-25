using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences
{
    public class TriangleSequenceGenerator : BaseSequenceGenerator
    {
        public override long CalculateNumberAtExactIndex(int index)
        {
            this.AssertMaxSequenceIndex(index);
            long result = (long)index * ((long)index + 1) / 2;

            return result;
        }

        public override int GetMaximaValidIndex()
        {
            // Max index is: 3037000499 but List cannot support bigger than 2147483591
            return 2147483591;
        }
    }
}
