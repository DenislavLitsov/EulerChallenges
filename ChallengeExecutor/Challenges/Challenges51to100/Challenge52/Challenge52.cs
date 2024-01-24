using ChallengeExecutor.Challenges.Abstractions;
using ChallengeExecutor.Challenges.Challenges1To50.Challenge18;
using Common;
using Common.Exceptions;
using Common.NumberSequences;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge52
{
    public class Challenge52 : BaseChallenge<long>
    {
        protected override long SolveImplementation()
        {
            bool found = false;
            for (long currNum = 1; currNum < long.MaxValue / 6; currNum++)
            {
                for (long x = 1; x <= 6; x++)
                {
                    long newNumber = currNum * x;

                    string num1 = currNum.ToString();
                    string num2 = newNumber.ToString();

                    if (num1.Length != num2.Length)
                        break;

                    var distinct1 = num1.Distinct();
                    var distinct2 = num2.Distinct();

                    if (distinct1.Count() != num1.Length)
                        break;
                    if (distinct2.Count() != num2.Length)
                        break;

                    List<bool> foundDigits = new List<bool>();

                    distinct1.ToList().ForEach(digit =>
                    {
                        if (distinct2.Any(x => x == digit))
                        {
                            foundDigits.Add(true);
                        }
                        else
                        {
                            foundDigits.Add(false);
                        }
                    });

                    if (foundDigits.Any(x => x == false))
                        break;

                    if (x == 6)
                    {
                        found = true;
                        return currNum;
                    }
                }
            }

            throw new NoSolutionFound("Not found solution");
        }
    }
}
