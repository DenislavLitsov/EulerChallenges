using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Common
{
    public static class ExtendedArrays
    {
        public static void Print(this IEnumerable<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void Print(this IEnumerable<long> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void Print(this IEnumerable<double> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void Print(this IEnumerable<float> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void Print(this IEnumerable<decimal> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void Print(this IEnumerable<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static int Product(this IEnumerable<int> list)
        {
            int result = 1;
            foreach (var item in list)
            {
                result *= item;
            }

            return result;
        }
        public static long Product(this IEnumerable<long> list)
        {
            long result = 1;
            foreach (var item in list)
            {
                result *= item;
            }

            return result;
        }
        public static double Product(this IEnumerable<double> list)
        {
            double result = 1;
            foreach (var item in list)
            {
                result *= item;
            }

            return result;
        }
        public static float Product(this IEnumerable<float> list)
        {
            float result = 1;
            foreach (var item in list)
            {
                result *= item;
            }

            return result;
        }
        public static decimal Product(this IEnumerable<decimal> list)
        {
            decimal result = 1;
            foreach (var item in list)
            {
                result *= item;
            }

            return result;
        }

        public static IEnumerable<int> DeepCopy(this IEnumerable<int> list)
        {
            var newList = new List<int>();
            foreach (var item in list)
            {
                newList.Add(item);
            }

            return newList;
        }
        public static IEnumerable<long> DeepCopy(this IEnumerable<long> list)
        {
            var newList = new List<long>();
            foreach (var item in list)
            {
                newList.Add(item);
            }

            return newList;
        }
        public static IEnumerable<double> DeepCopy(this IEnumerable<double> list)
        {
            var newList = new List<double>();
            foreach (var item in list)
            {
                newList.Add(item);
            }

            return newList;
        }
        public static IEnumerable<float> DeepCopy(this IEnumerable<float> list)
        {
            var newList = new List<float>();
            foreach (var item in list)
            {
                newList.Add(item);
            }

            return newList;
        }
        public static IEnumerable<string> DeepCopy(this IEnumerable<string> list)
        {
            var newList = new List<string>();
            foreach (var item in list)
            {
                newList.Add(item);
            }

            return newList;
        }

        public static string Stringify(this List<char> list)
        {
            string res = "";
            list.ForEach((char c) => { res += c; });

            return res;
        }

        public static string Stringify(this IEnumerable<char> list)
        {
            string res = "";
            foreach (char c in list)
            {
                res += c;
            }

            return res;
        }

        public static string Stringify(this char[] list)
        {
            string res = "";
            foreach (char c in list)
            {
                res += c;
            }

            return res;
        }

        public static long GetSumOfNumbers(this string str)
        {
            long result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                result += long.Parse(str[i].ToString());
            }

            return result;
        }

        public static long GetProductOfNumbers(this string str)
        {
            long result = 1;
            for (int i = 0; i < str.Length; i++)
            {
                result *= long.Parse(str[i].ToString());
            }

            return result;
        }
    }
}
