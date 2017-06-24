using System;

namespace MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string originalMessage = "";

            int sosCount = 0;
            int changedCharsCount = 0;

            sosCount = s.Length / 3;

            for (int i = 0; i < sosCount; i++)
            {
                originalMessage += "SOS";
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != originalMessage[i])
                    changedCharsCount++;
            }

            Console.WriteLine(changedCharsCount);
        }
    }
}
