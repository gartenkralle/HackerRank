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

class TreePostorderTraversal 
{    
    void postOrder(Node root) 
    {   
        if(root.left != null)
            postOrder(root.left);

        if(root.right != null)
            postOrder(root.right);
        
         System.out.print(root.data + " ");   
    }
    
    public static void main(String[] args) 
    {
        TreePostorderTraversal tree = new TreePostorderTraversal();
        
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
        
        tree.postOrder(node1);
    }   
}
