package list;

class Node 
{
    int data;
    Node next;
}

class MergeTwoSortedLinkedLists 
{    
    Node MergeLists(Node headA, Node headB)
    {
        if(headA == null)
            return headB;
        if(headB == null)
            return headA;

        Node primary;
        Node secondary;

        if(headA.data < headB.data)
        {
            primary = headA;
            secondary = headB;
        }
        else
        {
            primary = headB;
            secondary = headA;
        }

        Node head = primary;

        while(secondary != null)
        {
            while((primary.next != null) && (primary.next.data < secondary.data))
                primary = primary.next;

            Node temp = secondary.next;
            secondary.next = primary.next;
            primary.next = secondary;
            secondary = temp;
        }

        return head;
    }
    
    public static void main(String[] args) 
    {
        MergeTwoSortedLinkedLists list = new MergeTwoSortedLinkedLists();
        
        Node node1 = new Node();
        Node node2 = new Node();
        Node node3 = new Node();
        Node node4 = new Node();
        Node node5 = new Node();
        Node node6 = new Node();
        Node node7 = new Node();
        
        node1.data = 1;
        node2.data = 2;
        node3.data = 3;
        node4.data = 4;
        node5.data = 5;
        node6.data = 6;
        node7.data = 7;
        
        node1.next = node3;
        node3.next = node5;
        node5.next = node6;
        
        node2.next = node4;
        node4.next = node7;
        
        Node result = list.MergeLists(node1, node2);
    }   
}
