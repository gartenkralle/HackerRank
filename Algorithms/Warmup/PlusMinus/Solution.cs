using System;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            string[] row = Console.ReadLine().Split(' ');

            int pos = 0;
            int neg = 0;
            int zero = 0;

            for (int i = 0; i < N; i++)
            {
                if (Int32.Parse(row[i]) > 0)
                    pos++;
                else if (Int32.Parse(row[i]) < 0)
                    neg++;
                else
                    zero++;
            }

            Console.WriteLine((float)pos/N);
            Console.WriteLine((float)neg/N);
            Console.WriteLine((float)zero/N);
        }
    }
}
