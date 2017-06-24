using System;

namespace FunnyString
{
    class FunnyString
    {
        static void Main(String[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                string s = Console.ReadLine();
                string isFunny = "Funny";
                int N = s.Length;

                for (int j = 1; j < N; j++)
                {
                    if (Math.Abs(s[j] - s[j - 1]) != Math.Abs(s[(N - 1) - (j)] - s[(N - 1) - (j - 1)]))
                    {
                        isFunny = "Not Funny";
                        break;
                    }
                }

                Console.WriteLine(isFunny);
            }
        }
    }
}
