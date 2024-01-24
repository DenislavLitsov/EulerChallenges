using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge37
{
    public class Challenge37 : BaseChallenge<int>
    {
        protected override int SolveImplementation()
        {
            List<int> list = new List<int>();
            int result = 0;
            int totalCount = 0;

            int currNum = 11;
            do
            {
                if (currNum.IsPrime())
                {
                    bool areAllPrime = true;
                    // left
                    string currNumToCheck = currNum.ToString();
                    while (currNumToCheck.Length > 1)
                    {
                        currNumToCheck = currNumToCheck.Substring(1);
                        if (int.Parse(currNumToCheck).IsPrime() == false)
                        {
                            areAllPrime = false;
                            break;
                        }
                    }

                    // right
                    currNumToCheck = currNum.ToString();
                    while (currNumToCheck.Length > 1)
                    {
                        currNumToCheck = currNumToCheck.Substring(0, currNumToCheck.Length - 1);
                        if (int.Parse(currNumToCheck).IsPrime() == false)
                        {
                            areAllPrime = false;
                            break;
                        }
                    }

                    if (areAllPrime)
                    {
                        list.Add(currNum);
                        totalCount++;
                    }
                }

                currNum += 2;
            } while (totalCount < 11);

            list.Print();
            result = list.Sum();
            return result;
        }
    }
}
