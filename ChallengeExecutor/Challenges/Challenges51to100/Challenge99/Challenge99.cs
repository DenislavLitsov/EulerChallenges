using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge99
{
    public class Challenge99 : FileReadingChallenge<int>
    {
        private ICollection<KeyValuePair<int, int>> numbers;

        protected override string GetFilePath()
        {
            return "Challenges/Challenges51To100/Challenge99/numbers.txt";
        }

        protected override void Setup()
        {
            List<KeyValuePair<int, int>> result = new();

            var nonParsedNumbers = this.ReadFileAndSplitLines(",");
            foreach (var item in nonParsedNumbers)
            {
                result.Add(
                    new KeyValuePair<int, int>(
                        int.Parse(item.ElementAt(0)), int.Parse(item.ElementAt(1)))
                    );
            }

            this.numbers = result
                .ToList();
        }

        protected override int SolveImplementation()
        {
            int bestLine = -1;
            double bestNumber = -1;

            for (int i = 0; i < this.numbers.Count; i++)
            {
                var item = this.numbers.ElementAt(i);

                var value = item.Value * Math.Log(item.Key);
                if (value > bestNumber)
                {
                    bestNumber = value;
                    bestLine = i;
                }
            }

            return bestLine + 1;
        }
    }
}
