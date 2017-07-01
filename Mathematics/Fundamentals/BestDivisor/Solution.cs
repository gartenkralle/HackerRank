using System;

namespace BestDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    int digitSum = DigitSum(i);

                    if (digitSum > DigitSum(max))
                        max = i;
                    else if ((digitSum == DigitSum(max)) && (i < max))
                        max = i;
                }
            }

            Console.WriteLine(max);
        }

        static int DigitSum(int number)
        {
            int sum = 0;

            while(number != 0)
            {
                sum += (number % 10);
                number /= 10;
            }

            return sum;
        }
    }
}
