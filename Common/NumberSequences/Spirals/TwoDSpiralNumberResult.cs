namespace Common.NumberSequences.Spirals
{
    public class TwoDSpiralNumberResult
    {
        public TwoDSpiralNumberResult(long value, bool isAtAngle)
        {
            this.Value = value;
            this.IsAtAngle = isAtAngle;
        }

        public long Value { get; private set; }

        public bool IsAtAngle { get; private set; }
    }
}
