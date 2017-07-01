import java.io.*;
import java.util.*;

public class JavaStringsIntroduction 
{
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        String A = sc.next();
        String B = sc.next();
        
        System.out.println(A.length() + B.length());
        
        if(isLexicographically(A, B))
        	System.out.println("Yes");
        else
        	System.out.println("No");
        
        A = Character.toUpperCase(A.charAt(0)) + A.substring(1, A.length());
        B = Character.toUpperCase(B.charAt(0)) + B.substring(1, B.length());
        
        System.out.println(A + " " + B);
    }
    
    static boolean isLexicographically(String A, String B)
    {
    	int length = (A.length() > B.length()) ? B.length() : A.length();
    	int index = 0;
    	
    	for(int i = 0; i < length; i++)
    	{
    		if(A.charAt(i) < B.charAt(i))
    			return false;
    		else if(A.charAt(i) > B.charAt(i))
    			return true;
    		
    		index = i;
    	}
    	
    	if((A.length() - 1) > index)
    		return true;
    	else
    		return false;    	
    }
}
