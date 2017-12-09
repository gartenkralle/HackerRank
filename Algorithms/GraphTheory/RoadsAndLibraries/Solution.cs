using System;
using System.Collections.Generic;

namespace RoadsAndLibraries
{
    class Program
    {
        static void Main(String[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int[] nmclcr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                int n = nmclcr[0];
                int m = nmclcr[1];
                int clib = nmclcr[2];
                int croad = nmclcr[3];

                int[][] edgeList = new int[m][];

                for (int j = 0; j < m; j++)
                {
                    int[] uv = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                    edgeList[j] = new int[2];
                    edgeList[j][0] = uv[0] - 1;
                    edgeList[j][1] = uv[1] - 1;
                }

                Console.WriteLine(GetMinimumCosts(n, edgeList, clib, croad));
            }
        }

        private static long GetMinimumCosts(int n, int[][] edgeList, int clib, int croad)
        {
            long minimalCosts = 0;

            Graph graph = new Graph(n);
            graph.AddEdges(edgeList);

            List<int> componentsCount = graph.GetConnectedComponentsCount();

            for (int i = 0; i < componentsCount.Count; i++)
            {
                if (clib > croad)
                {
                    minimalCosts += clib;

                    if ((componentsCount[i] - 1) > 0)
                        minimalCosts += ((componentsCount[i] - 1) * croad);
                }
                else
                {
                    minimalCosts += (componentsCount[i] * clib);
                }
            }

            return minimalCosts;
        }
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

        private Node[] nodes;

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
