using System;
using System.Collections.Generic;

namespace EvenTree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');

            int N = Int32.Parse(nm[0]);
            int M = Int32.Parse(nm[1]);

            Node root = null;

            for (int i = 0; i < M; i++)
            {
                string[] edge = Console.ReadLine().Split(' ');

                int ui = Int32.Parse(edge[0]);
                int vi = Int32.Parse(edge[1]);

                Node node1 = new Node(ui);
                Node node2 = new Node(vi);

                if (root == null)
                    root = node1;

                root.Insert(node1, node2);
            }

            Console.WriteLine(Node.GetRemovableEdgesCount(root));
        }
    }

    class Node
    {
        private List<Node> adj;
        public int Value { get; set; }

        public Node()
        {
            adj = new List<Node>();
        }

        public Node(int value) : this()
        {
            Value = value;
        }

        public static int GetRemovableEdgesCount(Node root)
        {
            int removableEdgesCount = 0;

            getVertexCount(root, ref removableEdgesCount);

            return removableEdgesCount - 1;
        }

        private static int getVertexCount(Node root, ref int removableEdgesCount)
        {
            int vertexCount = 1;

            foreach (Node child in root.adj)
                vertexCount += getVertexCount(child, ref removableEdgesCount);

            if ((vertexCount % 2) == 0)
                removableEdgesCount++;

            return vertexCount;
        }

        public void Insert(Node node1, Node node2)
        {
            Node n1 = dfs(this, node1);
            Node n2 = dfs(this, node2);

            if ((n1 == null) && (n2 == null))
            {
                node1.adj.Add(node2);
                adj.Add(node1);
            }
            else if ((n1 != null) && (n2 == null))
            {
                n1.adj.Add(node2);
            }
            else if ((n1 == null) && (n2 != null))
            {
                n2.adj.Add(node1);
            }
        }

        private Node dfs(Node root, Node target)
        {
            if (root == target)
                return root;
            else
            {
                foreach (Node child in root.adj)
                {
                    Node res = dfs(child, target);

                    if (res != null)
                        return res;
                }
            }

            return null;
        }

        public static bool operator ==(Node node1, Node node2)
        {
            if (ReferenceEquals(node1, node2))
                return true;
            else if (((object)node1 == null) || ((object)node2 == null))
                return false;

            return (node1.Value == node2.Value);
        }

        public static bool operator !=(Node node1, Node node2)
        {
            return !(node1 == node2);
        }
    }
}
