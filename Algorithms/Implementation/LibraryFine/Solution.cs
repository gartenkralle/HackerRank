using System;

namespace LibraryFine
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] actualDate = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int actualD = actualDate[0];
            int actualM = actualDate[1];
            int actualY = actualDate[2];

            int[] expectedDate = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int expectedD = expectedDate[0];
            int expectedM = expectedDate[1];
            int expectedY = expectedDate[2];

            if (actualY > expectedY)
            {
                Console.WriteLine(10000);
            }
            else if ((actualM > expectedM) && (actualY == expectedY))
            {
                Console.WriteLine(500 * (actualM - expectedM));
            }
            else if ((actualD > expectedD) && (actualM == expectedM) && (actualY == expectedY))
            {
                Console.WriteLine(15 * (actualD - expectedD));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
