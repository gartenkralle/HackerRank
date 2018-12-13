using System;
using System.Linq;

namespace Day12_Inheritance
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person()
        {

        }

        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }

        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }


    class Student : Person
    {
        private int[] testScores;

        public Student(String fname, String lname, int p, int[] s) : base(fname, lname, p)
        {
            testScores = s;
        }

        public char Calculate()
        {
            int score = testScores.Sum() / testScores.Length;

            if (score < 40)
                return 'T';
            else if ((score >= 40) && (score < 55))
                return 'D';
            else if ((score >= 55) && (score < 70))
                return 'P';
            else if ((score >= 70) && (score < 80))
                return 'A';
            else if ((score >= 80) && (score < 90))
                return 'E';
            else if ((score >= 90) && (score <= 100))
                return 'O';

            return '-';
        }
    }

    class Program
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];

            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}
