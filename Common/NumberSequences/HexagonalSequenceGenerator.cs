using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences
{
    public class HexagonalSequenceGenerator : BaseSequenceGenerator
    {
        public override long CalculateNumberAtExactIndex(int index)
        {
            this.AssertMaxSequenceIndex(index);
            long result = (long)index * (2 * (long)index - 1);

            return result;
        }

        public override int GetMaximaValidIndex()
        {
            // LIMIT IS: 2147483649 but List cannot support bigger than 2147483591;
            return 2147483591;
        }
    }
}
