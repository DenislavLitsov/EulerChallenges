using ChallengeExecutor.Challenges.Abstractions;
using Common;

namespace ChallengeExecutor.Challenges.Challenges1To50.Challenge24
{
    public class Challenge24 : BaseChallenge<long>
    {
        private static readonly long[] PossibleNumbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        protected override long SolveImplementation()
        {
            List<long> possibleBuildNumbers = new List<long>();
            possibleBuildNumbers = this.GetAllPossibleNumbersBuild(0, PossibleNumbers.ToList());

            return possibleBuildNumbers[1000000 - 1];
        }

        private List<long> GetAllPossibleNumbersBuild(long currNum, List<long> buildingNumbers)
        {
            List<long> result = new List<long>();

            if (buildingNumbers.Count == 0)
            {
                result.Add(currNum);
                return result;
            }

            foreach (long number in buildingNumbers)
            {
                long operatingNumber = currNum;
                operatingNumber *= 10;
                operatingNumber += number;

                var deepCopy = buildingNumbers.DeepCopy().ToList();
                deepCopy.Remove(number);

                var toAdd = this.GetAllPossibleNumbersBuild(operatingNumber, deepCopy);
                result.AddRange(toAdd);
            }

            return result;
        }
    }
}
