package list;

class Node
{
    int data;
    Node next;
    Node prev;
 }

class ReverseADoublyLinkedList
{    
    Node Reverse(Node head)
    {
        if ((head == null) || (head.next == null))
            return head;

        Node current = head;

        while (head.next != null)
        {
            head = head.next;
        }

        while (current != null)
        {
            Node next = current.next;
            current.next = current.prev;
            current.prev = next;

            current = next;
        }

        return head;
    }
    
    public static void main(String[] args) 
    {
        ReverseADoublyLinked list = new ReverseADoublyLinked();
        
        Node result;
        
        result = list.Reverse(null);
        
        Node node2 = new Node();
        Node node4 = new Node();
        Node node6 = new Node();
        
        node2.data = 2;
        node4.data = 4;
        node6.data = 6;
        
        node2.next = node4;
        node4.prev = node2;
        node4.next = node6;
        node6.prev = node4;
        
        result = list.Reverse(node2);
    }   
}
