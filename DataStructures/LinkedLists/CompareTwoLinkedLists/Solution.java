package list;

class Node 
{
    int data;
    Node next;
}

class CompareTwoLinkedLists 
{    
    int CompareLists(Node headA, Node headB)
    {
        while((headA != null) || (headB != null))
        {
            if(((headA == null) && (headB != null)) || ((headA != null) && (headB == null)) || (headA.data != headB.data))
                return 0;

            headA = headA.next;
            headB = headB.next;
        }

        return 1;
    }
    
    public static void main(String[] args) 
    {
        CompareTwoLinkedLists list = new CompareTwoLinkedLists();
        
        Node node1 = new Node();        
        node1.data = 1;
        
        System.out.println(list.CompareLists(null, node1));  
        
        
        Node node11 = new Node();
        Node node12 = new Node(); 
        node11.data = 1;
        node12.data = 2;
        
        node11.next = node12;

        Node node21 = new Node();
        Node node22 = new Node();
        node21.data = 1;
        node22.data = 2;
        
        node21.next = node22; 
        
        System.out.println(list.CompareLists(node11, node21));
    }   
}
