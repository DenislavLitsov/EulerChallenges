namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge68
{
    internal class MagicFiveGonRing
    {
        private readonly int[] nodeValues;

        public MagicFiveGonRing(int[] nodeValues)
        {
            if (nodeValues.Length != 10)
            {
                throw new ArrayTypeMismatchException("Array is not right size");
            }

            this.nodeValues = nodeValues;
        }

        public bool IsMagicRing()
        {
            int number1 = this.nodeValues[0] + this.nodeValues[1] + this.nodeValues[7];
            int number2 = this.nodeValues[1] + this.nodeValues[2] + this.nodeValues[8];
            int number3 = this.nodeValues[2] + this.nodeValues[3] + this.nodeValues[9];
            int number4 = this.nodeValues[3] + this.nodeValues[4] + this.nodeValues[5];
            int number5 = this.nodeValues[4] + this.nodeValues[0] + this.nodeValues[6];

            List<int> numbers = new List<int>();
            numbers.Add(number1);
            numbers.Add(number2);
            numbers.Add(number3);
            numbers.Add(number4);
            numbers.Add(number5);

            if (numbers.Distinct().Count() != 1)
            {
                return false;
            }

            return true;
        }
    }
}
