using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeExecutor.Challenges.Challenge17
{
    public class Challenge17 : BaseChallenge<int>
    {
        private Dictionary<int, string> nameTable;

        public Challenge17()
        {
            this.nameTable = new Dictionary<int, string>();
            this.nameTable.Add(1, "one");
            this.nameTable.Add(2, "two");
            this.nameTable.Add(3, "three");
            this.nameTable.Add(4, "four");
            this.nameTable.Add(5, "five");
            this.nameTable.Add(6, "six");
            this.nameTable.Add(7, "seven");
            this.nameTable.Add(8, "eight");
            this.nameTable.Add(9, "nine");
            this.nameTable.Add(10, "ten");
            this.nameTable.Add(11, "eleven");
            this.nameTable.Add(12, "twelve");
            this.nameTable.Add(13, "thirteen");
            this.nameTable.Add(14, "fourteen");
            this.nameTable.Add(15, "fifteen");
            this.nameTable.Add(16, "sixteen");
            this.nameTable.Add(17, "seventeen");
            this.nameTable.Add(18, "eighteen");
            this.nameTable.Add(19, "nineteen");
            this.nameTable.Add(20, "twenty");
            this.nameTable.Add(30, "thirty");
            this.nameTable.Add(40, "forty");
            this.nameTable.Add(50, "fifty");
            this.nameTable.Add(60, "sixty");
            this.nameTable.Add(70, "seventy");
            this.nameTable.Add(80, "eighty");
            this.nameTable.Add(90, "ninety");
            this.nameTable.Add(100, "hundred");
            this.nameTable.Add(1000, "onethousand");
        }

        public override string GetName()
        {
            return "Challenge17";
        }

        protected override int SolveImplementation()
        {
            int totalCharCount = 0;
            for (int i = 1; i <= 1000; i++)
            {
                int charCount = this.GetCharCount(i);
                totalCharCount += charCount;
            }

            return totalCharCount;
        }

        private int GetCharCount(int num)
        {
            var numAsWords = this.GetWords(num).Replace(" ", "");
            Console.WriteLine($"Num {num} as String: {numAsWords}, count: {numAsWords.Length}");
            return numAsWords.Length;
        }

        private string GetWords(int num)
        {
            string res = "";

            if (num < 10)
            {
                return this.nameTable[num];
            }
            if (num <= 20)
            {
                return this.nameTable[num];
            }
            if (num < 100)
            {
                int wholeNum = (num / 10) * 10;
                res += this.nameTable[wholeNum];

                if (num % 10 != 0)
                {
                    int small = num - wholeNum;
                    res += this.nameTable[small];
                }

                return res;
            }
            if (num < 1000)
            {
                int wholeNumHundred = (num / 100);
                res += this.nameTable[wholeNumHundred] + this.nameTable[100];

                if (num % 100 != 0)
                {
                    res += "and";
                    var smaller = this.GetWords(num - wholeNumHundred*100);
                    res += smaller;
                }

                return res;
            }
            if (num == 1000)
            {
                return this.nameTable[1000];
            }
            if (num > 1000)
            {
                throw new NotImplementedException();
            }

            throw new NotImplementedException("RETURN IN THE IF NOT HERE");
        }
    }
}
