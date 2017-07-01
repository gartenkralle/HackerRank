package tree;

class Node
{
    int frequency;
    char data;
    Node left, right;
 }

class TreeHuffmanDecoding 
{    
    void decode(String S, Node root)
    {
        Node node = root;

        for (int i = 0; i < S.length(); i++)
        {
            if (S.charAt(i) == '0')
                node = node.left;
            else if (S.charAt(i) == '1')
                node = node.right;

                if (node.data != '\0')
            {
                System.out.print(node.data);
                node = root;
            }
        }
    }
    
    public static void main(String[] args) 
    {
        TreeHuffmanDecoding tree = new TreeHuffmanDecoding();        

        Node node1 = new Node();
        Node node2 = new Node();
        Node node3 = new Node();
        Node node4 = new Node();
        Node node5 = new Node();

        node1.frequency = 5;
        node2.frequency = 2;
        node3.frequency = 3;
        node4.frequency = 1;
        node5.frequency = 1;
        
        node3.data = 'A';
        node4.data = 'B';
        node5.data = 'C';
        
        node1.left = node2;
        node1.right = node3;
        node2.left = node4;
        node2.right = node5;
        
        tree.decode("1001011", node1);
    }   
}
