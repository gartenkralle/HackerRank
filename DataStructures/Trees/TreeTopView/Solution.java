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

class TreeTopView 
{    
    static void top_view(Node root)
    {
        if(root.left != null)
            left(root.left);

        System.out.print(root.data + " ");

        if(root.right != null)
            right(root.right);
    }

    static void left(Node node)
    {
        if(node.left != null)
            left(node.left);

        System.out.print(node.data + " ");
    }

    static void right(Node node)
    {
        System.out.print(node.data + " ");      

        if(node.right != null)
            right(node.right);
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
        
        top_view(node1);
    }   
}
