using Common.NumberSequences.Abstractions;

namespace Common.NumberSequences.Spirals
{
    public class TwoDSpiralNumberGenerator
    {
        private readonly int step;

        private long currNumber;
        private long sizeNeededToChangeDirection;
        private long currSideSize;
        private int totalAnglesMet;

        public TwoDSpiralNumberGenerator(int step)
        {
            this.step = step;
            this.currNumber = 0;

            this.sizeNeededToChangeDirection = 2;
            this.currSideSize = 1;
            this.totalAnglesMet = -1;
        }

        public long CurrSideSize
        {
            get
            {
                return this.sizeNeededToChangeDirection + 1;
            }
        }

        public TwoDSpiralNumberResult GetNext()
        {
            this.currNumber += this.step;

            this.currSideSize++;
            if (this.currSideSize == this.sizeNeededToChangeDirection)
            {
                this.totalAnglesMet++;
                this.currSideSize = 0;
                if (this.totalAnglesMet == 4)
                {
                    this.totalAnglesMet = 0;
                    this.sizeNeededToChangeDirection += 2;
                }

                return new TwoDSpiralNumberResult(this.currNumber, true);
            }

            return new TwoDSpiralNumberResult(this.currNumber, false);
        }

        public IEnumerable<TwoDSpiralNumberResult> GetNextBlock()
        {
            var result = new List<TwoDSpiralNumberResult>();
            if (this.totalAnglesMet == -1)
            {
                result.Add(this.GetNext());
                return result;
            }

            int totalAnglesMet = 0;
            while (totalAnglesMet < 4)
            {
                var next = this.GetNext();
                result.Add(next);
                if (next.IsAtAngle)
                    totalAnglesMet++;
            }

            return result;
        }

        public IEnumerable<TwoDSpiralNumberResult> GetNextAngles()
        {
            var block = this.GetNextBlock()
                .Where(x => x.IsAtAngle)
                .ToList();

            return block;
        }
    }
}