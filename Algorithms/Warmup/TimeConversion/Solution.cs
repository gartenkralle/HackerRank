using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();

            string result = timeConversion(time);
            Console.WriteLine(result);
        }

        static string timeConversion(string time)
        {
            int hh = Int32.Parse(time.Substring(0, 2));
            int min = Int32.Parse(time.Substring(3, 2));
            int sec = Int32.Parse(time.Substring(6, 2));

            if ((hh != 12) && (time.Substring(time.Length - 2) == "PM"))
                hh += 12;

            if ((hh == 12) && (time.Substring(time.Length - 2) == "AM"))
                hh -= 12;

            return hh.ToString("D2") + ":" + min.ToString("D2") + ":" + sec.ToString("D2");
        }
    }
}
