using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences
{
    public class TriangleSequenceGenerator : BaseSequenceGenerator
    {
        public override int CalculateNumberAtExactIndex(int index)
        {
            this.AssertMaxSequenceIndex(index);
            int result = index * (index + 1) / 2;

            return result;
        }

        protected override void AssertMaxSequenceIndex(int index)
        {
            if (index > Constants.MaximalTriangleIndex)
            {
                throw new OverflowException($"Integer overflow at index: {index}");
            }
        }
    }
}
