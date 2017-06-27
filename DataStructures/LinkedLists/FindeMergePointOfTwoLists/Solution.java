package list;

import java.util.Stack;

class Node 
{
    int data;
    Node next;
}

class FindMergePointOfTwoLists 
{    
    int FindMergeNode(Node headA, Node headB)
    {
        Stack<Node> stackA = new Stack<>();
        Stack<Node> stackB = new Stack<>();

        while(headA != null)
        {
            stackA.push(headA);
            headA = headA.next;
        }

        while(headB != null)
        {
            stackB.push(headB);
            headB = headB.next;
        }

        int result = -1;

        while(!stackA.isEmpty() && !stackB.isEmpty())
        {
            Node node1 = stackA.pop();
            Node node2 = stackB.pop();

            if(node1 == node2)
                result = node1.data;
        }

        return result;
    }
    
    public static void main(String[] args) 
    {
        FindMergePointOfTwoLists list = new FindMergePointOfTwoLists();
        
        Node node11 = new Node();
        Node node12 = new Node();
        Node node2 = new Node();
        Node node3 = new Node();
        
        node11.data = 1;
        node12.data = 1;
        node2.data = 2;
        node3.data = 3;
        
        node11.next = node2;
        node2.next = node3;
        
        node12.next = node2;
        
        System.out.println(list.FindMergeNode(node11, node12));
        
        node12.next = node3;
        
        System.out.println(list.FindMergeNode(node11, node12));
    }   
}
