using System;

namespace SecurityEncryptionScheme
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(faculty(n));
        }

        static int faculty(int n)
        {
            if (n == 1)
                return 1;

            return n * faculty(n-1);
        }
    }
}
