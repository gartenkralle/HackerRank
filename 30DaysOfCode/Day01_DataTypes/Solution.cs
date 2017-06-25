using System;

namespace Day1_DataTypes
{
    class Program
    {
        static void Main(String[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

            int i2 = Int32.Parse(Console.ReadLine());
            double d2 = Double.Parse(Console.ReadLine());
            string s2 = Console.ReadLine();

            Console.WriteLine(i + i2);
            Console.WriteLine((d + d2).ToString("0.0"));
            Console.WriteLine(s + s2);
        }
    }
}
