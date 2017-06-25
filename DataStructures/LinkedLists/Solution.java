package list;

class Node 
{
    int data;
    Node next;
 }

class PrintTheElementsOfALinkedList 
{    
    void Print(Node head)
    {
        while(head != null)
        {
            System.out.println(head.data);
            head = head.next;
        }  
    }
    
    public static void main(String[] args) 
    {
        PrintTheElementsOfALinkedList list = new PrintTheElementsOfALinkedList();
        
        Node node1 = new Node();
        Node node2 = new Node();
        Node node3 = new Node();
        
        node1.data = 1;
        node2.data = 2;
        node3.data = 3;

        node1.next = node2;
        node2.next = node3;
               
        list.Print(node1);
    }   
}
