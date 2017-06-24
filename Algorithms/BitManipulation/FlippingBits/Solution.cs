using System;

namespace FlippingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                uint N = UInt32.Parse(Console.ReadLine());

                Console.WriteLine(~N);
            }
        }
    }
}
