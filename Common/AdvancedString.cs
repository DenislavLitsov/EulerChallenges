namespace Common
{
    public static class AdvancedString
    {
        /// <summary>
        /// Returns the number of the amount of repeates of the argument string in the string
        /// </summary>
        public static int TotalRepeats(this string mainString, string repeatingString)
        {
            int result = 0;
            for (int i = repeatingString.Length; i < mainString.Length - repeatingString.Length; i++)
            {
                string subMainString = mainString.Substring(i, repeatingString.Length);
                if (repeatingString == subMainString)
                    result++;
            }

            return result;
        }

        /// <summary>
        /// Returns the number of the amount of repeates of the argument string in the string
        /// </summary>
        public static int TotalConsecutiveRepeats(this string mainString, string repeatingString)
        {
            int result = 0;
            for (int i = repeatingString.Length; i < mainString.Length - repeatingString.Length; i++)
            {
                string subMainString = mainString.Substring(i, repeatingString.Length);
                if (repeatingString == subMainString)
                {
                    result++;
                    i += repeatingString.Length - 1;
                }
                else
                    break;
            }

            return result;
        }
    }
}
