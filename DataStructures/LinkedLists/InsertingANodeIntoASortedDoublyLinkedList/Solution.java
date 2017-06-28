package list;

class Node
{
    int data;
    Node next;
    Node prev;
 }

class InsertingANodeIntoASortedDoublyLinkedList 
{    
    Node SortedInsert(Node head,int data)
    {
        Node node = new Node();
        node.data = data;

        if (head == null)
            return node;

        Node current = head;

        while (current.next != null && current.next.data < data)
        {
            current = current.next;
        }

        Node next = current.next;
        current.next = node;
        node.prev = current;
        node.next = next;

        if (next != null)
            next.prev = node;

        return head;
    }
    
    public static void main(String[] args) 
    {
        InsertingANodeIntoASortedDoublyLinkedList list = new InsertingANodeIntoASortedDoublyLinkedList();
        
        Node result;
        
        result = list.SortedInsert(null, 2);
        result = list.SortedInsert(result, 5);
        result = list.SortedInsert(result, 4);        
    }   
}
