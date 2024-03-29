using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;

namespace Common
{
    public static class ExtendedArrays
    {
        public static void Print<T>(this IEnumerable<T> list) where T : struct
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

        public static IEnumerable<T> DeepCopy<T>(this IEnumerable<T> list) where T : struct
        {
            var newList = new List<T>();
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

        public static string ConcentrateArray<T>(this IEnumerable<T> list) where T : struct
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in list)
            {
                stringBuilder.Append(item.ToString());
            }

            return stringBuilder.ToString();
        }

        public static string Stringify(this IEnumerable<char> list)
        {
            string res = new string(list.ToArray());
            return res;
        }
        public static string Stringify(this char[] list)
        {
            string res = new string(list);
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
