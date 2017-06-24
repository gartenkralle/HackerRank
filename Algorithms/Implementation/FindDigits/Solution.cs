using System;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                long N = Int64.Parse(Console.ReadLine());

                int[] divisors = GetDivisors(N);
                int count = 0;

                for(int j=0; j<divisors.Length;j++)
                {
                    if ((divisors[j] != 0) && ((N % divisors[j]) == 0))
                        count++;
                }

                Console.WriteLine(count);
            }
        }

        private static int[] GetDivisors(long number)
        {
            int digits = (int)(Math.Log10(number) + 1);
            int[] arr = new int[digits];

            for (int i = 0; i < digits; i++)
            {
                arr[i] = (int)(number % 10);
                number /= 10;
            }

            return arr;
        }
    }
}
