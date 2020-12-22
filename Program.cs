using System;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] id = { 2, -10, 4, -10000, -6, -100, 20, 30, 40, -400, -5000, 2000, };
            int count = id.Length;
            int min = id[0];
            int max = id[0];
            int res = 0;

            for (int x = 0; x < id.Length; x++)
            {
                res = getMin(id[x], min);
                min = res;
            }

            for (int x = 0; x < id.Length; x++)
            {
                res = getMax(id[x], max);
                max = res;
            }

            System.Console.WriteLine($"Smallest number in the array is {min} \nLargest number in the array is {max}");

        }
        public static int getMin(int array_value, int min)
        {
            int res = 0;
            if (min < array_value)
            {
                res = min;
            }
            else
            {
                res = array_value;
            }
            return res;
        }

        public static int getMax(int array_value, int max)
        {
            int res = 0;
            if (max > array_value)
            {
                res = max;
            }
            else
            {
                res = array_value;
            }
            return res;
        }
    }
}
