package list;

import java.util.Stack;

class Node 
{
    int data;
    Node next;
}

class ReverseALinkedList 
{    
    Node Reverse(Node head) 
    {
        Stack<Node> stack = new Stack<>();

        while(head != null)
        {
            stack.push(head);
            head = head.next;
            stack.peek().next = null;
        }

        Node reversedHead = null;   

        if(!stack.isEmpty())
        {
            reversedHead = stack.pop();
            Node node = reversedHead;

            while(!stack.isEmpty())
            {
                node.next = stack.pop();
                node = node.next;
            }       
        }

        return reversedHead;
    }
    
    public static void main(String[] args) 
    {
        ReverseALinkedList list = new ReverseALinkedList();
        
        Node node1 = new Node();
        Node node2 = new Node();
        Node node3 = new Node();
        
        node1.data = 1;
        node2.data = 2;
        node3.data = 3;
        
        node1.next = node2;
        node2.next = node3;
        
        Node result = list.Reverse(node1);   
    }   
}
