using System;

namespace StrangeCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            long t = long.Parse(Console.ReadLine());

            int column = (int)(Math.Log((t + 2) / 3) / Math.Log(2));
            long t_base = ((3 * (long)Math.Pow(2, column)) - 2);
            long v_base = (3 * (long)Math.Pow(2, column));
            long diff = t - t_base;
            long v = v_base - diff;

            Console.WriteLine(v);
        }
    }
}
