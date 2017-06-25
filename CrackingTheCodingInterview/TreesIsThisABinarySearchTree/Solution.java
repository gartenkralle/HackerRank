package tree;

import java.util.ArrayList;
import java.util.List;

class Node 
{
    int data;
    Node left;
    Node right;
}

class ThisIsABinarySearchTree
{
    public static void main(String []args)
    {
    	ThisIsABinarySearchTree bstChecker = new ThisIsABinarySearchTree();
    	
    	Node root = new Node();
    	Node left = new Node();
    	Node right = new Node();
    	
    	root.left = left;
    	root.right = right;
    	
    	root.data = 4;
    	left.data = 2;
    	right.data = 6;
    	
    	System.out.println(bstChecker.checkBST(root));
    	
    	right.data = 1;
    	
    	System.out.println(bstChecker.checkBST(root));
    }
    
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
}
