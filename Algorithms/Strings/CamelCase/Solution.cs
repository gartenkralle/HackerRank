using System;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count = 1;

            foreach(char c in s)
            {
                if (Char.IsUpper(c))
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
