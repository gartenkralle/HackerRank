using System;

namespace CatsAndAMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                int[] xyz = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int x = xyz[0];
                int y = xyz[1];
                int z = xyz[2];

                string result = String.Empty;

                if (Math.Abs(x - z) < Math.Abs(y - z))
                    result = "Cat A";
                else if (Math.Abs(y - z) < Math.Abs(x - z))
                    result = "Cat B";
                else
                    result = "Mouse C";

                Console.WriteLine(result);
            }
        }
    }
}
