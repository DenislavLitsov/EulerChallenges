﻿using System.Collections.Generic;

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
        public static void Print(this IEnumerable<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
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
