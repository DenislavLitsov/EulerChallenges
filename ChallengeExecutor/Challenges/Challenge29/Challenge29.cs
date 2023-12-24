using ChallengeExecutor.Challenges.Abstractions;
using Common;
using System.Numerics;

namespace ChallengeExecutor.Challenges.Challenge29
{
    public class Challenge29 : BaseChallenge<int>
    {
        public override string GetName()
        {
            return "Challenge29";
        }

        protected override int SolveImplementation()
        {
            List<BigInteger> sequence = new List<BigInteger>();

            for (BigInteger a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    BigInteger c = a.BigPower(b);
                    if (sequence.Contains(c) == false)
                    {
                        sequence.Add(c);
                    }
                }
            }

            return sequence.Count;
        }
    }
}
