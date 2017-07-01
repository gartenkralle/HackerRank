package java;

import java.util.Scanner;

class JavaStaticInitializerBlock
{
    static short B;
    static short H;
    static boolean flag;
    
    static
    {
        Scanner scanner = new Scanner(System.in);
        B = scanner.nextShort();
        H = scanner.nextShort();
        
        if((B <= 0) || (H <=0))
        {
            flag = false;
            System.out.println("java.lang.Exception: Breadth and height must be positive");
    
        }
        else
            flag = true;
    }
}
