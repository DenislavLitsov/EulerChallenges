using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences
{
    public class PentagonalSequenceGenerator : BaseSequenceGenerator
    {
        public override int GetNumberAtExactIndex(int index)
        {
            int result = index * (3 * index - 1) / 2;
            return result;
        }
    }
}
