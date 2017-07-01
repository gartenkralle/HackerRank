package test;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

class JavaMap
{
   public static void main(String []argh)
   {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        in.nextLine();
        
        Map<String, Integer> map = new HashMap<>();
        
        for(int i = 0; i <n ; i++)
        {
           String name = in.nextLine();
           int phone = in.nextInt();
           
           map.put(name, phone);
           
           in.nextLine();
        }
        
        while(in.hasNext())
        {
           String s = in.nextLine();
           
           try
           {
        	   int response = map.get(s);           

        	   System.out.println(s + "=" + response);
           }
           catch(NullPointerException ex)
           {
        	   System.out.println("Not found");
           }           
        }
    }
}
