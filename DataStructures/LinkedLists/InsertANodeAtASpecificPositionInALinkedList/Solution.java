package list;

class Node 
{
    int data;
    Node next;
}

class InsertANodeAtASpecificPositionInALinkedList 
{    
    Node InsertNth(Node head, int data, int position) 
    {
        if(position == 0)
        {
            Node node = new Node();
            node.data = data;           
            node.next = head;

            return node;
        }

        Node prev = head;   

        for(int i = 1; i < position; i++)
        {
            prev = prev.next;
        }

        Node node = new Node();
        node.data = data;
        node.next = prev.next;
        prev.next = node;

        return head;
    }
    
    public static void main(String[] args) 
    {
        InsertANodeAtASpecificPositionInALinkedList list = new InsertANodeAtASpecificPositionInALinkedList();
        
        Node node1 = new Node();
        node1.data = 3;
             
        Node result = list.InsertNth(node1, 4, 0);
    }   
}
