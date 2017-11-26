using System;

namespace TheTimeInWords
{
    class Program
    {
        static void Main(String[] args)
        {
            int H = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            string timeInWords = "unknown";

            if (M == 0)
                timeInWords = GetWord(H) + " o' clock";
            else if (M == 15)
                timeInWords = "quarter past " + GetWord(H);
            else if (M == 30)
                timeInWords = "half past " + GetWord(H);
            else if (M == 45)
                timeInWords = "quarter to " + GetWord(H + 1);
            else if (M < 30)
                timeInWords = GetWord(M) + " minutes past " + GetWord(H);
            else if (M > 30)
                timeInWords = GetWord(60 - M) + " minutes to " + GetWord(H + 1);

            Console.WriteLine(timeInWords);
        }

        static string GetWord(int number)
        {
            String zero = "zero";
            String one = "one";
            String two = "two";
            String three = "three";
            String four = "four";
            String five = "five";
            String six = "six";
            String seven = "seven";
            String eight = "eight";
            String nine = "nine";
            String ten = "ten";
            String eleven = "eleven";
            String twelve = "twelve";
            String thirteen = "thirteen";
            String teen = "teen";
            String fourteen = four + teen;
            String quarter = "quarter";
            String sixteen = six + teen;
            String seventeen = seven + teen;
            String eighteen = "eighteen";
            String nineteen = nine + teen;
            String twenty = "twenty";
            String twentyone = twenty + " " + one;
            String twentytwo = twenty + " " + two;
            String twentythree = twenty + " " + three;
            String twentyfour = twenty + " " + four;
            String twentyfive = twenty + " " + five;
            String twentysix = twenty + " " + six;
            String twentyseven = twenty + " " + seven;
            String twentyeight = twenty + " " + eight;
            String twentynine = twenty + " " + nine;
            String half = "half";
            String unknown = "unknown";

            switch (number)
            {
                case 0:
                    return zero;
                case 1:
                    return one;
                case 2:
                    return two;
                case 3:
                    return three;
                case 4:
                    return four;
                case 5:
                    return five;
                case 6:
                    return six;
                case 7:
                    return seven;
                case 8:
                    return eight;
                case 9:
                    return nine;
                case 10:
                    return ten;
                case 11:
                    return eleven;
                case 12:
                    return twelve;
                case 13:
                    return thirteen;
                case 14:
                    return fourteen;
                case 15:
                    return quarter;
                case 16:
                    return sixteen;
                case 17:
                    return seventeen;
                case 18:
                    return eighteen;
                case 19:
                    return nineteen;
                case 20:
                    return twenty;
                case 21:
                    return twentyone;
                case 22:
                    return twentytwo;
                case 23:
                    return twentythree;
                case 24:
                    return twentyfour;
                case 25:
                    return twentyfive;
                case 26:
                    return twentysix;
                case 27:
                    return twentyseven;
                case 28:
                    return twentyeight;
                case 29:
                    return twentynine;
                case 30:
                    return half;
                default:
                    return unknown;
            }
        }
    }
}
