using System;

namespace Day10_BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string s = "";

            while (n != 0)
            {
                s += (n % 2);
                n /= 2;
            }

            int maxCount = 0;
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    count++;

                    if (count > maxCount)
                        maxCount = count;
                }
                else
                {
                    count = 0;
                }


            }

            Console.WriteLine(maxCount);
        }
    }
}
