using System;

namespace ACMICPCTeam
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] NM = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int N = NM[0];
            int M = NM[1];

            string[] personTopicsArray = GetPersonTopicsArray(N);

            int maxTopics = GetMaxTopics(personTopicsArray);
            int maxTeams = GetMaxTeams(personTopicsArray, maxTopics);

            Console.WriteLine(maxTopics);
            Console.WriteLine(maxTeams);
        }

        private static int GetMaxTeams(string[] personTopicsArray, int maxTopics)
        {
            int count = 0;
            int N = personTopicsArray.Length;

            for (int i = 0; i < (N - 1); i++)
            {
                for (int j = (i + 1); j < N; j++)
                {
                    if (GetCurrentTopics(personTopicsArray[i], personTopicsArray[j]) == maxTopics)
                        count++;
                }
            }

            return count;
        }

        private static string[] GetPersonTopicsArray(int N)
        {
            string[] personTopicsArray = new string[N];

            for (int i = 0; i < N; i++)
            {
                personTopicsArray[i] = Console.ReadLine();
            }

            return personTopicsArray;
        }

        private static int GetMaxTopics(string[] personTopicsArray)
        {
            int maxTopics = 0;
            int N = personTopicsArray.Length;

            for (int i = 0; i < (N - 1); i++)
            {
                for (int j = (i + 1); j < N; j++)
                {
                    int currentTopics = GetCurrentTopics(personTopicsArray[i], personTopicsArray[j]);

                    if (currentTopics > maxTopics)
                        maxTopics = currentTopics;
                }
            }

            return maxTopics;
        }

        private static int GetCurrentTopics(string personTopics1, string personTopics2)
        {
            int count = 0;

            for (int i = 0; i < personTopics1.Length; i++)
            {
                if ((personTopics1[i] == '1') || (personTopics2[i] == '1'))
                    count++;
            }

            return count;
        }
    }
}
