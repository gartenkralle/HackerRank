using System;

class BetweenTwoSets
{
    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);

        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp, Int32.Parse);

        int count = 0;

        int lowerBound = a[a.Length - 1];
        int upperBound = b[0];

        for (int x = lowerBound; x <= upperBound; x++)
        {
            if (isGreaterThan(x, a) && isLessThan(x, b))
                count++;
        }

        Console.WriteLine(count);
    }
    static bool isGreaterThan(int x, int[] A)
    {
        foreach(int a in A)
        {
            if (x % a != 0)
                return false;
        }

        return true;
    }

    static bool isLessThan(int x, int[] B)
    {
        foreach (int b in B)
        {
            if (b % x != 0)
                return false;
        }

        return true;
    }
}
