namespace Common.Combinatorics
{
    public class Combination<T>
    {
        public Combination(IEnumerable<T> values)
        {
            this.Values = values;
        }

        public IEnumerable<T> Values { get; }
    }
}
