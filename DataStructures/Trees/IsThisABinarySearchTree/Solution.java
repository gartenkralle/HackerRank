package tree;

import java.util.ArrayList;
import java.util.List;

class Node
{
    int data;
    Node left, right;
}

class IsThisABinarySearchTree 
{    
    private List<Integer> list = new ArrayList<>();
    
    boolean checkBST(Node root) 
    {       
        BSTToList(root);        
        
        return IsListOrdered();
    }
    
    boolean IsListOrdered()
    {
        for(int i = 0; i < (list.size() - 1); i++)
            if(list.get(i) >= list.get(i + 1))
                return false;
        
        return true;        
    }
    
    void BSTToList(Node root)
    {
        if(root == null)
            return;
        
        if(root.left != null)
            BSTToList(root.left);
        
        list.add(root.data);
        
        if(root.right != null)
            BSTToList(root.right);      
    }
    
    public static void main(String[] args) 
    {
        IsThisABinarySearchTree tree = new IsThisABinarySearchTree();
        
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
        
        node3.left = node5;
        node3.right = node2;
        node2.left = node6;
        node5.left = node1;
        node5.right = node4;
        
        System.out.println(tree.checkBST(node3));       
    }   
}
