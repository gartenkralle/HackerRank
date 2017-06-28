using System;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack stack = new Stack();

            for (int i = 0; i < N; i++)
            {
                int[] query = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                if (query[0] == 1)
                    stack.Push(query[1]);
                else if (query[0] == 2)
                    stack.Pop();
                else
                    Console.WriteLine(stack.GetMaximumElement());
            }
        }
    }

    class Stack
    {
        private int[] arr;
        private int indexArr = -1;
        private int[] max;
        private int indexMax = -1;

        public Stack()
        {
            arr = new int[100000];
            max = new int[100000];
        }

        public int GetMaximumElement()
        {
            return max[indexMax];
        }

        public void Push(int item)
        {
            indexArr++;
            arr[indexArr] = item;

            if ((indexMax == -1) || (item >= max[indexMax]))
            {
                indexMax++;
                max[indexMax] = item;
            }
        }

        public int Pop()
        {
            int element = arr[indexArr];
            indexArr--;

            if (element == max[indexMax])
            {
                indexMax--;
            }

            return element;
        }
    }
}
