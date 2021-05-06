using System;

namespace LaptopBatteryLife
{
    class Program
    {
        public static void Main(string[] args)
        {
            double timeCharged = Convert.ToDouble(Console.ReadLine().Trim());

            if (timeCharged < 4)
            {
                Console.WriteLine((2 * timeCharged).ToString("F"));
            }
            else
            {
                Console.WriteLine(8.ToString("F"));
            }
        }
    }
}
