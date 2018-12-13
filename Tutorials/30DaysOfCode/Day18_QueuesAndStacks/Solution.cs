using System;
using System.Collections.Generic;

namespace Day18_QueuesAndStacks
{
    class Program
    {
        Stack<char> s = new Stack<char>();
        Queue<char> q = new Queue<char>();

        public void pushCharacter(char c)
        {
            s.Push(c);
        }

        public char popCharacter()
        {
            return s.Pop();
        }

        public void enqueueCharacter(char c)
        {
            q.Enqueue(c);
        }

        public char dequeueCharacter()
        {
            return q.Dequeue();
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();

            Program obj = new Program();

            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }
    }
}
