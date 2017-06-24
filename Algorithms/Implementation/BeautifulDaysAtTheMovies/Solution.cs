using System;

namespace BeautifulDaysAtTheMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ijk = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int i = ijk[0];
            int j = ijk[1];
            int k = ijk[2];

            int count = 0;

            while(i <= j)
            {
                if ((Math.Abs(i - Reverse(i)) % k) == 0)
                    count++;

                i++;
            }

            Console.WriteLine(count);
        }

        static int Reverse(int number)
        {
            char[] charArray = number.ToString().ToCharArray();
            Array.Reverse(charArray);
            return int.Parse(new string(charArray));
        }
    }
}
