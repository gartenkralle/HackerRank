package tree;

class Node 
{
    Node left;
    Node right;
    int data;
    
    Node(int data)
    {
        this.data = data;
        left = null;
        right = null;
    }
}

class TreeInorderTraversal 
{    
    static void inOrder(Node root) 
    {
        if(root.left != null)
            inOrder(root.left);
        
        System.out.print(root.data + " ");
        
        if(root.right != null)
            inOrder(root.right);
    }
    
    public static void main(String[] args) 
    {
        Node node1 = new Node(1);
        Node node2 = new Node(2);
        Node node3 = new Node(3);
        Node node4 = new Node(4);
        Node node5 = new Node(5);
        Node node6 = new Node(6);
        
        node1.right = node2;
        node2.right = node5;
        node5.left = node3;
        node5.right = node6;
        node3.right = node4;
        
        inOrder(node1);
    }   
}
