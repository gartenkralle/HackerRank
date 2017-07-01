import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class JavaSubstringComparision 
{
    public static void main(String[] args) 
    {
        Scanner in = new Scanner(System.in);
        String S = in.next();
        int length = in.nextInt();

        String min = S.substring(0, length);
        String max = S.substring(0, length);
        
        for(int i = 0; i < (S.length() - (length - 1)); i++)
        {
        	String current = S.substring(i, i + length);
        	
        	if(current.compareTo(min) < 0)
        		min = current;
        	else if(current.compareTo(max) > 0)
        		max = current;        		
        }
        
        System.out.println(min);
        System.out.println(max);
    }
}
