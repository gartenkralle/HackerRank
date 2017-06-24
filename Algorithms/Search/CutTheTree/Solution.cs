using System;
using System.Collections.Generic;

namespace CutTheTree
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = Int32.Parse(Console.ReadLine());

            int[] vertices = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));
            int[][] edges = new int[N - 1][];

            for (int i = 0; i < N - 1; i++)
            {
                edges[i] = Array.ConvertAll(Console.ReadLine().Split(' '), x => Int32.Parse(x));
            }

            Graph graph = new Graph(vertices.Length);

            for (int i = 0; i < vertices.Length; i++)
                graph[i].Value = vertices[i];

            for (int i = 0; i < edges.Length; i++)
            {
                int firstNodeIndex = edges[i][0] - 1;
                int secondNodeIndex = edges[i][1] - 1;

                graph[firstNodeIndex].AddAjacentNode(graph[secondNodeIndex]);
                graph[secondNodeIndex].AddAjacentNode(graph[firstNodeIndex]);
            }

            Console.WriteLine(graph.CalcMinValue());
        }
    }

    class Graph
    {
        private Node[] nodes;

        public Graph(int size)
        {
            nodes = new Node[size];

            for (int i = 0; i < nodes.Length; i++)
                nodes[i] = new Node();
        }

        public Node this[int index]
        {
            get { return nodes[index]; }
        }

        public int CalcMinValue()
        {
            Node root = nodes[0];
            Node.calcSubSums(root);

            int min = root.SubSum;

            for (int i = 1; i < nodes.Length; i++)
            {
                int firstSubSum = nodes[i].SubSum;
                int secondSubSum = root.SubSum - firstSubSum;

                int diff = Math.Abs(firstSubSum - secondSubSum);

                if (diff < min)
                    min = diff;
            }

            return min;
        }
    }

    class Node
    {
        public int Value { get; set; }
        public int SubSum { get; set; }
        private List<Node> adj;
        private bool Visited { get; set; }

        public Node()
        {
            adj = new List<Node>();
            Visited = false;
        }

        public void AddAjacentNode(Node node)
        {
            adj.Add(node);
        }

        public static int calcSubSums(Node node)
        {
            int sum = 0;

            node.Visited = true;

            foreach (Node adj in node.adj)
            {
                if (adj.Visited)
                    continue;

                sum += calcSubSums(adj);
            }

            node.SubSum = sum + node.Value;

            return node.SubSum;
        }
    }
}
