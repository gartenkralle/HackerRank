package test;

import java.util.Arrays;

public class JavaAnagrams 
{
    public static void main(String[] args) 
    {        
        System.out.println(isAnagram("anagram", "margana"));
        System.out.println(isAnagram("anagramm", "marganaa"));
    }

    static boolean isAnagram(String a, String b) 
    {
        char[] aArr = a.toLowerCase().toCharArray();
        char[] bArr = b.toLowerCase().toCharArray();
        
        Arrays.sort(aArr);
        Arrays.sort(bArr);
        
        if(aArr.length != bArr.length)
            return false;
        
        for(int i = 0; i < aArr.length; i++)
        {
            if(aArr[i] != bArr[i])
                return false;
        }
        
        return true;
    }
}
