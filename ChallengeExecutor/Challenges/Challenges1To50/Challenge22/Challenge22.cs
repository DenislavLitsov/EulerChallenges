using ChallengeExecutor.Challenges.Abstractions;
using Common;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge22
{
    public class Challenge22 : BaseChallenge<long>
    {
        protected override long SolveImplementation()
        {
            long result = 0;
            var names = this.GetNames().OrderBy(x=>x).ToList();
            for (int i = 0; i < names.Count; i++)
            {
                long position = i + 1;
                long charsValue = 0;

                string name = names[i];
                byte charCalculator = (byte)'A';
                for (int j = 0; j < name.Length; j++)
                {
                    byte currCharValue = (byte)name[j];
                    int toAdd = currCharValue - charCalculator + 1;
                    charsValue += toAdd;
                }

                result += position * charsValue;
                Console.WriteLine($"Name: {names[i]}, Position: {i}, Char value: {charsValue}");
            }
            return result;
        }

        private List<string> GetNames()
        {
            string allList = "";
            using (StreamReader sr = new StreamReader("Challenges/Challenges1To50/Challenge22/names.txt"))
            {
                allList = sr.ReadLine();
            }

            var splitedNames = allList.Replace('"'.ToString(), "").Split(',').ToList();
            return splitedNames;
        }
    }
}
