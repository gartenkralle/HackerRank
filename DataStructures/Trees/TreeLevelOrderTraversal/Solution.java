package tree;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

class Node 
{
    int data;
    Node left;
    Node right;
}

class TreeLevelOrderTraversal
{
    public static void main(String []args)
    {
    	TreeLevelOrderTraversal tree = new TreeLevelOrderTraversal();
    	
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
    	
    	tree.LevelOrder(node1);
    }
    
	void LevelOrder(Node root)
	{
        Queue<Node> queue = new  LinkedList<>();
        List<Integer> list = new ArrayList<Integer>();

        queue.add(root);

        while (queue.size() != 0)
        {
            Node node = queue.poll();

            list.add(node.data);

            if (node.left != null)
                queue.add(node.left);
            if (node.right != null)
                queue.add(node.right);
        }

        System.out.println(join(list, " "));
	}
	
	 static String join(Collection<?> s, String delimiter) 
	 {
	     StringBuilder builder = new StringBuilder();
	     Iterator<?> iter = s.iterator();
	     
	     while (iter.hasNext())
	     {
	         builder.append(iter.next());
	         
	         if (!iter.hasNext()) 
	         {
	           break;                  
	         }
	         
	         builder.append(delimiter);
	     }
	     
	     return builder.toString();
	 }
}
