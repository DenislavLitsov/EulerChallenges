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
            if(this.nodeValues[9] > this.nodeValues[8] ||
                this.nodeValues[9] > this.nodeValues[7] ||
                this.nodeValues[9] > this.nodeValues[6] ||
                this.nodeValues[9] > this.nodeValues[5])
            {
                return false;
            }

            int number1 = this.nodeValues[9] + this.nodeValues[3] + this.nodeValues[2];
            int number2 = this.nodeValues[8] + this.nodeValues[2] + this.nodeValues[1];
            int number3 = this.nodeValues[7] + this.nodeValues[1] + this.nodeValues[0];
            int number4 = this.nodeValues[6] + this.nodeValues[0] + this.nodeValues[4];
            int number5 = this.nodeValues[5] + this.nodeValues[4] + this.nodeValues[3];

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

        public string GetConcentratedString()
        {
            string number1 = this.nodeValues[9].ToString() + this.nodeValues[3].ToString() + this.nodeValues[2].ToString();
            string number2 = this.nodeValues[8].ToString() + this.nodeValues[2].ToString() + this.nodeValues[1].ToString();
            string number3 = this.nodeValues[7].ToString() + this.nodeValues[1].ToString() + this.nodeValues[0].ToString();
            string number4 = this.nodeValues[6].ToString() + this.nodeValues[0].ToString() + this.nodeValues[4].ToString();
            string number5 = this.nodeValues[5].ToString() + this.nodeValues[4].ToString() + this.nodeValues[3].ToString();

            var res = number1 + number2 + number3 + number4 + number5;
            return res;
        }

        public long GetLineValue()
        {
            int number1 = this.nodeValues[9] + this.nodeValues[3] + this.nodeValues[2];
            return number1;
        }

        public long GetFirstValue()
        {
            return this.nodeValues[9];
        }
    }
}
