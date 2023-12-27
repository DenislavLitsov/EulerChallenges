using ChallengeExecutor.Challenges.Abstractions;
using Common;
using System.Formats.Asn1;
using System.Security.Cryptography;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge28
{
    public class Challenge28 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge28";
        }

        protected override int SolveImplementation()
        {
            int size = 1001;
            var fastMap = this.BuildMap(size);
            
            int answer = 1;
            int prevStep = 0;
            int currStart = 0;
            int currStep = 0;
            for (int i = 1; i < size; i++)
            {
                currStep += 2;
                currStart += currStep;
                for (int s = 0; s < 4; s++)
                {
                    if (currStart > fastMap.Count)
                    {
                        break;
                    }
                    int toAdd = fastMap[currStart];
                    Console.WriteLine($"CurrStart: {currStart} CurrStep: {currStep}, ToAdd: {toAdd}");
                    answer += toAdd;
                    if (s == 3)
                    {
                        break;
                    }
                    currStart += currStep;
                }
            }

            return answer;
        }

        private List<int> BuildMap(int size)
        {
            int currIndex = 1;
            List<int> result = new List<int>();
            for (int i = 0; i < size; i++)
            {
                for (int s = 0; s < size; s++)
                {
                    result.Add(currIndex);
                    currIndex++;
                }
            }

            return result;
        }
    }
}
