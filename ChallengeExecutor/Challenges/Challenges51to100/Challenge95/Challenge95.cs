using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge95
{
    public class Challenge95 : BaseChallenge<int>
    {
        private IEnumerable<int> _longestAmicableChain;
        private List<bool> _usedIntegers;
        private int _longestChainCount = 0;

        public Challenge95() 
            : base()
        {
            _usedIntegers = new List<bool>();
            for (int i = 0; i < Constants.OneMilion + 1; i++)
            {
                this._usedIntegers.Add(false);
            }
        }

        protected override int SolveImplementation()
        {
            for (int i = 1; i < Constants.OneMilion; i++)
            {
                if (i % 10000 == 0)
                {
                    Console.WriteLine(i);
                }
                var chain = this.GetChain(i, new List<int>(){i}, true);
                if (chain == null)
                    continue;

                //foreach (var usedInt in chain)
                //{
                //    this._usedIntegers.Add(usedInt);
                //}
                
                if (chain.Count() > this._longestChainCount)
                {
                    this._longestChainCount = chain.Count();
                    this._longestAmicableChain = chain;
                    this._longestAmicableChain
                        .ToList()
                        .ForEach(x =>
                        {
                            Console.Write($"{x}=>");
                        });
                    Console.WriteLine();
                    Console.WriteLine(this._longestChainCount);
                }
            }

            return this._longestAmicableChain.Min();
        }

        private IEnumerable<int> GetChain(int number, IList<int> currNumbers, bool checkIfNumberIsUsed)
        {
            if (this._usedIntegers[number])
            {
                return null;
            }

            this._usedIntegers[number] = true;
            
            int newNum = number.GetAllDivisorsExcludingSameNumber().Sum();
            if (newNum > Constants.OneMilion)
            {
                return null;
            }
            if (currNumbers.Contains(newNum))
            {
                var startIndex = currNumbers.IndexOf(newNum);
                var subChain = currNumbers.Skip(startIndex).ToList();
                subChain.Add(newNum);
                return subChain;
            }
            
            currNumbers.Add(newNum);
            return this.GetChain(newNum, currNumbers, true);
        }
    }
}
