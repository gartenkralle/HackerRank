using System;

namespace TheLoveLetterMystery
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string letter = Console.ReadLine();
                int sum = 0;

                for (int j = 0; j < (letter.Length / 2); j++)
                {
                    sum += Math.Abs(letter[j] - letter[(letter.Length - 1) - j]);
                }

                Console.WriteLine(sum);
            }
        }
    }
}
