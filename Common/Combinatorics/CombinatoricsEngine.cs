namespace Common.Combinatorics
{
    public class CombinatoricsEngine<T>
        where T : struct
    {
        private readonly CombinatoricsEngine<T> childCombinatorics;
        private readonly IEnumerable<T> possibleValues;
        private readonly bool distinctCombinations;

        private int currIndex;

        public CombinatoricsEngine(CombinatoricsEngine<T> childCombinatorics, IEnumerable<T> possibleValues, bool distinctCombinations)
        {
            this.childCombinatorics = childCombinatorics;
            this.possibleValues = possibleValues;
            this.distinctCombinations = distinctCombinations;
            this.currIndex = 0;
            this.IsOverflown = false;
        }

        public bool IsOverflown { get; private set; }

        public IEnumerable<T> GetNextCombination()
        {
            List<T> values = new List<T>();
            this.GetNextCombination(values);
            return values;
        }

        private void GetNextCombination(ICollection<T> values)
        {
            var currValue = this.GetCurrValue();
            if (this.distinctCombinations)
            {
                if (values.Any(x => x.Equals(currValue)))
                {
                    this.MoveToNextValue();
                    if (this.IsOverflown)
                    {
                        return;
                    }

                    this.GetNextCombination(values);
                    return;
                }
            }

            values.Add(currValue);

            if (this.childCombinatorics is not null)
            {
                if (this.MustMoveNext())
                {
                    this.MoveToNextValue();
                }

                this.childCombinatorics.GetNextCombination(values);
            }

            if (this.MustMoveNext())
            {
                this.MoveToNextValue();
            }
        }

        private bool MustMoveNext()
        {
            if (this.childCombinatorics != null)
            {
                if (this.childCombinatorics.IsOverflown)
                {
                    return true;
                }
            }
            else
            {
                return true;
            }

            return false;
        }

        private T GetCurrValue()
        {
            var result = this.possibleValues.ElementAt(this.currIndex);
            return result;
        }

        private void MoveToNextValue()
        {
            this.currIndex++;

            if (this.childCombinatorics is not null)
            {
                this.childCombinatorics.ResetIndex();
            }

            if (this.currIndex > this.possibleValues.Count() - 1)
            {
                this.IsOverflown = true;
            }
        }

        private void ResetIndex()
        {
            this.currIndex = 0;
            this.IsOverflown = false;

            if (this.childCombinatorics is not null)
            {
                this.childCombinatorics.ResetIndex();
            }
        }
    }
}