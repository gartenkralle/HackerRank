using System;

namespace DayOfTheProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());

            if (y > 1918)
            {
                if ((y % 400 == 0) || ((y % 4 == 0) && (y % 100 != 0)))
                    Console.WriteLine("12.09." + y);
                else
                    Console.WriteLine("13.09." + y);
            }
            else if (y < 1918)
            {
                if (y % 4 == 0)
                    Console.WriteLine("12.09." + y);
                else
                    Console.WriteLine("13.09." + y);
            }
            else
            {
                Console.WriteLine("26.09." + y);
            }
        }
    }
}
