package test;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Scanner;

class Student implements Comparable<Student>
{
    private int id;
    private String fname;
    private double cgpa;
   
    public Student(int id, String fname, double cgpa) 
    {
        super();
        this.id = id;
        this.fname = fname;
        this.cgpa = cgpa;
    }
   
    public int getId() 
    {
        return id;
    }
   
    public String getFname() 
    {
        return fname;
    }
   
    public double getCgpa() 
    {
        return cgpa;
    }

    @Override
    public int compareTo(Student arg0) 
    {
        if(getCgpa() < arg0.getCgpa())
            return 1;
        else if(getCgpa() > arg0.getCgpa())
            return -1;
        else
        {
            if(getFname().compareTo(arg0.getFname()) != 0)
                return getFname().compareTo(arg0.getFname());
            else
                return getId() < arg0.getId() ? 1 : -1;
            
        }
    }
}

public class JavaSort
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(System.in);
        int testCases = Integer.parseInt(in.nextLine());
      
        List<Student> studentList = new ArrayList<Student>();
      
        while(testCases > 0)
        {
            int id = in.nextInt();
            String fname = in.next();
            double cgpa = in.nextDouble();
         
            Student st = new Student(id, fname, cgpa);
            studentList.add(st);
         
            testCases--;
        }

        Collections.sort(studentList);
      
        for(Student st: studentList)
        {
            System.out.println(st.getFname());
        }
    }
}
