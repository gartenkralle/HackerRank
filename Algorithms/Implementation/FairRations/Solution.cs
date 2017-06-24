using System;

namespace FairRations
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int sum = 0;
            int count = 0;
            bool stack = false;

            for (int i = 0; i < B.Length; i++)
            {
                if (stack && !IsEven(B[i]))
                {
                    count++;
                    sum += (2 * count);
                    stack = false;
                    count = 0;
                }
                else if (stack)
                    count++;
                else if (!IsEven(B[i]))
                    stack = true;
            }

            if (stack)
                Console.WriteLine("NO");
            else
                Console.WriteLine(sum);
        }

        static bool IsEven(int number)
        {
            return (number % 2) == 0;
        }
    }
}
