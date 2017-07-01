import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class JavaArraylist 
{
    public static void main(String[] args) 
    {
        Scanner in = new Scanner(System.in);
        int n = Integer.parseInt(in.nextLine());
        
        List<List<Integer>> lines = new ArrayList<>();
        
        for(int i = 0; i < n; i++)
        {
        	List<Integer> line = new ArrayList<>();
        	
        	String[] arr = in.nextLine().split(" ");
        	
        	for(String s : arr)
        		line.add(Integer.parseInt(s));
        	
        	lines.add(line);
        }
        
        int q = Integer.parseInt(in.nextLine());
        
        for(int i = 0; i < q; i++)
        {
        	int x = in.nextInt();
        	int y = in.nextInt();
        	
        	try
        	{
        		System.out.println(lines.get(x - 1).get(y));
        	}
        	catch(IndexOutOfBoundsException ex)
        	{
        		System.out.println("ERROR!");
        	}
        }
    }
}
