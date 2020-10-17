using System;

class Program
{
    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();

        int result = CommonChild(s1, s2);

        Console.WriteLine(result);
    }

    static int CommonChild(string s1, string s2)
    {
        int[,] lengths = new int[s1.Length + 1, s1.Length + 1];

        for (int i = 1; i < s1.Length + 1; i++)
        {
            for (int j = 1; j < s2.Length + 1; j++)
            {
                if (s1[i - 1] != s2[j - 1])
                {
                    lengths[i, j] = Math.Max(lengths[i, j - 1], lengths[i - 1, j]);
                }
                else
                {
                    lengths[i, j] = lengths[i - 1, j - 1] + 1;
                }
            }
        }

        return lengths[s1.Length, s1.Length];
    }
}
