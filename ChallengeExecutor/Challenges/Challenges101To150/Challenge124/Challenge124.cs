using ChallengeExecutor.Challenges.Abstractions;

namespace ChallengeExecutor.Challenges.Challenges101To150.Challenge124
{
    public class Challenge124 : BaseChallenge<long>
    {
        protected override long SolveImplementation()
        {
            var calculations = new List<DistinctPrimeFactorCalculation>();
            for (int i = 1; i <= 100000; i++)
            {
                calculations.Add(new DistinctPrimeFactorCalculation(i));
            }

            calculations = calculations.OrderBy(x => x.PrimeFactorsProduct).ToList();
            
            return calculations[10000 - 1].Number;
        }
    }
}