import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class JavaEndOfFile
{
    public static void main(String []argh)
    {
        Scanner scanner = new Scanner(System.in);
        int n = 1;

        while(scanner.hasNext())
        {
        	System.out.println(n + " " + scanner.nextLine());
        	n++;
        }        
    }
}
