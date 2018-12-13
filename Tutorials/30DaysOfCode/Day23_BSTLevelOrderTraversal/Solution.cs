using System;
using System.Collections.Generic;

namespace Day23_BSTLevelOrderTraversal
{
    class Node
    {
        public Node left, right;
        public int data;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    class Solution
    {
        static void levelOrder(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            List<int> list = new List<int>();

            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                Node node = queue.Dequeue();

                list.Add(node.data);

                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            Console.WriteLine(String.Join(" ", list.ToArray()));
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }

                return root;
            }
        }

        static void Main(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());

            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }

            levelOrder(root);
        }
    }
}
