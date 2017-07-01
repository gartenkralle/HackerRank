package test;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class JavaList
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);
        int N = Integer.parseInt(in.nextLine());
        List<Integer> L = new ArrayList<>();
                
        String[] arr = in.nextLine().split(" ");
        
        for(String s : arr)
            L.add(Integer.parseInt(s));
        
        int Q = Integer.parseInt(in.nextLine());
        
        for(int i = 0; i < Q; i++)
        {
            String type = in.nextLine();
            
            switch(type)
            {
                case "Insert":
                    arr = in.nextLine().split(" ");
                    int x = Integer.parseInt(arr[0]);
                    int y = Integer.parseInt(arr[1]);                   
                    L.add(x, y);
                    break;
                    
                case "Delete":
                    int index = Integer.parseInt(in.nextLine());
                    L.remove(index);
                    break;
            }
        }
        
        for(int i : L)
            System.out.print(i + " ");
    }
}
