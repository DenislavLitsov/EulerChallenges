using System.Text;
using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenge40
{
    public class Challenge40 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge40";
        }

        protected override int SolveImplementation()
        {
            var numberString = this.buildNumber();
            int d1 = int.Parse(numberString[1 - 1].ToString());
            int d2 = int.Parse(numberString[10 - 1].ToString());
            int d3 = int.Parse(numberString[100 - 1].ToString());
            int d4 = int.Parse(numberString[1000 - 1].ToString());
            int d5 = int.Parse(numberString[10000 - 1].ToString());
            int d6 = int.Parse(numberString[100000 - 1].ToString());
            int d7 = int.Parse(numberString[1000000 - 1].ToString());

            int result = d1 * d2 * d3 * d4 * d5 * d6 * d7;
            return result;
        }

        private string buildNumber()
        {
            StringBuilder sb = new StringBuilder();
            int totalLength = 0;
            int currIndex = 1;
            while (totalLength < 1000000)
            {
                string toAdd = currIndex.ToString();
                sb.Append(toAdd);

                totalLength += toAdd.Length;
                currIndex++;
            }

            return sb.ToString();
        }
    }
}
