using ChallengeExecutor.Challenges.Abstractions;
using Common;
using System.Numerics;

namespace ChallengeExecutor.Challenges.Challenge15
{
    public class Challenge15 : BaseChallenge<BigInteger>
    {
        private long xSize = 20;
        private long ySize = 20;

        private long totalPaths = 0;

        private List<string> paths = new List<string>();

        public Challenge15()
        {
        }

        public override string GetName()
        {
            return "Challenge15";
        }

        protected override BigInteger SolveImplementation()
        {
            BigInteger a = 1;
            for (BigInteger i = 40; i >= 21; i--)
            {
                a *= i;
            }
            BigInteger b = 1;
            for (BigInteger i = 20; i >= 1; i--)
            {
                b *= i;
            }

            BigInteger result = a / b;
            return result;
        }
    }
}
