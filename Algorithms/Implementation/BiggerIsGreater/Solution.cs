using System;
using System.Collections.Generic;
using System.Linq;

namespace BiggerIsGreater
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                int index = -1;

                for (int j = (arr.Length - 1); j > 0; j--)
                {
                    if (arr[j - 1] < arr[j])
                    {
                        index = (j - 1);
                        break;
                    }
                }

                if (index != -1)
                {
                    List<char> list = new List<char>();

                    for (int j = index; j < arr.Length; j++)
                        list.Add(arr[j]);

                    list.Sort();
                    arr[index] = list.First(x => (x > arr[index]));
                    list.Remove(arr[index]);

                    for (int j = 0; j < list.Count; j++)
                        arr[index + 1 + j] = list[j];

                    Console.WriteLine(arr);
                }
                else
                    Console.WriteLine("no answer");
            }
        }

        static void swap(int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }
    }
}
