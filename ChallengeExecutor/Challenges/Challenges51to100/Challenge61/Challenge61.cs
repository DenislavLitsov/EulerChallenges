using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.Exceptions;
using Common.NumberSequences;
using Common.NumberSequences.Abstractions;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge61
{
    public class Challenge61 : BaseChallenge<long>
    {
        protected override long SolveImplementation()
        {
            List<BaseSequenceGenerator> generators = new List<BaseSequenceGenerator>();
            generators.Add(new TriangleSequenceGenerator());
            generators.Add(new SquareSequenceGenerator());
            generators.Add(new PentagonalSequenceGenerator());
            generators.Add(new HexagonalSequenceGenerator());
            generators.Add(new HeptagonalSequenceGenerator());
            generators.Add(new OctagonalSequnceGenerator());

            foreach (var generator in generators)
            {
                generator.CacheSequenceByValues(1000, 9999);
            }

            var numbers = this.GetCyclicNumbers(new List<long>(), generators)
                .ToList();
            var sum = numbers.Sum();
            return sum;
        }

        private IEnumerable<long> GetCyclicNumbers(ICollection<long> numbers, IEnumerable<BaseSequenceGenerator> possibleGenerators)
        {
            foreach (var generator in possibleGenerators)
            {
                var cachedNumebrs = generator.GetCachedNumbers();
                // First Generator
                if (numbers.Count == 0)
                {
                    foreach (var cachedNumber in cachedNumebrs)
                    {
                        numbers.Add(cachedNumber);
                        var res = this.GetCyclicNumbers(numbers, possibleGenerators
                                                        .Where(x => x != generator));
                        if (res != null)
                            return res;

                        numbers.Clear();
                    }
                }
                // Any middle generator
                else if (possibleGenerators.Count() > 1)
                {
                    long prevNumber = numbers.Last();
                    string prevNumberAsString = prevNumber.ToString();
                    long startValue = int.Parse(new string(prevNumberAsString.TakeLast(2).ToArray())) * 100;
                    long maxValue = (int.Parse(new string(prevNumberAsString.TakeLast(2).ToArray())) + 1) * 100 - 1;

                    var numbersToCheck = cachedNumebrs
                        .Where(x => x >= startValue && x <= maxValue)
                        .ToList();

                    foreach (var foundNumber in numbersToCheck)
                    {
                        if (numbers.Any(x => x == foundNumber))
                            continue;

                        numbers.Add(foundNumber);
                        var res = this.GetCyclicNumbers(numbers, possibleGenerators
                                                        .Where(x => x != generator));

                        if (res != null)
                            return res;

                        numbers.Remove(foundNumber);
                    }
                }
                // Last generator
                else
                {
                    long prevNumber = numbers.Last();
                    string prevNumberAsString = prevNumber.ToString();
                    long startValue = int.Parse(new string(prevNumberAsString.TakeLast(2).ToArray())) * 100;
                    long maxValue = (int.Parse(new string(prevNumberAsString.TakeLast(2).ToArray())) + 1) * 100 - 1;
                    string firstNumberAsStringFirstTwo = new string(numbers.First().ToString().Take(2).ToArray());

                    var numbersToCheck = cachedNumebrs
                        .Where(x => x >= startValue && x <= maxValue)
                        .ToList();

                    foreach (var foundNumber in numbersToCheck)
                    {
                        if (numbers.Any(x => x == foundNumber))
                            continue;

                        string foundNumberAsString = foundNumber.ToString();
                        string lastTwo = new string(foundNumberAsString.TakeLast(2).ToArray());

                        if (lastTwo == firstNumberAsStringFirstTwo)
                        {
                            numbers.Add(foundNumber);
                            numbers.Print();
                            return numbers;
                        }
                    }
                }
            }

            return null;
        }
    }
}
