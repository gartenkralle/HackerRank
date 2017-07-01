package tree;

class Node
{
    int data;
    Node left;
    Node right;
}

class BinarySearchTreeInsertion 
{    
    static Node Insert(Node root, int value)
    {
        if(root == null)
        {
            Node node = new Node();
            node.data = value;
            return node;
        }

        if (root.left != null && value < root.data)
        {
            Insert(root.left, value);
        }
        else if (root.right != null && value > root.data)
        {
            Insert(root.right, value);
        }
        else if (root.left == null && value < root.data)
        {
            Node node = new Node();
            node.data = value;
            root.left = node;
            return root;
        }
        else if (root.right == null && value > root.data)
        {
            Node node = new Node();
            node.data = value;
            root.right = node;
            return root;
        }

        return root;
    }
    
    public static void main(String[] args) 
    {
        BinarySearchTreeInsertion tree = new BinarySearchTreeInsertion();        

        Node node1 = new Node();
        Node node2 = new Node();
        Node node3 = new Node();
        Node node4 = new Node();
        Node node7 = new Node();
        
        node1.data = 1;
        node2.data = 2;
        node3.data = 3;
        node4.data = 4;
        node7.data = 7;
        
        node4.left = node2;
        node4.right = node7;
        node2.left = node1;
        node2.right = node3;
        
        Node result = tree.Insert(node4, 6);
    }   
}
