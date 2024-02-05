using ChallengeExecutor.Challenges.Abstractions;
using Common.AdvancedMath;
using System.Numerics;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge26
{
    public class Challenge26WithBigDecimal : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            int longestRepeatString = 0;
            BigInteger bestNumber = 0;

            int precision = 2000;
            BigDecimal a = new BigDecimal(1, 0, 0, precision);

            for (BigInteger i = 7; i < 1000; i++)
            {
                var toDivision = new BigDecimal(i, 0, 0, precision);

                var numberToCheck = a / toDivision;
                if (numberToCheck.ToString().Length < 900)
                {
                    continue;
                }

                var decimalPart = numberToCheck.ToString().Split(',')[1];
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
