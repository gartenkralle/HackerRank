using System;
using System.Collections.Generic;

namespace QueueUsingTwoStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = int.Parse(Console.ReadLine());

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < q; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int type = arr[0];

                switch (type)
                {
                    case 1:
                        queue.Enqueue(arr[1]);
                        break;
                    case 2:
                        queue.Dequeue();
                        break;
                    case 3:
                        Console.WriteLine(queue.Peek());
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
