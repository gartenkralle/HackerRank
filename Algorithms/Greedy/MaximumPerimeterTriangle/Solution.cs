using System;

namespace MaximumPerimeterTriangle
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] l = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Array.Sort(l);

            string result = "-1";

            for (int i = (l.Length - 1); i >= 2; i--)
            {
                if (l[i] < (l[i - 1] + l[i - 2]))
                {
                    result = l[i - 2].ToString() + " " + l[i - 1].ToString() + " " + l[i].ToString();
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
