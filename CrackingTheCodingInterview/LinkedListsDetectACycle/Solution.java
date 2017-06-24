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
  
