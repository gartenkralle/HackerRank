using System;
using System.Text;

namespace RecursiveDigitSum
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');
            string n = nk[0];
            int k = int.Parse(nk[1]);

            Console.WriteLine(GetSuperDigit(n, k));
        }

        private static int GetSuperDigit(string n, int k)
        {
            int sumN = SumOfDigits(n);
            n = GetCycleString(sumN, k);

            return SumOfDigits(n);
        }

        private static string GetCycleString(int sumN, int k)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < k; i++)
            {
                stringBuilder.Append(sumN);
            }

            return stringBuilder.ToString();
        }

        private static int SumOfDigits(string n)
        {
            if (n.Length == 1)
                return int.Parse(n);

            int sum = 0;

            for (int i = 0; i < n.Length; i++)
            {
                sum += int.Parse(n[i].ToString());
            }

            return SumOfDigits(sum.ToString());
        }
    }
}
