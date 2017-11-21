using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SpecialMultiple
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            Dictionary<int, long> _5Multiple90s = Get5Multiple90s();

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());

                Console.WriteLine(_5Multiple90s[N]);
            }
        }

        private static Dictionary<int, long> Get5Multiple90s()
        {
            Dictionary<int, long> _5Multiple90s = new Dictionary<int, long>();

            for (int i = 1; i <= 500; i++)
            {
                _5Multiple90s.Add(i, Get5Multiple90(i));
            }

            return _5Multiple90s;
        }

        private static long Get5Multiple90(int number)
        {
            long result = -1;

            for (int i = 1; i <= int.MaxValue; i++)
            {
                long number_90 = IntTo90(i);

                if (number_90 % number == 0)
                {
                    result = number_90;
                    break;
                }
            }

            return result;
        }

        static long IntTo90(int number)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Byte[] bytes_number = BitConverter.GetBytes(number);
            BitArray bitArray = new BitArray(bytes_number);

            foreach (bool bit in bitArray)
            {
                if (bit)
                    stringBuilder.Insert(0, "9");
                else
                    stringBuilder.Insert(0, "0");
            }

            return long.Parse(stringBuilder.ToString());
        }
    }
}
