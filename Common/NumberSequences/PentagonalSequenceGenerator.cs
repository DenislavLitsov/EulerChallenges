using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences
{
    public class PentagonalSequenceGenerator : BaseSequenceGenerator
    {
        public override int CalculateNumberAtExactIndex(int index)
        {
            this.AssertMaxSequenceIndex(index);
            int result = index * (3 * index - 1) / 2;

            return result;
        }

        public override int GetMaximaValidIndex()
        {
            return 26755;
        }
    }
}