using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences
{
    public class HexagonalSequenceGenerator : BaseSequenceGenerator
    {
        public override int CalculateNumberAtExactIndex(int index)
        {
            this.AssertMaxSequenceIndex(index);
            int result = index * (2 * index - 1);

            return result;
        }

        public override int GetMaximaValidIndex()
        {
            return 32768;
        }
    }
}
