using ChallengeExecutor.Challenges.Abstractions;
using Common;

namespace ChallengeExecutor.Challenges.Challenge43
{
    public class Challenge43 : BaseChallenge<long>
    {
        List<string> list1;
        List<string> list2;
        List<string> list3;
        List<string> list4;
        List<string> list5;
        List<string> list6;
        List<string> list7;

        public override string GetName()
        {
            return "Challenge43";
        }

        protected override void Setup()
        {
            this.list1 = new List<string>();
            this.list2 = new List<string>();
            this.list3 = new List<string>();
            this.list4 = new List<string>();
            this.list5 = new List<string>();
            this.list6 = new List<string>();
            this.list7 = new List<string>();

            this.FillList(this.list1, 2);
            this.FillList(this.list2, 3);
            this.FillList(this.list3, 5);
            this.FillList(this.list4, 7);
            this.FillList(this.list5, 11);
            this.FillList(this.list6, 13);
            this.FillList(this.list7, 17);
        }

        private void FillList(List<string> list, long multiplier)
        {
            for (int i = 1; i < 100; i++)
            {
                string currNumAsString = (i * multiplier).ToString();
                if (currNumAsString.Length == 3)
                {
                    list.Add(currNumAsString);
                }
                else if (currNumAsString.Length == 2)
                {
                    list.Add("0" + currNumAsString);
                }
                else if (currNumAsString.Length == 1)
                {
                    list.Add("00" + currNumAsString);
                }
                else if (currNumAsString.Length > 3)
                {
                    return;
                }
            }
        }

        protected override long SolveImplementation()
        {
            long result = 0;
            for (long currNumber = 1023456789; currNumber < 10000000000; currNumber++)
            {
                if (!currNumber.IsPandigital())
                    continue;

                string numberAsString = currNumber.ToString();

                if (int.Parse(numberAsString.Substring(1, 3)) % 2 == 0 &&
                    int.Parse(numberAsString.Substring(2, 3)) % 3 == 0 &&
                    int.Parse(numberAsString.Substring(3, 3)) % 5 == 0 &&
                    int.Parse(numberAsString.Substring(4, 3)) % 7 == 0 &&
                    int.Parse(numberAsString.Substring(5, 3)) % 11 == 0 &&
                    int.Parse(numberAsString.Substring(6, 3)) % 13 == 0 &&
                    int.Parse(numberAsString.Substring(7, 3)) % 17 == 0)
                {
                    result += currNumber;
                    Console.WriteLine(currNumber);
                }
            }

            return result;
        }
    }
}
