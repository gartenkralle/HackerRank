using System;
using System.Collections.Generic;

namespace StacksBalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string result;

            for (int i = 0; i < n; i++)
            {
                string seq = Console.ReadLine();

                if (IsBalanced(seq))
                    result = "YES";
                else
                    result = "NO";

                Console.WriteLine(result);
            }
        }

        static bool IsBalanced(string seq)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in seq)
            {
                if (c == '(' || c == '{' || c == '[')
                    stack.Push(c);
                else
                {
                    if (stack.Count == 0)
                        return false;

                    if (((c == ')') && (stack.Peek() == '(')) ||
                        ((c == '}') && (stack.Peek() == '{')) ||
                        ((c == ']') && (stack.Peek() == '[')))
                        stack.Pop();
                    else
                        return false;
                }
            }

            if (stack.Count != 0)
                return false;
            else
                return true;
        }
    }
}
