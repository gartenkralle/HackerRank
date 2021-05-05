using System;
using System.Collections.Generic;
using System.Text;

namespace TheTrigram
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = ReadMultipleLines();

            string[] sentences = s.Split('.');

            Dictionary<string, TrigramInfo> keyValuePairs = new Dictionary<string, TrigramInfo>();

            for (int i = 0; i < sentences.Length; i++)
            {
                string[] words = sentences[i].Trim().Split(' ');

                for (int j = 2; j < words.Length; j++)
                {
                    string key = $"{words[j - 2]} {words[j - 1]} {words[j]}".ToLower();

                    if (!keyValuePairs.ContainsKey(key))
                    {
                        keyValuePairs.Add(key, new TrigramInfo(1, i));
                    }
                    else
                    {
                        TrigramInfo trigramInfo = keyValuePairs[key];
                        trigramInfo.Frequency++;
                        keyValuePairs[key] = trigramInfo;
                    }
                }
            }

            Console.WriteLine(GetFirstKeyWithHighestValue(keyValuePairs));
        }

        private static string GetFirstKeyWithHighestValue(Dictionary<string, TrigramInfo> keyValuePairs)
        {
            int highestFrequency = 0;
            int firstOccurence = int.MaxValue;

            string key = string.Empty;

            foreach (KeyValuePair<string, TrigramInfo> keyValuePair in keyValuePairs)
            {
                if (keyValuePair.Value.Frequency > highestFrequency)
                {
                    highestFrequency = keyValuePair.Value.Frequency;
                    firstOccurence = keyValuePair.Value.FirstOccurence;
                    key = keyValuePair.Key;
                }
                else if (keyValuePair.Value.Frequency == highestFrequency && keyValuePair.Value.FirstOccurence < firstOccurence)
                {
                    firstOccurence = keyValuePair.Value.FirstOccurence;
                    key = keyValuePair.Key;
                }
            }

            return key;
        }

        struct TrigramInfo
        {
            public int Frequency { get; set; }
            public int FirstOccurence { get; set; }

            public TrigramInfo(int frequency, int firstOccurence)
            {
                Frequency = frequency;
                FirstOccurence = firstOccurence;
            }
        }

        private static string ReadMultipleLines()
        {
            StringBuilder stringBuilder = new StringBuilder();
            int character;

            while ((character = Console.Read()) > -1)
            {
                stringBuilder.Append(Convert.ToChar(character));
            }

            return stringBuilder.ToString();
        }
    }
}
