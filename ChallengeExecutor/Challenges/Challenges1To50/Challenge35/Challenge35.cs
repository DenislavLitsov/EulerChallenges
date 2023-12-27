using ChallengeExecutor.Challenges.Abstractions;
using Common;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge35
{
    public class Challenge35 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge35";
        }

        protected override int SolveImplementation()
        {
            List<int> result = new List<int>();

            for (int currNumber = 2; currNumber < 1000000; currNumber++)
            {
                string numberAsString = currNumber.ToString();
                bool shouldAdd = true;

                do
                {
                    if (!int.Parse(numberAsString).IsPrime())
                    {
                        shouldAdd = false;
                        break;
                    }

                    numberAsString = GetNextRotation(numberAsString);
                } while (numberAsString != currNumber.ToString());

                if (shouldAdd)
                    result.Add(currNumber);
            }

            result.Print();
            return result.Count;
        }

        private string GetNextRotation(string number)
        {
            string result = "";
            do
            {
                if (number.Length > 1)
                {
                    result += number[1];
                    number = number.Remove(1, 1);
                }
                else
                {
                    result += number;
                    number = string.Empty;
                }
            } while (number.Length > 0);

            return result;
        }
    }
}
