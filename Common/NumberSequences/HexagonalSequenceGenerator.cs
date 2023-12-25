using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences
{
    public class HexagonalSequenceGenerator : BaseSequenceGenerator
    {
        public override int GetNumberAtExactIndex(int index)
        {
            int result = index * (2 * index - 1);
            return result;
        }
    }
}
