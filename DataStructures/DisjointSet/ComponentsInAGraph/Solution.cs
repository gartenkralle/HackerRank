using System;
using System.Collections.Generic;
using System.Linq;

namespace ComponentsInAGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[][] edges = new int[N][];

            for (int i = 0; i < N; i++)
            {
                int[] edge = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                edges[i] = new int[2];
                edges[i][0] = edge[0] - 1;
                edges[i][1] = edge[1] - 1;
            }

            Console.WriteLine(string.Join(" ", ComponentsInGraph(edges)));
        }

        static int[] ComponentsInGraph(int[][] edges)
        {
            Graph graph = new Graph(2 * edges.Length);
            graph.AddEdges(edges);

            int[] componentsCount = graph.GetConnectedComponentsCount().ToArray();

            return new int[] { componentsCount.Min((x) => x != 1 ? x : int.MaxValue), componentsCount.Max() };
        }

        public class Graph
        {
            private class Node
            {
                public List<Node> Nodes { get; set; }
                public int Value { get; set; }
                public bool Visited { get; set; }

                public Node(int value)
                {
                    Value = value;
                    Nodes = new List<Node>();
                }
            }

            private readonly Node[] nodes;

            public Graph(int n)
            {
                nodes = new Node[n];

                for (int i = 0; i < n; i++)
                {
                    nodes[i] = new Node(i);
                }
            }

            public void AddEdges(int[][] edges)
            {
                foreach (int[] edge in edges)
                {
                    AddEdge(edge);
                }
            }

            private void AddEdge(int[] edge)
            {
                nodes[edge[0]].Nodes.Add(nodes[edge[1]]);
                nodes[edge[1]].Nodes.Add(nodes[edge[0]]);
            }

            public List<int> GetConnectedComponentsCount()
            {
                List<int> conntectComponentsCount = new List<int>();

                foreach (Node node in nodes)
                {
                    int count = DepthFirstSearch(node);

                    if (count > 0)
                    {
                        conntectComponentsCount.Add(count);
                    }
                }

                return conntectComponentsCount;
            }

            private int DepthFirstSearch(Node node)
            {
                if (node.Visited)
                    return 0;

                node.Visited = true;

                int count = 1;

                foreach (Node adjacentNode in node.Nodes)
                {
                    count += DepthFirstSearch(adjacentNode);
                }

                return count;
            }
        }
    }
}
