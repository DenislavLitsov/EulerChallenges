using System.Numerics;

namespace Common
{
    public static class AdvancedString
    {
        public static IEnumerable<string> GetAllPossibleCombinations(this string main)
        {
            var res = Combinate(main, 0, "", new List<int>());
            return res;
        }

        public static bool IsPalindrome(this string main)
        {
            var reversed = new String(main.Reverse().ToArray());
            return main == reversed;
        }

        private static IEnumerable<string> Combinate(string charsToCombine, int charIndex, string currentBuiltString, List<int> usedIndexes)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < charsToCombine.Length; i++)
            {
                if (usedIndexes.Contains(i))
                    continue;

                var newUsedIndexes = usedIndexes.DeepCopy().ToList();
                newUsedIndexes.Add(i);

                string tempString = currentBuiltString + charsToCombine[i];
                if (tempString.Length < charsToCombine.Length)
                {
                    result.AddRange(Combinate(charsToCombine, charIndex + 1, tempString, newUsedIndexes));
                }
                else
                {
                    result.Add(tempString);
                }
            }

            return result;
        }
    }
}
