namespace ChallengeExecutor.Challenges.Challenges51to100.Challenge76
{
    public class SumNumber
    {
        private IEnumerable<int> numbers;

        public SumNumber(IEnumerable<int> numbers)
        {
            this.Numbers = numbers;
        }

        public IEnumerable<int> Numbers
        {
            get => numbers; 
            set
            {
                this.numbers = value.OrderBy(x => x).ToList();
            }
        }

        public int GetSum
        {
            get
            {
                return this.Numbers.Sum();
            }
        }

        public static SumNumber CombineNumbers(int num, SumNumber sum)
        {
            var numbers = new List<int>();
            numbers.Add(num);
            foreach (var item in sum.Numbers)
            {
                numbers.Add(item);
            }

            return new SumNumber(numbers);
        }
    }
}
