

using ChallengeExecutor.Challenges.Abstractions;
using Common;
using Common.NumberSequences;

namespace ChallengeExecutor.Challenges.Challenge45
{
    public class Challenge45 : BaseChallenge<long>
    {
        private TriangleSequenceGenerator _TriangleSequenceGenerator;
        private PentagonalSequenceGenerator _PentagonalSequenceGenerator;
        private HexagonalSequenceGenerator _HexagonalSequenceGenerator;

        public override string GetName()
        {
            return "Challenge45";
        }

        protected override void Setup()
        {
            this._TriangleSequenceGenerator = new TriangleSequenceGenerator();
            this._PentagonalSequenceGenerator = new PentagonalSequenceGenerator();
            this._HexagonalSequenceGenerator = new HexagonalSequenceGenerator();
        }

        protected override long SolveImplementation()
        {
            int startPentagonal = 2;
            int startHexagonal = 2;

            for (int i = 286; i <= this._TriangleSequenceGenerator.GetMaximaValidIndex(); i++)
            {
                long currValue = this._TriangleSequenceGenerator.CalculateNumberAtExactIndex(i);
                for (int pentagonalindex = startPentagonal; pentagonalindex < this._PentagonalSequenceGenerator.GetMaximaValidIndex(); pentagonalindex++)
                {
                    long value = this._PentagonalSequenceGenerator.CalculateNumberAtExactIndex(pentagonalindex);
                    if (value > currValue)
                    {
                        startPentagonal = pentagonalindex - 1;
                        break;
                    }

                    if (value == currValue)
                    {
                        for (int hexagonalIndex = startHexagonal; hexagonalIndex < this._HexagonalSequenceGenerator.GetMaximaValidIndex(); hexagonalIndex++)
                        {
                            value = this._HexagonalSequenceGenerator.CalculateNumberAtExactIndex(hexagonalIndex);
                            if (value > currValue)
                            {
                                startHexagonal = hexagonalIndex - 1;
                                break;
                            }

                            if (value == currValue)
                            {
                                Console.WriteLine($"Found at triangle index {i} value: {currValue}");
                                return value;
                            }
                        }
                    }
                }

                if (i % Constants.OneMilion == 0)
                {
                    Console.WriteLine(i);
                }
            }

            throw new Exception("Not found solution");
        }
    }
}
