using ChallengeExecutor.Challenges.Abstractions;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeExecutor.Challenges.Challenge47
{
    public class Challenge47 : BaseChallenge<long>
    {
        public override string GetName()
        {
            return "Challenge47";
        }

        protected override long SolveImplementation()
        {
            for (long currNumber = 647; currNumber < long.MaxValue; currNumber++)
            {
                if (currNumber.IsPrime() || !this.IsNumberGood(currNumber))
                    continue;

                bool isFound = true;
                for (long newNumber = currNumber + 1; newNumber <= currNumber+3; newNumber++)
                {
                    if (!this.IsNumberGood(newNumber))
                    {
                        isFound = false;
                        break;
                    }
                }

                if (isFound)
                    return currNumber;
            }

            throw new Exception("Not found solution");
        }

        private bool IsNumberGood(long number)
        {
            var divisors = this.GetDivisors(number)
                .Where(x => x != 1)
                .Distinct()
                .ToList();

            if (divisors.Count() != 4)
                return false;

            foreach (var divisor in divisors)
            {
                if (!divisor.IsPrime())
                    return false;
            }

            return true;
        }

        private IEnumerable<long> GetDivisors(long number)
        {
            List<long> result = new List<long>();
            
            while (number != 1)
            {
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        result.Add(i);
                        number = number / i;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
