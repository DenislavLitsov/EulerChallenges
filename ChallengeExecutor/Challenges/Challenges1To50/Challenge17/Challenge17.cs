using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge17
{
    public class Challenge17 : BaseChallenge<int>
    {
        private Dictionary<int, string> nameTable;

        public Challenge17()
        {
            nameTable = new Dictionary<int, string>();
            nameTable.Add(1, "one");
            nameTable.Add(2, "two");
            nameTable.Add(3, "three");
            nameTable.Add(4, "four");
            nameTable.Add(5, "five");
            nameTable.Add(6, "six");
            nameTable.Add(7, "seven");
            nameTable.Add(8, "eight");
            nameTable.Add(9, "nine");
            nameTable.Add(10, "ten");
            nameTable.Add(11, "eleven");
            nameTable.Add(12, "twelve");
            nameTable.Add(13, "thirteen");
            nameTable.Add(14, "fourteen");
            nameTable.Add(15, "fifteen");
            nameTable.Add(16, "sixteen");
            nameTable.Add(17, "seventeen");
            nameTable.Add(18, "eighteen");
            nameTable.Add(19, "nineteen");
            nameTable.Add(20, "twenty");
            nameTable.Add(30, "thirty");
            nameTable.Add(40, "forty");
            nameTable.Add(50, "fifty");
            nameTable.Add(60, "sixty");
            nameTable.Add(70, "seventy");
            nameTable.Add(80, "eighty");
            nameTable.Add(90, "ninety");
            nameTable.Add(100, "hundred");
            nameTable.Add(1000, "onethousand");
        }

        protected override int SolveImplementation()
        {
            int totalCharCount = 0;
            for (int i = 1; i <= 1000; i++)
            {
                int charCount = GetCharCount(i);
                totalCharCount += charCount;
            }

            return totalCharCount;
        }

        private int GetCharCount(int num)
        {
            var numAsWords = GetWords(num).Replace(" ", "");
            Console.WriteLine($"Num {num} as String: {numAsWords}, count: {numAsWords.Length}");
            return numAsWords.Length;
        }

        private string GetWords(int num)
        {
            string res = "";

            if (num < 10)
            {
                return nameTable[num];
            }
            else if (num <= 20)
            {
                return nameTable[num];
            }
            else if (num < 100)
            {
                int wholeNum = num / 10 * 10;
                res += nameTable[wholeNum];

                if (num % 10 != 0)
                {
                    int small = num - wholeNum;
                    res += nameTable[small];
                }

                return res;
            }
            else if (num < 1000)
            {
                int wholeNumHundred = num / 100;
                res += nameTable[wholeNumHundred] + nameTable[100];

                if (num % 100 != 0)
                {
                    res += "and";
                    var smaller = GetWords(num - wholeNumHundred * 100);
                    res += smaller;
                }

                return res;
            }
            else if (num == 1000)
            {
                return nameTable[1000];
            }
            else
            {
                throw new NotImplementedException();
            }

            throw new NotImplementedException("RETURN IN THE IF NOT HERE");
        }
    }
}
