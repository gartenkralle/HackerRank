using System;
using System.Collections.Generic;

namespace BFSShortestReachInAGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] NM = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

                int N = NM[0];
                int M = NM[1];

                int[][] coordinates = new int[M][];

                for (int j = 0; j < M; j++)
                {
                    coordinates[j] = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
                }

                int S = Int32.Parse(Console.ReadLine());

                List<int> res = new List<int>();
                Node[] nodes = new Node[N];

                for (int j = 0; j < N; j++)
                    nodes[j] = new Node();

                for (int j = 0; j < M; j++)
                {
                    int[] coordinate = coordinates[j];

                    nodes[coordinate[0] - 1].Adjacent.Add(nodes[coordinate[1] - 1]);
                    nodes[coordinate[1] - 1].Adjacent.Add(nodes[coordinate[0] - 1]);
                }

                Node startNode = nodes[S - 1];

                for (int j = 0; j < N; j++)
                {
                    Node targetNode = nodes[j];

                    if (startNode != targetNode)
                    {
                        BFS(startNode, targetNode);
                        res.Add((targetNode.Distance == 0) ? (-1) : (6 * targetNode.Distance));
                        ResetNodes(nodes);
                    }
                }

                Console.WriteLine(String.Join(" ", res.ToArray()));
            }
        }

        static void ResetNodes(Node[] nodes)
        {
            for (int i = 0; i < nodes.Length; i++)
            {
                nodes[i].ResetNode();
            }
        }

        static bool BFS(Node startNode, Node targetNode)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(startNode);
            startNode.Visited = true;

            while (queue.Count != 0)
            {
                Node node = queue.Dequeue();

                if (node == targetNode)
                {
                    return true;
                }

                foreach (Node child in node.Adjacent)
                {
                    if (child.Visited == false)
                    {
                        child.Visited = true;
                        child.Distance = node.Distance + 1;
                        queue.Enqueue(child);
                    }
                }
            }

            return false;
        }
    }

    public class Node
    {
        public List<Node> Adjacent { get; set; }

        public bool Visited { get; set; }
        public int Distance { get; set; }

        public Node()
        {
            Adjacent = new List<Node>();

            ResetNode();
        }

        public void ResetNode()
        {
            Visited = false;
            Distance = 0;
        }
    }
}
