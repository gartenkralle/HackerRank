package test;

public class Solution
{
    public static void main(String[] args)
    {        
        Regex_Test tester = new Regex_Test();
        tester.checker("^\\d{1,2}[a-zA-z]{3,}(\\.){0,3}$");    
    }
}
