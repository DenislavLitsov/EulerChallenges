using ChallengeExecutor.Challenges.Abstractions;
using Common;

namespace ChallengeExecutor.Challenges.Challenge34
{
    public class Challenge34 : BaseChallenge<long>
    {
        private readonly Dictionary<char, long> _Factorials = new Dictionary<char, long>();

        public override string GetName()
        {
            return "Challenge34";
        }

        protected override void Setup()
        {
            base.Setup();

            for (int i = 0; i <= 9; i++)
            {
                int factorial = i.Factorial();
                this._Factorials.Add(i.ToString()[0], factorial);
            }
        }

        protected override long SolveImplementation()
        {
            List<long> resultList = new List<long>();
            for (long number = 3; number < 999999; number++)
            {
                long numToCheck = 0;
                string numberAsString = number.ToString();

                for (long i = 0; i < numberAsString.Length; i++)
                {
                    long factorial = this._Factorials[numberAsString[(int)i]];
                    numToCheck += factorial;
                    if (numToCheck > number)
                    {
                        break;
                    }
                }

                if (numToCheck == number)
                {
                    resultList.Add(number);
                }
            }

            resultList.Print();
            return resultList.Sum();
        }
    }
}
