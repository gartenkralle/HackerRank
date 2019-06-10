package tree;

import java.util.Stack;

class Node
{
    int data;
    Node left, right;
}

class BinarySearchTreeLowestCommonAncestor 
{    
    static Node lca(Node root, int v1, int v2)
    {
        Stack<Node> A = getPath(root, v1);
        Stack<Node> B = getPath(root, v2);

        return getLca(A, B);
    }

    static Stack<Node> getPath(Node node, int v)
    {
        Stack<Node> stack = new Stack<Node>();

        getPath(stack, node, v);

        return stack;
    }

    static boolean getPath(Stack<Node> stack, Node node, int v)
    {       
        if(node == null)
            return false;

        if(node.data == v)
        {
            stack.push(node);
            return true;
        }

        if(getPath(stack, node.left, v))
        {
            stack.push(node);
            return true;
        }
        if(getPath(stack, node.right, v))
        {
            stack.push(node);
            return true;
        }

        return false;       
    }

    static Node getLca(Stack<Node> A, Stack<Node> B)
    {
        Node node = A.peek();

        while(!A.isEmpty() && !B.isEmpty())
        {
            Node node1 = A.pop();
            Node node2 = B.pop();

            if(node1.data == node2.data)
                node = node1;
            else
                break;
        }

        return node;
    }
    
    public static void main(String[] args) 
    {
        Node node1 = new Node();
        Node node2 = new Node();
        Node node3 = new Node();
        Node node4 = new Node();
        Node node6 = new Node();
        Node node7 = new Node();
        
        node1.data = 1;
        node2.data = 2;
        node3.data = 3;
        node4.data = 4;
        node6.data = 6;
        node7.data = 7;
        
        node4.left = node2;
        node4.right = node7;
        node2.left = node1;
        node2.right = node3;
        node7.left = node6;
        
        Node result = lca(node4, 1, 7);
    }   
}
