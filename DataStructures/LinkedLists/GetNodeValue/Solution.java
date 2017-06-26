package list;

class Node 
{
    int data;
    Node next;
}

class GetNodeValue 
{    
    int GetNode(Node head,int n)
    {
        int count = GetCount(head);
        int position = count - n;

        for(int i = 1; i < position; i++)
        {
            head = head.next;
        }

        return head.data;
    }

    int GetCount(Node head)
    {
        int count = 0;

        while(head != null)
        {
            head = head.next;
            count++;
        }

        return count;
    }
    
    public static void main(String[] args) 
    {
        GetNodeValue list = new GetNodeValue();
        
        Node node1 = new Node();
        Node node3 = new Node();
        Node node5 = new Node();
        Node node6 = new Node();
        
        node1.data = 1;
        node3.data = 3;
        node5.data = 5;
        node6.data = 6;
        
        node1.next = node3;
        node3.next = node5;
        node5.next = node6;
        
        System.out.println(list.GetNode(node1, 0));
        System.out.println(list.GetNode(node1, 2));
    }   
}
