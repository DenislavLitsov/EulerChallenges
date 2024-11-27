using Common;
using Common.AdvancedMath;

namespace ChallengeExecutor.Challenges.Challenges101To150.Challenge124
{
    public class DistinctPrimeFactorCalculation
    {
        public DistinctPrimeFactorCalculation(int number)
        {
            Number = number;
            this.Calculate();   
        }

        public int Number { get; private set; }
        
        public IEnumerable<int> Factors { get; private set; }

        public IEnumerable<int> PrimeFactors { get; private set; }

        public int PrimeFactorsProduct { get; private set; }
        
        private void Calculate()
        {
            var factors = Number.GetAllFactors();
            this.Factors = factors;

            this.PrimeFactors = factors
                .Distinct()
                .Where(x => x.IsPrime())
                .ToList();

            this.PrimeFactorsProduct = this.PrimeFactors.Product();
        }
    }
}