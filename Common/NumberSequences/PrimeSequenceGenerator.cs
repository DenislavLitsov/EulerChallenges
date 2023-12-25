using Common.NumberSequences.Abstractions;
using System;
using System.Reflection;

namespace Common.NumberSequences
{
    public class PrimeSequenceGenerator : BaseSequenceGenerator
    {
        public PrimeSequenceGenerator(int startCacheIndex, int endCacheIndex)
        {
            this.CacheSequence(startCacheIndex, endCacheIndex);
        }

        public override long CalculateNumberAtExactIndex(int index)
        {
            return this.GetCachedValue(index);
        }

        public override List<long> GetNumberSequence(int startIndex, int endIndex)
        {
            this.AssertMaxSequenceIndex(endIndex);

            var result = this._CachedNumbers
                .Skip(startIndex)
                .Take(endIndex)
                .ToList();

            return result;
        }

        public override void CacheSequence(int startCacheIndex, int endCacheIndex)
        {
            this.AssertMaxSequenceIndex(endCacheIndex);

            this._CachedNumbers = new List<long>();
            int oneMil = 1000000;
            int milStart = startCacheIndex / oneMil;
            int milEnd = endCacheIndex / oneMil;

            for (int i = milStart; i <= milEnd; i++)
            {
                string filePath = $"Data/Primes/Primes_{i}.txt";

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = sr.ReadLine();
                    var numbers = line.Split(',');

                    if (i == milStart)
                    {
                        int toSkip = startCacheIndex - (oneMil * i);
                        for (int x = toSkip; x < numbers.Length; x++)
                        {
                            string number = numbers[x];
                            this._CachedNumbers.Add(int.Parse(number));
                        }
                    }
                    else if (i == milEnd)
                    {
                        int toSkip = endCacheIndex - (oneMil * i);
                        for (int x = 0; x < toSkip; x++)
                        {
                            string number = numbers[x];
                            this._CachedNumbers.Add(int.Parse(number));
                        }
                    }
                    else
                    {
                        foreach (var number in numbers)
                        {
                            this._CachedNumbers.Add(int.Parse(number));
                        }
                    }
                }
            }
        }

        public override int GetMaximaValidIndex()
        {
            return 105097565;
        }
    }
}
