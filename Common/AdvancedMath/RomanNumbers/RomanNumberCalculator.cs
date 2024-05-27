namespace Common.AdvancedMath.RomanNumbers
{
    public class RomanNumberCalculator
    {
        private static Dictionary<char, int> values = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        public RomanNumberCalculator()
        {
        }

        public static int CalculateValue(string numbers)
        {
            int res = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                char currChar = numbers[i];
                int currCharValue = values[currChar];

                if (i < numbers.Length - 1)
                {
                    char nextChar = numbers[i + 1];
                    int nextValue = values[nextChar];

                    if (nextValue > currCharValue)
                    {
                        var valueToAdd = nextValue - currCharValue;
                        res += valueToAdd;
                        i++;
                    }
                    else
                    {
                        res += currCharValue;
                    }
                }
                else
                {
                    var valueToAdd = currCharValue;
                    res += valueToAdd;
                }
            }

            return res;
        }

        public static string MinimizeSize(string numbers)
        {
            string result = numbers;
            string newNum = result;

            do
            {
                result = newNum;
                newNum = result
                    .Replace("IIIII", "V")
                    .Replace("VV", "X")
                    .Replace("XXXXX", "L")
                    .Replace("LL", "C")
                    .Replace("CCCCC", "D")
                    .Replace("DD", "M")
                    .Replace("VIIII", "IX")
                    //.Replace("IIII", "IV")
                    .Replace("XXXXXXXXX", "XC")
                    //.Replace("XXXX", "XL")
                    .Replace("CCCCCCCCCC", "CM");
                //.Replace("CCCC", "CD");

                if (newNum.Contains('V') == false)
                {
                    string tempNum = newNum.Replace("IIII", "IV");
                    if (tempNum.ToList().Count(x => x == 'V') == 1)
                    {
                        newNum = tempNum;
                    }
                }

                if (newNum.Contains('L') == false)
                {
                    string tempNum = newNum.Replace("XXXX", "XL");
                    if (tempNum.ToList().Count(x => x == 'L') == 1)
                    {
                        newNum = tempNum;
                    }
                }

                newNum = newNum.Replace("LXXXX", "XC");

                if (newNum.Contains('D') == false)
                {
                    string tempNum = newNum.Replace("CCCC", "CD");
                    if (tempNum.ToList().Count(x => x == 'D') == 1)
                    {
                        newNum = tempNum;
                    }
                }

                newNum = newNum.Replace("DCCCC", "CM");
            } while (newNum != result);

            return result;
        }

        public static bool ValidateNumber(string numbers)
        {
            var numbersAsChars = numbers.ToList();
            if (numbersAsChars.Count(x => x == 'D') > 1)
            {
                return false;
            }

            if (numbersAsChars.Count(x => x == 'L') > 1)
            {
                return false;
            }

            if (numbersAsChars.Count(x => x == 'V') > 1)
            {
                return false;
            }

            return true;
        }
    }
}