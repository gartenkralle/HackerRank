package list;

class Node
{
	Node next;
	int data;
}

class LinkedListsDetectACycle
{
    public static void main(String []args)
    {
    	LinkedListsDetectACycle cycleDetector = new LinkedListsDetectACycle();
    	
    	Node node1 = new Node();
    	Node node2 = new Node();
    	
    	node1.next = node2;
    	
    	System.out.println(cycleDetector.hasCycle(node1));
    	
    	node2.next = node1;
    	
    	System.out.println(cycleDetector.hasCycle(node1));
    }
    
	boolean hasCycle(Node head) 
	{    
	    if (head == null)
	        return false;
	    
	    Node slow = head;
	    Node fast = head.next;
	    
	    while ((fast != null) && (fast.next != null))
	    {
	        if (slow == fast)
	            return true;
	        
	        slow = slow.next;
	        fast = fast.next.next;
	    }
	    
	    return false;
	}
}
