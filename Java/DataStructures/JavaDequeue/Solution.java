import java.util.ArrayDeque;
import java.util.Deque;
import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Solution
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);
        Deque<Integer> deque = new ArrayDeque<>();
        Deque<Integer> subDeque = new ArrayDeque<>();
        Map<Integer, Integer> subSet = new HashMap<>();

        int n = in.nextInt();
        int m = in.nextInt();

        for (int i = 0; i < n; i++)
        {
            deque.add(in.nextInt());
        }

        int uniqueMax = 0;

        for (int i = 0; i < m; i++)
        {
            addNumber(deque, subDeque, subSet);
        }

        if(subSet.size() > uniqueMax)
            uniqueMax = subSet.size();

        for (int i = 0; i < (n - m); i++)
        {
            removeNumber(subDeque, subSet);
            addNumber(deque, subDeque, subSet);
            
            if(subSet.size() > uniqueMax)
                uniqueMax = subSet.size();
        }

        System.out.println(uniqueMax);

        in.close();
    }
    
    private static void addNumber(Deque<Integer> deque, Deque<Integer> subDeque, Map<Integer, Integer> subSet)
    {
        int number = deque.pop();
        
        subDeque.add(number);
        
        if(!subSet.containsKey(number))
            subSet.put(number, 1);
        else
            subSet.put(number, subSet.get(number) + 1);
    }
    
    private static void removeNumber(Deque<Integer> subDeque, Map<Integer, Integer> subSet)
    {
        int number = subDeque.pop(); 
        
        int amount = subSet.get(number);

        if(amount > 1)
            subSet.put(number, amount - 1);
        else
            subSet.remove(number);
    }
}
