using System;
using System.Collections.Generic;
using System.Globalization;

namespace HeapsFindTheRunningMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>(n);

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int index = list.BinarySearch(number);

                if (index < 0)
                {
                    index = ~index;
                }

                list.Insert(index, number);

                double median = 0;
                int size = list.Count;

                if ((size % 2) == 0)
                {
                    median = (list[size / 2] + list[(size / 2) - 1]) / (double)2;
                }
                else
                {
                    median = list[size / 2];
                }

                NumberFormatInfo nfi = new NumberFormatInfo();
                nfi.NumberGroupSeparator = "";

                Console.WriteLine(median.ToString("N1", nfi));
            }
        }
    }
}
