using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences
{
    public class SquareSequenceGenerator : BaseSequenceGenerator
    {
        public override long CalculateNumberAtExactIndex(int index)
        {
            return (long)index * (long)index;
        }

        public override int GetMaximaValidIndex()
        {
            return int.MaxValue - 1;
        }
    }
}
