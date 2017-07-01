using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<Operation> operations = new Stack<Operation>();

            for (int i = 0; i < Q; i++)
            {
                string[] query = Console.ReadLine().Split(' ');
                int t = int.Parse(query[0]);
                int k;
                string W;

                Operation operation;

                switch(t)
                {
                    case 1:
                        W = query[1];

                        operation = new Operation();
                        operation.T = t;
                        operation.K = W.Length;
                        operations.Push(operation);

                        text.Append(W);
                        break;

                    case 2:
                        k = int.Parse(query[1]);
                        W = text.ToString().Substring(text.Length - k);

                        operation = new Operation();
                        operation.T = t;
                        operation.W = W;
                        operations.Push(operation);

                        text.Remove(text.Length - k, k);
                        break;

                    case 3:
                        k = int.Parse(query[1]);
                        Console.WriteLine(text[k - 1]);
                        break;

                    case 4:
                        Operation lastOperation = operations.Pop();

                        switch(lastOperation.T)
                        {
                            case 1:
                                text.Remove(text.Length - lastOperation.K, lastOperation.K);
                                break;

                            case 2:
                                text.Append(lastOperation.W);
                                break;
                        }

                        break;
                }
            }
        }
    }

    class Operation
    {
        public int T { get; set; }
        public string W { get; set; }
        public int K { get; set; }
    }
}
