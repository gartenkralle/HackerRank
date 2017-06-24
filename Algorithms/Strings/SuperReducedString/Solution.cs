using System;

namespace SuperReducedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            for (int i = 0; i < (s.Length - 1); i++)
            {
                if (s[i] == s[i + 1])
                {
                    s = s.Remove(i, 2);
                    i = -1;
                }
            }

            if (s == String.Empty)
                Console.WriteLine("Empty String");
            else
                Console.WriteLine(s);

        }
    }
}
