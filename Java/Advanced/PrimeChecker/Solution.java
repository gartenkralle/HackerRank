import java.io.*;
import java.util.*;
import java.lang.reflect.*;
import static java.lang.System.*;

public class Solution 
{
    public static void main(String[] args)
    {
        try
        {
            BufferedReader br = new BufferedReader(new InputStreamReader(in));
            int n1 = Integer.parseInt(br.readLine());
            int n2 = Integer.parseInt(br.readLine());
            int n3 = Integer.parseInt(br.readLine());
            int n4 = Integer.parseInt(br.readLine());
            int n5 = Integer.parseInt(br.readLine());
            
            Prime ob = new Prime();
            ob.checkPrime(n1);
            ob.checkPrime(n1,n2);
            ob.checkPrime(n1,n2,n3);
            ob.checkPrime(n1,n2,n3,n4,n5);
            
            Method[] methods = Prime.class.getDeclaredMethods();
            Set<String> set = new HashSet<>();
            
            boolean overload = false;
            
            for(int i = 0; i < methods.length; i++)
            {
                if(set.contains(methods[i].getName()))
                {
                    overload = true;
                    break;
                }
                
                set.add(methods[i].getName());
            }
            
            if(overload)
            {
                throw new Exception("Overloading not allowed");
            }
        }
        catch(Exception e)
        {
            System.out.println(e);
        }
    }
}

class Prime
{
    public void checkPrime(int... arr)
    {
        for(int number : arr)
        {
            if(isPrime(number))
            {
                System.out.print(number + " ");
            }
        }
        
        System.out.println();
    }
    
    static boolean isPrime(long number)
    {
        long sqrt = (long)(Math.sqrt(number));
        long div = 3;

        if (number < 2)
            return false;

        if ((number != 2) && ((number % 2) == 0))
            return false;

        while (div <= sqrt)
        {
            if ((number % div) == 0)
                return false;
            else
                div += 2;
        }

        return true;
    }
}
