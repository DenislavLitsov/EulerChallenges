using ChallengeExecutor.Challenges.Abstractions;
using ChallengeExecutor.Challenges.Challenges1To50.Challenge18;
using Common;
using Common.Exceptions;
using Common.NumberSequences;
using System;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge51
{
    public class Challenge51 : BaseChallenge<long>
    {
        private PrimeSequenceGenerator _Generator;

        private int prevMaxLength = 0;
        private Dictionary<int, IEnumerable<IEnumerable<int>>> possibleChanges;

        public override string GetName()
        {
            return "Challenge51";
        }

        protected override void Setup()
        {
            this._Generator = new PrimeSequenceGenerator(0, Constants.OneMilion);
            base.Setup();
        }

        protected override long SolveImplementation()
        {
            for (int currNumber = 15; currNumber < int.MaxValue; currNumber++)
            {
                if (this._Generator.ContainsInCachedSequence(currNumber) == false)
                    continue;

                string currNumberString = currNumber.ToString();
                int currNumberStringLength = currNumber.ToString().Length;

                if (this.prevMaxLength != currNumberStringLength)
                {
                    this.SetUpPossibleChanges(currNumberStringLength - 1);
                    this.prevMaxLength = currNumberStringLength;
                }

                for (int s = 1; s < currNumberStringLength - 1; s++)
                {
                    var possibleChangesRoot = this.possibleChanges[s];
                    foreach (var possibleChanges in possibleChangesRoot)
                    {
                        List<long> possiblePrimes = new List<long>();

                        int totalPrimes = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            if (i == 0 && possibleChanges.Contains(0))
                                continue;

                            // change string;
                            var charList = currNumberString.ToList();
                            foreach (var possibleChange in possibleChanges)
                            {
                                charList[possibleChange] = i.ToString()[0];
                            }

                            var newNumber = long.Parse(new string(charList.ToArray()));
                            var isPrime = this._Generator.ContainsInCachedSequence(newNumber);
                            if (isPrime)
                            {
                                totalPrimes++;
                                possiblePrimes.Add(newNumber);
                            }
                        }

                        if (totalPrimes >= 8)
                        {
                            possiblePrimes.Sort();
                            return possiblePrimes[0];
                        }
                    }
                }
            }

            throw new NoSolutionFound();
        }

        private void SetUpPossibleChanges(int maxLength)
        {
            this.possibleChanges = new Dictionary<int, IEnumerable<IEnumerable<int>>>();
            for (int i = 1; i <= maxLength; i++)
            {
                var toAdd = this.GetPossiblePositions(i, maxLength, new List<int>());
                this.possibleChanges.Add(i, toAdd);
            }
        }

        private List<List<int>> GetPossiblePositions(int totalNeededCount, int maxInclusiveNumber, List<int> usedIndexes)
        {
            List<List<int>> results = new List<List<int>>();
            for (int i = 0; i <= maxInclusiveNumber; i++)
            {
                var usedIndexesCopy = usedIndexes.DeepCopy()
                    .ToList();

                if (usedIndexesCopy.Contains(i))
                    continue;

                usedIndexesCopy.Add(i);

                if (usedIndexesCopy.Count >= totalNeededCount)
                {
                    results.Add(usedIndexesCopy);
                }
                else
                {
                    var result = this.GetPossiblePositions(totalNeededCount, maxInclusiveNumber, usedIndexesCopy);
                    results.AddRange(result);
                }
            }

            return results;
        }
    }
}
