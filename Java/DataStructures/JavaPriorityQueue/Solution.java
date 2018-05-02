import java.util.ArrayList;
import java.util.List;
import java.util.PriorityQueue;
import java.util.Scanner;

public class Solution
{
    private final static Scanner scan = new Scanner(System.in);
    private final static Priorities priorities = new Priorities();
    
    public static void main(String[] args)
    {
        int totalEvents = Integer.parseInt(scan.nextLine());
        List<String> events = new ArrayList<>();
        
        while (totalEvents-- != 0)
        {
            String event = scan.nextLine();
            events.add(event);
        }
        
        List<Student> students = priorities.getStudents(events);
        
        if (students.isEmpty())
        {
            System.out.println("EMPTY");
        }
        else
        {
            for (Student st: students)
            {
                System.out.println(st.getName());
            }
        }
    }
}

class Student implements Comparable<Student>
{
    private int id;
    private String name;
    private double cgpa;
    
    public Student(int id, String name, double cgpa)
    {
        this.id = id;
        this.name = name;
        this.cgpa = cgpa;
    }
    
    public int getID()
    {
        return id;
    }
    
    public String getName()
    {
        return name;
    }
    
    public double getCGPA()
    {
        return cgpa;
    }

    @Override
    public int compareTo(Student student)
    {
        int result = Double.compare(student.cgpa, cgpa);
        
        if(result != 0)
        {
            return result;
        }
        
        result = name.compareTo(student.name);
        
        if(result != 0)
        {
            return result;
        }
        
        return Integer.compare(id, student.id);
    }
}

class Priorities
{
    private PriorityQueue<Student> priorityQueue = new PriorityQueue<>();
    private List<Student> result = new ArrayList<>();
    
    public List<Student> getStudents(List<String> events)
    {
        for(String event : events)
        {
            String[] _event = event.split(" ");
            String type = _event[0];
            
            switch(type)
            {
                case "ENTER":
                    String name = _event[1];
                    double cgpa = Double.parseDouble(_event[2]);
                    int id = Integer.parseInt(_event[3]);
                    
                    Student student = new Student(id, name, cgpa);
                    
                    priorityQueue.add(student);
                    break;
                case "SERVED":
                    priorityQueue.poll();
                    break;
            }
        }
        
        while(!priorityQueue.isEmpty())
        {
            result.add(priorityQueue.poll());
        }
        
        return result;
    }
}
