using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge68
{
    internal class MagicThreeGonRing
    {
        private readonly int[] nodeValues;

        public MagicThreeGonRing(int[] nodeValues)
        {
            if (nodeValues.Length != 6)
            {
                throw new ArrayTypeMismatchException("Array is not right size");
            }

            this.nodeValues = nodeValues;
        }

        public bool IsMagicRing()
        {
            int number1 = this.nodeValues[0] + this.nodeValues[1] + this.nodeValues[2];
            int number2 = this.nodeValues[5] + this.nodeValues[2] + this.nodeValues[4];
            int number3 = this.nodeValues[3] + this.nodeValues[4] + this.nodeValues[1];

            List<int> numbers = new List<int>();
            numbers.Add(number1);
            numbers.Add(number2);
            numbers.Add(number3);

            if (numbers.Distinct().Count() != 1)
            {
                return false;
            }

            return true;
        }

        public string GetConcentratedString()
        {
            string number1 = this.nodeValues[0].ToString() + this.nodeValues[1].ToString() + this.nodeValues[2].ToString();
            string number2 = this.nodeValues[5].ToString() + this.nodeValues[2].ToString() + this.nodeValues[4].ToString();
            string number3 = this.nodeValues[3].ToString() + this.nodeValues[4].ToString() + this.nodeValues[1].ToString();

            var res = number1 + number2 + number3;
            return res;
        }

        public long GetLineValue()
        {
            int number1 = this.nodeValues[0] + this.nodeValues[1] + this.nodeValues[2];
            return number1;
        }

        public long GetFirstValue()
        {
            return this.nodeValues[0];
        }
    }
}
