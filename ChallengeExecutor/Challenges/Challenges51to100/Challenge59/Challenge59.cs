using ChallengeExecutor.Challenges.Abstractions;
using Common.Exceptions;
using System.Text;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge59
{
    public class Challenge59 : FileReadingChallenge<int>
    {
        byte[] cypheredMsg;

        protected override string GetFilePath()
        {
            return @"Challenges\Challenges51to100\Challenge59\cypher.txt";
        }

        protected override void Setup()
        {
            var file = this.ReadFileAsOneLine();
            var numbers = file.Split(',');

            this.cypheredMsg = new byte[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                this.cypheredMsg[i] = byte.Parse(numbers[i]);
            }
        }

        protected override int SolveImplementation()
        {
            byte minlValue = 97;
            byte maxValue = 122;

            Console.WriteLine($"Min value: {(char)minlValue}; Max value: {(char)maxValue}");

            for (byte index1 = minlValue; index1 <= maxValue; index1++)
            {
                for (byte index2 = minlValue; index2 <= maxValue; index2++)
                {
                    for (byte index3 = minlValue; index3 <= maxValue; index3++)
                    {
                        byte[] key = { index1, index2, index3 };

                        var dectypted = this.XORCypher(key);
                        var decryptedAsString = this.BytesToString(dectypted);

                        if (decryptedAsString.Contains("arrived") == true)
                        {
                            Console.WriteLine(decryptedAsString);
                            Console.WriteLine($"Key was: {index1}, {index2}, {index3}");

                            var sum = dectypted.Sum(x => x);
                            return sum;
                        }
                    }
                }
            }

            throw new NoSolutionFound();
        }

        private byte[] XORCypher(byte[] key)
        {
            int currKeyIndex = 0;
            byte[] result = new byte[this.cypheredMsg.Length];

            for (int i = 0; i < this.cypheredMsg.Length; i++)
            {
                byte cypheredByte = this.cypheredMsg[i];
                byte currKey = key[currKeyIndex];

                byte decripted = (byte)(cypheredByte ^ currKey);

                result[i] = decripted;

                currKeyIndex++;
                if (currKeyIndex == 3)
                    currKeyIndex = 0;
            }

            return result;
        }

        private string BytesToString(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var letter in bytes)
            {
                sb.Append((char)letter);
            }

            return sb.ToString();
        }
    }
}
