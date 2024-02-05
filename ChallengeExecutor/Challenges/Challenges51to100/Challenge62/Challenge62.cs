using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.Exceptions;
using System.Numerics;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge62
{
    public class Challenge62 : BaseChallenge<long>
    {
        private const int CachedCubedValues = 1000 * 100;

        private List<KeyValuePair<string, long>> cubedValues;

        protected override void Setup()
        {
            this.cubedValues = new List<KeyValuePair<string, long>>();

            for (long i = 2; i <= CachedCubedValues; i++)
            {
                long value = i * i * i;

                var valueAsString = new string(value.ToString().OrderBy(x => x).ToArray());
                this.cubedValues.Add(new KeyValuePair<string, long>(valueAsString, value));
            }
        }

        protected override long SolveImplementation()
        {
            foreach (var item in this.cubedValues)
            {
                var sameItems = this.cubedValues
                    .Where(x => x.Key == item.Key)
                    .OrderBy(x=>x.Value)
                    .ToList();

                if (sameItems.Count == 5)
                {
                    return sameItems[0].Value;
                }
            }

            throw new NoSolutionFound();
        }
    }
}