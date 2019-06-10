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

class TreeHeightOfABinaryTree 
{    
    static int height(Node root)
    {
        int heightLeft = 0;
        int heightRight = 0;
        
        if(root.left != null)
            heightLeft = 1 + height(root.left);
        if(root.right != null)
            heightRight = 1 + height(root.right);
        
        return heightLeft > heightRight ? heightLeft : heightRight;
    }
    
    public static Node insert(Node root, int data) 
    {
        if(root == null)
        {
            return new Node(data);
        }
        else 
        {
            Node cur;
            
            if(data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            
            return root;
        }
    }
    
    public static void main(String[] args) 
    {
        Node node1 = new Node(1);
        Node node2 = new Node(2);
        Node node3 = new Node(3);
        Node node4 = new Node(4);
        Node node5 = new Node(5);
        Node node6 = new Node(6);
        Node node7 = new Node(7);
        
        node3.left = node2;
        node2.left = node1;
        node3.right = node5;
        node5.left = node4;
        node5.right = node6;
        node6.right = node7;
        
        int height = height(node3);
        System.out.println(height);
    }   
}
