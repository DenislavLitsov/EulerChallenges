using Common.AdvancedMath.WrittenNumbers;
using Common.NumberSequences.Chains;

namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge64
{
    public class PeriodicSqareRootChainGenerator : ChainGenerator<double>
    {
        private readonly double _startNumber;

        private double _nextNumberToCalculate;

        public PeriodicSqareRootChainGenerator(double startNumber)
            : base()
        {
            _startNumber = startNumber;

            double initValue = (int)Math.Sqrt(startNumber);
            this._nextNumberToCalculate = startNumber;
        }

        public override bool IsElementInChain(double element)
        {
            var res = this.Chain.Any(x => (int)x == (int)element);
            return res;
        }

        protected override IEnumerable<double> InitializeChainValue()
        {
            List<double> res = new List<double>();
            var firstValue = Math.Sqrt(this._startNumber);
            var secondValue = 1 / (Math.Sqrt(this._startNumber) - (int)firstValue);

            res.Add(firstValue);
            res.Add(secondValue);

            return res;
        }

        protected override double GenerateNextChainElement()
        {
            var lastElement = this.GetLastChainElement();
            var res = 1 / (lastElement - (int)lastElement);
            return res;
        }
    }
}