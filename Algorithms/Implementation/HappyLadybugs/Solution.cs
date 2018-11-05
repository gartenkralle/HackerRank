using System;
using System.Linq;

namespace HappyLadybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int g = int.Parse(Console.ReadLine());

            for (int i = 0; i < g; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string b = Console.ReadLine();

                Console.WriteLine(HappyLadybugs(b));
            }
        }

        static string HappyLadybugs(string b)
        {
            if (IsLadybugHappy(b))
                return "YES";
            else
                return "NO";
        }

        static bool IsLadybugHappy(string b)
        {
            if (b.Contains('_'))
            {
                b = string.Concat(b.OrderBy(c => c));
                b = b.Replace("_", "");
            }

            b = "-" + b + "-";

            for (int i = 1; i < (b.Length - 1); i++)
            {
                if (!((b[i - 1] == b[i]) || (b[i] == b[i + 1])))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
