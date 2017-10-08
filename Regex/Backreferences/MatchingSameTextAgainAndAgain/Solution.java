public class Solution
{
    public static void main(String[] args) 
    {        
        Regex_Test tester = new Regex_Test();
        tester.checker("^([a-z])(\\w)(\\s)(\\W)(\\d)(\\D)([A-Z])([a-zA-z])([AEIOUaeiou])(\\S)\\1\\2\\3\\4\\5\\6\\7\\8\\9\\10$");
    }
}
