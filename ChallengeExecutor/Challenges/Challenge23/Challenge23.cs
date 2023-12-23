using Common;
using System.Linq;

namespace ChallengeExecutor.Challenges.Challenge23
{
    public enum NumberType
    {
        Perfect,
        Abundant,
        Deficient
    }

    public class Challenge23 : BaseChallenge<long>
    {
        private const long TheoreticalLimit = 28123;

        public override string GetName()
        {
            return "Challenge23";
        }

        protected override long SolveImplementation()
        {
            var abundantNumbers = this.GetAllAbundantNumbers().ToList();

            var allPossibleCombinations = this.AllIntegersThatCanBeMadeFromAbundantNumbers(abundantNumbers);
            //allPossibleCombinations.Print();

            List<long> allNonCombinationInts = new List<long>();
            for (long i = 1; i < TheoreticalLimit; i++)
            {
                if (allPossibleCombinations.Contains(i) == false)
                {
                    allNonCombinationInts.Add(i);
                }
            }

            var result = allNonCombinationInts.Sum();
            return result;
        }

        private IEnumerable<long> AllIntegersThatCanBeMadeFromAbundantNumbers(IEnumerable<long> abundantNumbers)
        {
            List<long> res = new List<long>();
            foreach (var x in abundantNumbers)
            {
                foreach (var y in abundantNumbers)
                {
                    var newNum = x + y;
                    if (newNum > TheoreticalLimit)
                        break;

                    if (res.Contains(newNum) == false)
                    {
                        res.Add(newNum);
                    }
                }
            }

            return res;
        }

        // Mega slow not used
        private bool CanBeCalculatedWithAbundantNumbers(long number, List<long> abundantNumbers, long iteration)
        {
            var numbersInRange = abundantNumbers.Where(x => number >= x).ToList();
            numbersInRange.Reverse();
            foreach (var abundantNumber in numbersInRange)
            {
                if (abundantNumber > number)
                {
                    return false;
                }
                if (abundantNumber == number)
                {
                    if (iteration > 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
        
                var recursiveCheck = this.CanBeCalculatedWithAbundantNumbers(number - abundantNumber, numbersInRange, iteration++);
                if (recursiveCheck == true)
                {
                    return true;
                }
            }
        
            return false;
        }

        private NumberType GetNumberType(long number)
        {
            long divisorSum = number.GetAllDivisorsExcludingSameNumber().Sum();
            if (divisorSum == number)
            {
                return NumberType.Perfect;
            }
            else if (divisorSum > number)
            {
                return NumberType.Abundant;
            }
            else
            {
                return NumberType.Deficient;
            }
        }

        private IEnumerable<long> GetAllAbundantNumbers()
        {
            List<long> abundantNumbers = new List<long>();
            for (long i = 1; i <= TheoreticalLimit; i++)
            {
                var numberType = this.GetNumberType(i);
                if (numberType == NumberType.Abundant)
                {
                    abundantNumbers.Add(i);
                }
            }

            return abundantNumbers;
        }
    }
}
