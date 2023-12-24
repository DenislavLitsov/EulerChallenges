using ChallengeExecutor.Challenges.Abstractions;
using Common;
using System.Numerics;

namespace ChallengeExecutor.Challenges.Challenge26
{
    public class Challenge26 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge26";
        }

        protected override int SolveImplementation()
        {
            int longestRepeatString = 0;
            BigInteger bestNumber = 0;

            BigInteger a = 1;

            int precision = 10000;
            for (int i = 0; i < precision; i++)
            {
                a *= 10;
            }


            for (BigInteger i = 7; i < 1000; i++)
            {
                BigInteger numberToCheck = a / i;
                if (numberToCheck.ToString().Length < 900)
                {
                    continue;
                }

                var decimalPart = numberToCheck.ToString();
                for (int startIndex = 0; startIndex < 5; startIndex++)
                {
                    for (int totalLength = 1; totalLength < precision - startIndex; totalLength++)
                    {
                        if (startIndex + totalLength > decimalPart.Length)
                        {
                            break;
                        }

                        string subString = decimalPart.Substring(startIndex, totalLength);
                        var split = decimalPart.Split(subString);
                        if (split.Length > 2 && split[split.Length -2].Length == 0)
                        {
                            if (longestRepeatString < subString.Length)
                            {
                                longestRepeatString = subString.Length;
                                bestNumber = i;
                                Console.WriteLine($"New record at I: {i}");
                                Console.WriteLine($"Repeat count: {subString.Length}");
                                //Console.WriteLine($"Decimal part: { decimalPart.ToString()}");
                                Console.WriteLine($"Decimal repeat: {subString}");
                            }

                            break;
                        }
                    }
                }
            }

            return (int)bestNumber;
        }
    }
}
