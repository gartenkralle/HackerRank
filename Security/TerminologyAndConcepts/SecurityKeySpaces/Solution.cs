using System;

namespace SecurityKeySpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine();
            int e = int.Parse(Console.ReadLine());

            foreach (char c in m)
            {
                Console.Write((int.Parse(c.ToString()) + e) % 10);
            }

            Console.WriteLine();
        }
    }
}
