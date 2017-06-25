package list;

class Node 
{
    int data;
    Node next;
}

class InsertANodeAtTheHeadOfALinkedList 
{    
    Node Insert(Node head,int x) 
    {
        Node node = new Node();
        node.data = x;        
        node.next = head;

        return node;
    }
    
    public static void main(String[] args) 
    {
        InsertANodeAtTheHeadOfALinkedList list = new InsertANodeAtTheHeadOfALinkedList();
        
        Node node1 = new Node();
        node1.data = 1;
        
        Node result = list.Insert(node1, 2);
    }   
}
