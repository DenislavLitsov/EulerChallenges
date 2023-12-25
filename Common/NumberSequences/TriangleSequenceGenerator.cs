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

        public override int GetMaximaValidIndex()
        {
            return 46340;
        }
    }
}
