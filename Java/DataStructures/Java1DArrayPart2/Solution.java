package test;

import java.util.Scanner;

public class Java1DArrayPart2 
{
    public static void main(String[] args) 
    {
        Scanner scan = new Scanner(System.in);
        int q = scan.nextInt();
        
        while ((q--) > 0) 
        {
            int n = scan.nextInt();
            int leap = scan.nextInt();
            
            int[] game = new int[n];
            
            for (int i = 0; i < n; i++) 
            {
                game[i] = scan.nextInt();
            }

            System.out.println(canWin(leap, game) ? "YES" : "NO");
        }
        
        scan.close();
    }
    
    public static boolean canWin(int leap, int[] game) 
    {
        if(leap == 0)
            leap = 1;
        
        return canWin(0, leap, game);
    }
    
    public static boolean canWin(int index, int leap, int[] game) 
    {
        game[index] = 1;
        
        if((index + leap) >= game.length)
            return true;
        
        if(game[index + leap] == 0 && canWin(index + leap, leap, game))
            return true;
        if(game[index + 1] == 0 && canWin(index + 1, leap, game))           
            return true;
        if(((index - 1) > 0) && (game[index - 1] == 0) && canWin(index - 1, leap, game))            
            return true;
        
        return false;
    }
}
