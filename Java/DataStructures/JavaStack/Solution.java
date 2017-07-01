import java.util.*;

class JavaStack
{   
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        
        while (sc.hasNext())
        {
           String input = sc.next();

           if(isBalanced(input))
        	   System.out.println("true");
           else
        	   System.out.println("false");           
        }
    }
    
    public static boolean isBalanced(String input)
    {
        Stack<Character> parentheses = new Stack<>();    
        
        for(char c : input.toCharArray())
        {
     	   if((c == '{') || (c == '(') || (c == '['))
     	   {
     	   	  parentheses.push(c);
     	   	  continue;
     	   }
     	   
     	   if(parentheses.isEmpty()) return false;     		      
     	   char pop = parentheses.pop().charValue();
     		      

	       if((c == '}') && (pop != '{')) return false;
	       if((c == ')') && (pop != '(')) return false;
	       if((c == ']') && (pop != '[')) return false;
        }
        
        if(!parentheses.isEmpty())
        	return false;
        else
        	return true;
    }
}
