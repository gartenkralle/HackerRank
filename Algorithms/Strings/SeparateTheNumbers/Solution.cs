using System;

namespace SeparateTheNumbers
{
    class Program
    {
        static void Main(String[] args)
        {
            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < q; i++)
            {
                SeparationResult result = new SeparationResult(Console.ReadLine());

                if (result.IsIncreasing)
                {
                    Console.WriteLine("YES " + result.FirstNumber);
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }

    struct SeparationResult
    {
        public SeparationResult(string sequence)
        {
            IsIncreasing = false;
            FirstNumber = -1;

            for (int i = 1; i <= (sequence.Length / 2); i++)
            {
                if (TryGetSeparationResult(sequence, i, out long result))
                {
                    IsIncreasing = true;
                    FirstNumber = result;
                    break;
                }
            }
        }

        public bool IsIncreasing { get; set; }
        public long FirstNumber { get; set; }

        private bool TryGetSeparationResult(string sequence, int length, out long result)
        {
            result = -1;

            if (!TryParse(sequence.Substring(0, length), out long prevNumber))
                return false;

            result = prevNumber;

            int index = length;

            while (index < (sequence.Length - (length - 1)))
            {
                if (!TryParse(sequence.Substring(index, length), out long number))
                {
                    return false;
                }

                if (number > (prevNumber + 1))
                {
                    return false;
                }
                else if (prevNumber >= number)
                {
                    length++;
                }
                else
                {
                    index += length;
                    prevNumber = number;
                }
            }

            if (index == sequence.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool TryParse(string number, out long result)
        {
            result = -1;

            if (number[0] == '0')
            {
                return false;
            }
            else
            {
                result = long.Parse(number);
                return true;
            }
        }
    }
}
