import java.util.*;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;

public class Solution
{
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        String s = scanner.nextLine();
        scanner.close();
        
        byte[] digest = null;
        
        try
        {
            digest = MessageDigest.getInstance("SHA-256").digest(s.getBytes());
        }
        catch (NoSuchAlgorithmException e)
        {
            e.printStackTrace();
        }
        
        for (int i = 0; i < digest.length; ++i)
        {
            System.out.printf("%02x", digest[i]);
        }
    }
}
