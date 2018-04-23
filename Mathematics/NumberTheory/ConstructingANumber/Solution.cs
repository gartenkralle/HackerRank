using System;

namespace ConstructingANumber
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                string result = CanConstruct(a);

                Console.WriteLine(result);
            }
        }

        static string CanConstruct(int[] a)
        {
            int sum = 0;

            foreach (int number in a)
            {
                sum += GetSumOfDigits(number);
            }

            if ((sum % 3) == 0)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        private static int GetSumOfDigits(int number)
        {
            int sum = 0;
            String arr = Convert.ToString(number);

            foreach (char character in arr)
            {
                sum += Convert.ToInt32(character);
            }

            return sum;
        }
    }
}
