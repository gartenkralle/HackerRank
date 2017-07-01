import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class JavaSubarray 
{
    public static void main(String[] args) 
    {        
        Scanner in = new Scanner(System.in);
        int n = Integer.parseInt(in.nextLine());
        int arr[] = new int[n];
        
        for(int i = 0; i < n; i++)
        {
            arr[i] = in.nextInt();
        }
        
        int count = 0;
        
        for(int i = 0; i < n; i++)
        {
            for(int j = i; j < n; j++)
            {
            	if(sum(arr, i, j) < 0)
            		count++;
            }
        }
        
        System.out.println(count);
    }

	private static int sum(int[] arr, int i, int j) 
	{
		int sum = 0;
		
		while(i <= j)
		{
			sum += arr[i];
			i++;
		}

		return sum;
	}
}
