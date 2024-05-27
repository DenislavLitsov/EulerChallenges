using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath.RomanNumbers;
using System.Linq;
using System.Collections.Generic;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge89
{
    public class Challenge89 : FileReadingChallenge<int>
    {
        private List<RomanNumber> InitRomanNumbers = new List<RomanNumber>();
        private List<RomanNumber> MinimizedRomanNumbers = new List<RomanNumber>();

        protected override void Setup()
        {
            var lines = this.ReadFile();
            foreach (var line in lines)
            {
                InitRomanNumbers.Add(new RomanNumber(line.Trim()));
                MinimizedRomanNumbers.Add(new RomanNumber(line.Trim()));
            }
        }

        protected override int SolveImplementation()
        {
            this.MinimizedRomanNumbers.ForEach(x => { x.MinimizeNumber(); });

            int initTotalSize = 0;
            int minimizedTotalSize = 0;

            this.InitRomanNumbers.ForEach(x => initTotalSize += x.Number.Length);
            this.MinimizedRomanNumbers.ForEach(x => minimizedTotalSize += x.Number.Length);

            int res = initTotalSize - minimizedTotalSize;
            return res;
        }

        protected override string GetFilePath()
        {
            return @"Challenges\Challenges51to100\Challenge89\Numbers.txt";
        }
    }
}