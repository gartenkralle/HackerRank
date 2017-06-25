package list;

class Node 
{
    int data;
    Node next;
}

class InsertANodeAtTheTailOfALinkedList 
{    
    Node Insert(Node head,int data) 
    {
        if(head == null)
        {
            head = new Node();
            head.data = data;
            return head;
        }

        Node node = head;

        while(node.next != null)
            node = node.next;

        node.next = new Node();
        node.next.data = data;

        return head;
    }
    
    public static void main(String[] args) 
    {
        InsertANodeAtTheTailOfALinkedList list = new InsertANodeAtTheTailOfALinkedList();
        
        Node node1 = new Node();
        node1.data = 1;
             
        list.Insert(node1, 2);
    }   
}
