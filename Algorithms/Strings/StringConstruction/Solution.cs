using System;

namespace StringConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string m = Console.ReadLine();

                byte[] alphabet = new byte[26];
                int count = 0;

                foreach (char c in m)
                {
                    int index = Convert.ToInt32(c) - 97;

                    if (alphabet[index] == 0)
                    {
                        alphabet[index]++;
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
