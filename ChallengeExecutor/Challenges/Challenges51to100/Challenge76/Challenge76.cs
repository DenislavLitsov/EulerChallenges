using ChallengeExecutor.Challenges.Abstractions;
using ChallengeExecutor.Challenges.Challenges51to100.Challenge68;
using System.Collections.Generic;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge76
{
    public class Challenge76 : BaseChallenge<int>
    {
        private Dictionary<int, IList<SumNumber>> CacheNumbers = new Dictionary<int, IList<SumNumber>>();

        protected override void Setup()
        {
        }

        protected override int SolveImplementation()
        {
            //this.CacheNumbers.Add(1, new List<SumNumber> { new SumNumber(new[] { 1 }) });
            this.CacheNumbers.Add(2, new List<SumNumber> { new SumNumber(new[] { 1, 1 }) });

            for (int i = 1; i <= 100; i++)
            {
                var comb = this.GetAllPossibleCombinations(i);
                Console.WriteLine($"{i}: {comb.Count()}");
            }

            return this.CacheNumbers[100].Count();

            var allSums = this.GetAllPossibleCombinations(40);

            foreach (var item in allSums)
            {
                //item.Numbers.ToList().ForEach(number => { Console.Write(number); Console.Write(" "); });
                //Console.WriteLine();
            }
            return allSums.Count();
        }

        private IList<SumNumber> GetAllPossibleCombinations(int number)
        {
            if (this.CacheNumbers.ContainsKey(number))
            {
                return this.CacheNumbers[number];
            }

            List<SumNumber> result = new List<SumNumber>();
            HashSet<string> cachedItems = new HashSet<string>();

            int maxNumber = number / 2;
            for (int number1 = 1; number1 <= maxNumber; number1++)
            {
                int number2 = number - number1;
                var addNew = new SumNumber(new[] { number1, number2 });
                result.Add(addNew);
                cachedItems.Add(addNew.CachedNumbers);

                var inner = this.GetAllPossibleCombinations(number2);

                for (int i = inner.Count - (1); i >= 0; i--)
                {
                    var innerItem = inner[i];
                    if (number1 > innerItem.Numbers.First())
                    {
                        break;
                    }

                    var newSum = SumNumber.CombineNumbers(number1, innerItem);
                    //if (this.Exists(cachedItems, newSum) == false)
                    {
                        result.Add(newSum);
                        cachedItems.Add(newSum.CachedNumbers);
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

        private bool Exists(HashSet<string> sums, SumNumber newSum)
        {
            return true;
            //return sums.Contains(newSum.CachedNumbers);

            //if (sums.Any(x=>x.CachedNumbers == newSum.CachedNumbers))
            //{
            //    return true;
            //}

            //return false;
            //
            //bool exists = false;
            //foreach (var sum in sums)
            //{
            //    int count = newSum.Numbers.Count();
            //    if (count != sum.Numbers.Count())
            //    {
            //        continue;
            //    }
            //    for (int i = 0; i < count; i++)
            //    {
            //        int number1 = sum.Numbers.ElementAt(i);
            //        int number2 = newSum.Numbers.ElementAt(i);
            //
            //        if (number1 != number2)
            //        {
            //            exists = false;
            //            break;
            //        }
            //        else
            //        {
            //            exists = true;
            //        }
            //    }
            //
            //    if (exists)
            //        return true;
            //}
            //
            //return exists;
        }
    }
}