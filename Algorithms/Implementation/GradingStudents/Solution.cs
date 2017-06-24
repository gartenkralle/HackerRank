using System;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int grade = int.Parse(Console.ReadLine());

                if(grade >= 38)
                {
                    int residual = grade % 5;

                    if ((residual % 5) > 2)
                        grade += (5 - residual);
                }

                Console.WriteLine(grade);
            }
        }
    }
}
