using System.Numerics;
using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge66
{
    public class Challenge66 : BaseChallenge<BigInteger>
    {
        protected override BigInteger SolveImplementation()
        {
            BigInteger bestD = 0;
            BigInteger bestX = 0;

            for (BigInteger d = 2; d < 1000; d++)
            {
                Console.WriteLine(d);
                BigInteger sqrtD = d.Sqrt();
                if (sqrtD * sqrtD == d)
                {
                    continue;
                }

                var calc = this.GetMinimalX(d);
                if (calc > bestX)
                {
                    bestX = calc;
                    bestD = d;
                    Console.WriteLine($"X: {bestX}, BestD: {bestD}");
                }
            }

            return 5;
        }

        private BigInteger GetMinimalX(BigInteger D)
        {

            return 0;
            // starting
            //BigInteger x = 1;
            //while (true)
            //{
            //    if (x > int.MaxValue)
            //    {
            //        return 1;
            //    }
            //    
            //    // X^2 - D*Y^2 = 1
            //    // X^2 = 1 + D*Y^2
            //    
            //    BigInteger maxX2 = 1 + D * y * y;
            //    BigInteger x = maxX2.Sqrt();
            //    if (maxX2 < 0)
            //    {
            //        throw new OverflowException();
            //    }
            //    if (x * x == maxX2)
            //    {
            //        //Console.WriteLine($"X: {x}, Y:{y}, D:{D}");
            //        return x;
            //    }
//
            //    y++;
            //}
        }
    }
}