namespace Common.AdvancedMath.RomanNumbers
{
    public class RomanNumber
    {
        public RomanNumber(string number)
        {
            this.Number = number;
            this.CalculatedValue = RomanNumberCalculator.CalculateValue(this.Number);
        }

        public string Number { get; private set; }

        public int CalculatedValue { get; private set; }

        public void MinimizeNumber()
        {
            var oldVal = this.Number;
            
            var initValue = this.Number;
            this.Number = RomanNumberCalculator.MinimizeSize(this.Number);
            
            Console.WriteLine($"{oldVal} -> {this.Number}; Saved: {oldVal.Length - this.Number.Length}");
        }
    }
}