using System;

namespace MisereNim
{
    class Program
    {
        static void Main(String[] args)
        {
            int g = int.Parse(Console.ReadLine());

            for (int i = 0; i < g; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] s = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                if (ContainsOnesOnly(s))
                {
                    if (IsAmountEven(s))
                    {
                        Console.WriteLine("First");
                    }
                    else
                    {
                        Console.WriteLine("Second");
                    }
                }
                else
                {
                    int result = 0;

                    foreach (int a in s)
                    {
                        result ^= a;
                    }

                    if (result == 0)
                    {
                        Console.WriteLine("Second");
                    }
                    else
                    {
                        Console.WriteLine("First");
                    }
                }
            }
        }

        private static bool IsAmountEven(int[] numbers)
        {
            return (numbers.Length % 2) == 0;
        }

        private static bool ContainsOnesOnly(int[] numbers)
        {
            foreach (int s in numbers)
            {
                if (s != 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
