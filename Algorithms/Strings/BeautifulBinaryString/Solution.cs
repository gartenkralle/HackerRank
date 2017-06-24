using System;

namespace BeautifulBinaryString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string B = Console.ReadLine();

            int count = 0;

            while(B.Contains("01010"))
                ReplaceAndCount(ref B, "01010", "01110", ref count);

            while (B.Contains("010"))
                ReplaceAndCount(ref B, "010", "000", ref count);

            Console.WriteLine(count);
        }

        static void ReplaceAndCount(ref String input, String search, String replacement, ref int count)
        {
            int index = input.IndexOf(search);
            input = input.Remove(index, replacement.Length);
            input = input.Insert(index, replacement);

            count++;
        }
    }
}
