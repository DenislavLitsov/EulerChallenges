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

        protected override void AssertMaxSequenceIndex(int index)
        {
            if (index > Constants.MaximalPentagonalIndex)
            {
                throw new OverflowException($"Integer overflow at index: {index}");
            }
        }
    }
}