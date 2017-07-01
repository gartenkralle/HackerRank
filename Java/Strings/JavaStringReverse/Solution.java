package test;

import java.util.Scanner;

public class JavaStringReverse 
{
    public static void main(String[] args) 
    {
        Scanner sc = new Scanner(System.in);
        String A = sc.next();
        
        if(isPalindrom(A))
            System.out.println("Yes");
        else
            System.out.println("No");
    }

    private static boolean isPalindrom(String a)
    {
        if(new StringBuilder(a).reverse().toString().equals(a))
            return true;
        else
            return false;
    }
}
