using System;

namespace MaximizingXOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int L = Int32.Parse(Console.ReadLine());
            int R = Int32.Parse(Console.ReadLine());

            int maxValue = 0;

            for (int a = L; a <= R; a++)
            {
                for (int b = a; b <= R; b++)
                {
                    int xor = (a | b) & (~(a & b));

                    if (xor > maxValue)
                        maxValue = xor;                    
                }
            }

            Console.WriteLine(maxValue);
        }
    }
}
