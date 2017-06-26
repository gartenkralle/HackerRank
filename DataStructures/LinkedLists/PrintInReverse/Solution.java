package list;

import java.util.Stack;

class Node 
{
    int data;
    Node next;
}

class PrintInReverse 
{    
    void ReversePrint(Node head) 
    {
        Stack<Node> stack = new Stack<>();

        while(head != null)
        {
            stack.push(head);
            head = head.next;
        }

        while(!stack.isEmpty())
        {
            System.out.println(stack.pop().data);
        }
    }
    
    public static void main(String[] args) 
    {
        PrintInReverse list = new PrintInReverse();
        
        Node node1 = new Node();
        Node node2 = new Node();
        Node node3 = new Node();
        
        node1.data = 1;
        node2.data = 2;
        node3.data = 3;
        
        node1.next = node2;
        node2.next = node3;
        
        list.ReversePrint(node1);   
    }   
}
