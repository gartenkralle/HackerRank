using System;

namespace SecurityMessageSpaceAndCiphertextSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine();

            foreach (char c in m)
            {
                int number = int.Parse(c.ToString());

                if (number == 9)
                    Console.Write(0);
                else
                    Console.Write(number + 1);
            }

            Console.WriteLine();
        }
    }
}
