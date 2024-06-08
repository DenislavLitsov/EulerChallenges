using System.Text;

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
                this.numbers = value;

                //StringBuilder stringBuilder = new StringBuilder();
                //foreach (var number in numbers)
                //{
                //    stringBuilder.Append($"{number},");
                //}
                //
                //this.CachedNumbers = stringBuilder.ToString();
            }
        }

        public string CachedNumbers { get; private set; }

        public int GetSum
        {
            get
            {
                return this.Numbers.Sum();
            }
        }

        public static SumNumber CombineNumbers(int num, SumNumber sum)
        {
            var numbers = new List<int>(sum.Numbers.Count() + 1);
            numbers.Add(num);
            foreach (var item in sum.Numbers)
            {
                numbers.Add(item);
            }

            //numbers = numbers.OrderBy(x => x).ToList();
            return new SumNumber(numbers);
        }
    }
}
