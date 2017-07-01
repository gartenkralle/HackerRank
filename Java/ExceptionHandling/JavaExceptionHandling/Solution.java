import java.util.InputMismatchException;
import java.util.Scanner;

public class JavaExceptionHandling 
{
    public static void main(String[] args) 
    {
        Scanner in = new Scanner(System.in);
        int a;
        int b;
        
        try
        {
            a = in.nextInt();
            b = in.nextInt();
        }
        catch(InputMismatchException ex)
        {
            System.out.println("java.util.InputMismatchException");
            return;
        }
        
        try
        {
            System.out.println(a / b);
        }
        catch(ArithmeticException ex)
        {
            System.out.println("java.lang.ArithmeticException: / by zero");
            return;
        }
    }
}
