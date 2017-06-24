using System;

namespace SimpleArraySum
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int result = SimpleArraySum(arr);

            Console.WriteLine(result);
        }

        static int SimpleArraySum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
