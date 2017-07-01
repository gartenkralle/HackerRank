import java.io.*;
import java.util.*;

public class JavaStringTokens 
{
    public static void main(String[] args) 
    {
        Scanner scan = new Scanner(System.in);
        String s = scan.nextLine();
        scan.close();
        
        List<String> list = new ArrayList<>();        
        String[] arr = s.split(" |,|\\.|'|\\?|!|_|@");
        
        for(String token : arr)
        	if(!token.equals(""))
        		list.add(token);
        
        System.out.println(list.size());
        
        for(String token : list)
        	System.out.println(token);
    }
}
