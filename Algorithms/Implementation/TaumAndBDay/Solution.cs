using System;

namespace TaumAndBDay
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] BW = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int B = BW[0];
                int W = BW[1];

                int[] XYZ = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int X = XYZ[0];
                int Y = XYZ[1];
                int Z = XYZ[2];

                Console.WriteLine(GetMinUnits(B, W, X, Y, Z));
            }
        }

        static long GetMinUnits(int B, int W, int X, int Y, int Z)
        {
            long minUnits;

            if (X < Y)
            {
                minUnits = ((long)B * X);

                if (Y < (X + Z))
                    minUnits += ((long)W * Y);
                else
                    minUnits += ((long)W * (X + Z));
            }
            else if (Y < X)
            {
                minUnits = ((long)W * Y);

                if (X < (Y + Z))
                    minUnits += ((long)B * X);
                else
                    minUnits += ((long)B * (Y + Z));
            }
            else
            {
                minUnits = ((long)B * X) + ((long)W * Y);
            }

            return minUnits;
        }
    }
}
