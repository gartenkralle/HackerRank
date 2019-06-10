using System.IO;
using System;
using System.Collections.Generic;

namespace FindMergePointOfTwoLists
{
    class Solution
    {
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                data = nodeData;
                next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                head = null;
                tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (head == null)
                {
                    head = node;
                }
                else
                {
                    tail.next = node;
                }

                tail = node;
            }
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }

        static int FindMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            Stack<SinglyLinkedListNode> stackA = new Stack<SinglyLinkedListNode>();
            Stack<SinglyLinkedListNode> stackB = new Stack<SinglyLinkedListNode>();

            while (head1 != null)
            {
                stackA.Push(head1);
                head1 = head1.next;
            }

            while (head2 != null)
            {
                stackB.Push(head2);
                head2 = head2.next;
            }

            int result = -1;

            while ((stackA.Count != 0) && (stackB.Count != 0))
            {
                SinglyLinkedListNode node1 = stackA.Pop();
                SinglyLinkedListNode node2 = stackB.Pop();

                if (node1 == node2)
                    result = node1.data;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                int index = Convert.ToInt32(Console.ReadLine());

                SinglyLinkedList llist1 = new SinglyLinkedList();

                int llist1Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist1Count; i++)
                {
                    int llist1Item = Convert.ToInt32(Console.ReadLine());
                    llist1.InsertNode(llist1Item);
                }

                SinglyLinkedList llist2 = new SinglyLinkedList();

                int llist2Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist2Count; i++)
                {
                    int llist2Item = Convert.ToInt32(Console.ReadLine());
                    llist2.InsertNode(llist2Item);
                }

                SinglyLinkedListNode ptr1 = llist1.head;
                SinglyLinkedListNode ptr2 = llist2.head;

                for (int i = 0; i < llist1Count; i++)
                {
                    if (i < index)
                    {
                        ptr1 = ptr1.next;
                    }
                }

                for (int i = 0; i < llist2Count; i++)
                {
                    if (i != llist2Count - 1)
                    {
                        ptr2 = ptr2.next;
                    }
                }

                ptr2.next = ptr1;

                int result = FindMergeNode(llist1.head, llist2.head);

                Console.WriteLine(result);
            }
        }
    }
}