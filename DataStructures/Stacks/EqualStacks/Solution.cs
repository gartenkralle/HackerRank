using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int h1 = n[0];
            int h2 = n[1];
            int h3 = n[2];

            int[] n1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] n2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] n3 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            StackCollection stackCollection = new StackCollection();
            stackCollection.Add(new Stack(n1));
            stackCollection.Add(new Stack(n2));
            stackCollection.Add(new Stack(n3));

            while (!stackCollection.HasEqualHeights())
            {
                stackCollection.PopHeighest();
            }

            Console.WriteLine(stackCollection[0].Height);
        }
    }

    class StackCollection
    {
        private List<Stack> stacks;

        public StackCollection()
        {
            stacks = new List<Stack>();
        }

        public void Add(Stack stack)
        {
            stacks.Add(stack);
        }

        public bool HasEqualHeights()
        {
            for (int i = 0; i < (stacks.Count - 1); i++)
            {
                if (stacks[i].Height != stacks[i + 1].Height)
                    return false;
            }

            return true;
        }

        public void PopHeighest()
        {
            Stack maxStack = stacks[0];

            for (int i = 1; i < stacks.Count; i++)
            {
                if (stacks[i].Height > maxStack.Height)
                    maxStack = stacks[i];
            }

            maxStack.Pop();
        }

        public Stack this[int index]
        {
            get { return stacks[index]; }
        }
    }

    class Stack
    {
        private Queue<int> queue;

        public Stack(int[] n)
        {
            queue = new Queue<int>(n);
            Height = n.Sum();
        }

        public void Pop()
        {
            Height -= queue.Dequeue();
        }

        public int Height { get; private set; }
    }
}
