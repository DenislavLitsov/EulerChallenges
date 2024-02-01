using Common.NumberSequences.Abstractions;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge92
{
    internal class SquareDigitSequenceGenerator
    {
        private readonly int startingNumber;
        private int currNumber;

        public SquareDigitSequenceGenerator(int startingNumber)
        {
            this.startingNumber = startingNumber;
            this.currNumber = startingNumber;
        }

        public int GetNext()
        {
            var numberAsString = currNumber.ToString();
            int newNum = 0;
            foreach (var digit in numberAsString)
            {
                int parsedDigit = int.Parse(digit.ToString());
                newNum += parsedDigit * parsedDigit;
            }

            this.currNumber = newNum;
            return newNum;
        }
    }
}
