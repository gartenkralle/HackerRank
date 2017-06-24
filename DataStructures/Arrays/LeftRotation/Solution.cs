using System;
using System.Collections.Generic;
using System.Linq;

namespace LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            int n = Int32.Parse(arr[0]);
            int d = Int32.Parse(arr[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            int[] result = leftRotate(a, d);

            Console.WriteLine(String.Join(" ", result));
        }

        private static int[] leftRotate(int[] a, int d)
        {
            List<int> numbers = a.ToList();

            numbers.AddRange(numbers.GetRange(0, d));
            numbers.RemoveRange(0, d);

            return numbers.ToArray();
        }
    }
}
