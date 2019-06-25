using System;
using System.Collections.Generic;
using System.Linq;

namespace FraudulentActivityNotifications
{
    class Program
    {
        static void Main()
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);
            int d = Convert.ToInt32(nd[1]);

            int[] expenditure = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int result = ActivityNotifications(expenditure, d);

            Console.WriteLine(result);
        }

        static int ActivityNotifications(int[] expenditure, int d)
        {
            int result = 0;

            SortedArray sortedArray = new SortedArray(expenditure.Take(d));

            for (int i = 0; i < expenditure.Length - d; i++)
            {
                float median = sortedArray.GetMedian();

                if (expenditure[i + d] >= 2 * median)
                {
                    result++;
                }

                sortedArray.Replace(expenditure[i], expenditure[i + d]);
            }

            return result;
        }
    }

    class SortedArray
    {
        private readonly int[] array;
        readonly int count;

        public SortedArray(IEnumerable<int> collection)
        {
            array = new int[201];
            count = collection.Count();

            foreach (int number in collection)
            {
                array[number]++;
            }
        }

        public void Replace(int oldNumber, int newNumber)
        {
            array[oldNumber]--;
            array[newNumber]++;
        }

        public float GetMedian()
        {
            float result;

            if (IsEven(count))
            {
                result = (GetElement((count / 2) - 1) + GetElement(count / 2)) / 2.0f;
            }
            else
            {
                result = GetElement(count / 2);
            }

            return result;
        }

        private int GetElement(int index)
        {
            int currentIndex = -1;

            for (int i = 0; i < 201; i++)
            {
                currentIndex += array[i];

                if (currentIndex >= index)
                    return i;
            }

            return -1;
        }

        private static bool IsEven(int number)
        {
            return (number % 2) == 0;
        }
    }
}
