package tree;

class Node 
{
    int data;
    Node left;
    Node right;
}

class TreePreorderTraversal 
{
    public static void main(String[] args) 
    {
        TreePreorderTraversal tree = new TreePreorderTraversal();
        
        Node node1 = new Node();
        Node node2 = new Node();
        Node node3 = new Node();
        Node node4 = new Node();
        Node node5 = new Node();
        Node node6 = new Node();
        
        node1.data = 1;
        node2.data = 2;
        node3.data = 3;
        node4.data = 4;
        node5.data = 5;
        node6.data = 6;
        
        node1.right = node2;
        node2.right = node5;
        node5.left = node3;
        node5.right = node6;
        node3.right = node4;
        
        tree.preOrder(node1);
    }
    
    void preOrder(Node root) 
    {
        System.out.print(root.data + " ");

        if(root.left != null)
            preOrder(root.left);

        if(root.right != null)
            preOrder(root.right);
    }
}
