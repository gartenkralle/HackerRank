using System;

namespace CountingValleys
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string steps = Console.ReadLine();

            int height = 0;
            int count = 0;

            foreach(char c in steps)
            {
                if (c == 'U')
                {
                    height++;
                }
                else if (c == 'D')
                {
                    if (height == 0)
                        count++;

                    height--;
                }
            }

            Console.WriteLine(count);
        }
    }
}
