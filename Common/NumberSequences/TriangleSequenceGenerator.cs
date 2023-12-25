using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences
{
    public class TriangleSequenceGenerator : BaseSequenceGenerator
    {
        public override int GetNumberAtExactIndex(int index)
        {
            int result = index * (index + 1) / 2;
            return result;
        }
    }
}
