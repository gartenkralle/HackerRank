package list;

class Node 
{
    int data;
    Node next;
}

class DeleteANode 
{    
    Node Delete(Node head, int position) 
    {
        if(position == 0)
        {
            head = head.next;
            return head;
        }

        Node prev = head;   

        for(int i = 1; i < position; i++)
        {
            prev = prev.next;
        }

        prev.next = prev.next.next;

        return head;
    }
    
    public static void main(String[] args) 
    {
        DeleteANode list = new DeleteANode();
        
        Node node1 = new Node();
        Node node2 = new Node();
        Node node3 = new Node();
        
        node1.data = 1;
        node2.data = 2;
        node3.data = 3;
        
        node1.next = node2;
        node2.next = node3;
        
        Node result = list.Delete(node1, 0);        
    }   
}
