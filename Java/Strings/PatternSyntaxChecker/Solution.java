import java.util.Scanner;
import java.util.regex.*;

public class PatternSyntaxChecker
{
    public static void main(String[] args) 
    {        
        Scanner in = new Scanner(System.in);
        int testCases = Integer.parseInt(in.nextLine());
        
        while(testCases > 0)
        {
           String pattern = in.nextLine();
           
           if(isValidPattern(pattern))
        	   System.out.println("Valid");
           else
        	   System.out.println("Invalid");

        }
    }
    
    public static boolean isValidPattern(String pattern)
    {
        try
        {
     	   Pattern.compile(pattern);
        }
        catch(PatternSyntaxException ex)
        {
     	   return false;
        }
        
        return true;
    }
}
