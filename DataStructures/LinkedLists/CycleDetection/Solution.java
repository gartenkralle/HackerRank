package list;

class Node 
{
    int data;
    Node next;
}

class CycleDetection 
{    
    boolean hasCycle(Node head)
    {
        Node slow = head;
        Node fast = head;

        while((fast != null) && (fast.next != null))
        {
            slow = slow.next;
            fast = fast.next.next;          

            if(slow == fast)
                return true;
        }

        return false;
    }
    
    public static void main(String[] args) 
    {
        CycleDetection list = new CycleDetection();
        
        Node node1 = new Node();
        node1.data = 1;
        
        System.out.println(list.hasCycle(node1));
        
        Node node2 = new Node();
        Node node3 = new Node();
        
        node2.data = 2;
        node3.data = 3;
        
        node1.next = node2;
        node2.next = node3;
        node3.next = node2;
        
        System.out.println(list.hasCycle(node1));
    }   
}
