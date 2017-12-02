using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MostDistant
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] xy = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int minX = xy[0];
            int maxX = xy[0];
            int minY = xy[1];
            int maxY = xy[1];

            for (int i = 1; i < N; i++)
            {
                xy = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int x = xy[0];
                int y = xy[1];

                if (x < minX)
                    minX = x;
                else if (x > maxX)
                    maxX = x;

                if (y < minY)
                    minY = y;
                else if (y > maxY)
                    maxY = y;
            }

            double[] distances = new double[6];

            distances[0] = maxX - minX;
            distances[1] = maxY - minY;
            distances[2] = Math.Sqrt(((long)minX * minX) + ((long)maxY * maxY));
            distances[3] = Math.Sqrt(((long)maxX * maxX) + ((long)maxY * maxY));
            distances[4] = Math.Sqrt(((long)maxX * maxX) + ((long)minY * minY));
            distances[5] = Math.Sqrt(((long)minX * minX) + ((long)minY * minY));

            Console.WriteLine(distances.Max().ToExactString(6));
        }

    }

    public static class DoubleExtensions
    {
        public static string ToExactString(this Double number, int precision)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(((int)number).ToString());
            number -= ((int)number);

            sb.Append(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            for (int i = 0; i < precision; i++)
            {
                number *= 10;
                sb.Append((int)number);
                number -= ((int)number);
            }

            return sb.ToString();
        }
    }
}
