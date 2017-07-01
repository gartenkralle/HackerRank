package test;

import java.math.BigDecimal;
import java.util.AbstractMap;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;
import java.util.Scanner;

class JavaBigDecimal
{
    public static void main(String []args)
    {
        Scanner sc= new Scanner(System.in);
        int n = sc.nextInt();
        
        String []s=new String[n+2];
        
        for(int i = 0; i < n; i++)
        {
            s[i] = sc.next();
        }
        
        sc.close();
        
        class SimpleEntryComparator implements Comparator<AbstractMap.SimpleEntry<BigDecimal, String>>
        {
            @Override
            public int compare(AbstractMap.SimpleEntry<BigDecimal, String> o1, AbstractMap.SimpleEntry<BigDecimal, String> o2) 
            {
                return o2.getKey().compareTo(o1.getKey());
            }   
        }
        
        List<AbstractMap.SimpleEntry<BigDecimal, String>> list = new ArrayList<>();
        
        for(int i = 0; i < n; i++)
        {
            list.add(new AbstractMap.SimpleEntry<BigDecimal, String>(new BigDecimal(s[i]), s[i]));
        }
        
        Collections.sort(list, new SimpleEntryComparator());
        
        for(int i = 0; i < n; i++)
        {
            s[i] = list.get(i).getValue();
        }
        
        for(int i = 0 ;i<n; i++)
        {
            System.out.println(s[i]);
        }
    }
}
