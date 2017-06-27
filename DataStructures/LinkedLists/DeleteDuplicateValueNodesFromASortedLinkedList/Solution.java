package list;

class Node 
{
    int data;
    Node next;
}

class DeleteDuplicateValueNodesFromASortedLinkedList 
{    
    Node RemoveDuplicates(Node head)
    {
        if((head == null) || (head.next == null))
            return head;

        Node node = head;

        while(node.next != null)
        {
            if(node.data == node.next.data)
                node.next = node.next.next;
            else
                node = node.next;
        }

        return head;
    }
    
    public static void main(String[] args) 
    {
        DeleteDuplicateValueNodesFromASortedLinkedList list = new DeleteDuplicateValueNodesFromASortedLinkedList();
        
        Node node11 = new Node();
        Node node12 = new Node();
        Node node31 = new Node();
        Node node32 = new Node();
        Node node5 = new Node();
        Node node6 = new Node();

        node11.data = 1;
        node12.data = 1;
        node31.data = 3;
        node32.data = 3;
        node5.data = 5;
        node6.data = 6;
        
        node11.next = node12;
        node12.next = node31;
        node31.next = node32;
        node32.next = node5;
        node5.next = node6;
        
        Node result = list.RemoveDuplicates(node11);
    }   
}
