using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            int K = Int32.Parse(Console.ReadLine()) % 26;
            char[] res = new char[N];

            for (int i = 0; i < N; i++)
            {
                if ((S[i] >= 'A') && (S[i] <= 'Z'))
                {
                    if ((S[i] + K) <= 'Z')
                        res[i] = (char)(S[i] + K);
                    else
                        res[i] = (char)(S[i] + K - 26);
                }
                else if ((S[i] >= 'a') && (S[i] <= 'z'))
                {
                    if ((S[i] + K) <= 'z')
                        res[i] = (char)(S[i] + K);
                    else
                        res[i] = (char)(S[i] + K - 26);
                }
                else
                    res[i] = S[i];
            }

            Console.WriteLine(res);
        }
    }
}
