using System;
using System.Text;

namespace SherlockAndTheBeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = Int32.Parse(Console.ReadLine());
                StringBuilder maxNumber = new StringBuilder("-1");

                for (int j = 0; j <= N; j++)
                {
                    if ((((N - j) % 3) == 0) && ((j % 5) == 0))
                    {
                        maxNumber.Clear();
                        maxNumber.Append('5', (N - j));
                        maxNumber.Append('3', (j));
                        break;
                    }
                }

                Console.WriteLine(maxNumber);
            }
        }
    }
}
