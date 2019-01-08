using System;
using System.Collections.Generic;
using System.Linq;

namespace DigitCameraAutodetectDayOrNight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] image = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ', ',' }), int.Parse);

            int sum = 0;
            int maxSum = 255 * image.Length;

            for (int i = 0; i < image.Length; i++)
            {
                sum += image[i];
            }

            if (sum / (float)maxSum >= 0.5)
                Console.WriteLine("day");
            else
                Console.WriteLine("night");
        }
    }
}
