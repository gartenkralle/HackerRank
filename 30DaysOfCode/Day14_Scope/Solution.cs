using System;
using System.Linq;

namespace Day14_Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] a)
        {
            elements = a;
        }

        public void computeDifference()
        {
            for (int i = 0; i < (elements.Length - 1); i++)
            {
                for (int j = (i + 1); j < elements.Length; j++)
                {
                    int currentDifference = Math.Abs(elements[i] - elements[j]);

                    if (currentDifference > maximumDifference)
                        maximumDifference = currentDifference;
                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }
}
