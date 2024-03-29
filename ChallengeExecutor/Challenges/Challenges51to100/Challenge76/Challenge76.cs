using ChallengeExecutor.Challenges.Abstractions;
using ChallengeExecutor.Challenges.Challenges51to100.Challenge68;
using System.Collections.Generic;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge76
{
    public class Challenge76 : BaseChallenge<int>
    {
        private Dictionary<int, IEnumerable<SumNumber>> CacheNumbers = new Dictionary<int, IEnumerable<SumNumber>>();

        protected override void Setup()
        {
        }

        protected override int SolveImplementation()
        {
            this.CacheNumbers.Add(1, new List<SumNumber> { new SumNumber(new[] { 1 }) });

            for (int i = 1; i <= 20; i++)
            {
                this.GetAllPossibleCombinations(i);
            }

            var allSums = this.GetAllPossibleCombinations(40);

            foreach (var item in allSums)
            {
                //item.Numbers.ToList().ForEach(number => { Console.Write(number); Console.Write(" "); });
                //Console.WriteLine();
            }
            return allSums.Count();
        }

        private IEnumerable<SumNumber> GetAllPossibleCombinations(int number)
        {
            if (this.CacheNumbers.ContainsKey(number))
            {
                return this.CacheNumbers[number];
            }

            List<SumNumber> result = new List<SumNumber>();

            int maxNumber = number / 2;
            for (int number1 = 1; number1 <= maxNumber; number1++)
            {
                int number2 = number - number1;
                result.Add(new SumNumber(new[] { number1, number2 }));

                var inner = this.GetAllPossibleCombinations(number2);
                foreach (var innerItem in inner)
                {
                    var newSum = SumNumber.CombineNumbers(number1, innerItem);
                    if (this.Exists(result, newSum) == false)
                    {
                        result.Add(newSum);
                    }
                }
            }

            if (this.CacheNumbers.ContainsKey(number))
            {
                throw new NotImplementedException();
            }
            this.CacheNumbers.Add(number, result);
            return result;
        }

        private bool Exists(IEnumerable<SumNumber> sums, SumNumber newSum)
        {
            bool exists = false;
            foreach (var sum in sums)
            {
                int count = newSum.Numbers.Count();
                for (int i = 0; i < count; i++)
                {
                    int number1 = sum.Numbers.ElementAt(i);
                    int number2 = newSum.Numbers.ElementAt(i);

                    if (number1 != number2)
                    {
                        exists = false;
                        break;
                    }
                    else
                    {
                        exists = true;
                    }
                }

                if (exists)
                    return true;
            }

            return exists;
        }
    }
}