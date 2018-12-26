using System;

namespace CompoundEventProbability
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] X = { true, true, true, true, false, false, false };
            bool[] Y = { true, true, true, true, true, false, false, false, false };
            bool[] Z = { true, true, true, true, false, false, false, false };

            Random random = new Random(DateTime.Now.Millisecond);

            int positiveCount = 0;

            for (int i = 0; i < 100000; i++)
            {
                int rx = random.Next(7);
                int ry = random.Next(9);
                int rz = random.Next(8);

                int trueCount = 0;
                int falseCount = 0;

                if (X[rx] == true) trueCount++; else falseCount++;
                if (Y[ry] == true) trueCount++; else falseCount++;
                if (Z[rz] == true) trueCount++; else falseCount++;

                if ((trueCount == 2) && (falseCount == 1))
                    positiveCount++;
            }

            Console.WriteLine(positiveCount / (float)100000);
        }
    }
}
