using System;

namespace RepeatedString
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = Console.ReadLine();
			long n = long.Parse(Console.ReadLine());

			int countSeqA = Count(s, 'a');
			long countSeq = n / s.Length;
			int residual = (int)(n - (countSeq * s.Length));
			int countResidual = Count(s.Substring(0, residual), 'a');
			long count = (countSeqA * countSeq) + countResidual;

			Console.WriteLine(count);
		}

		static int Count(string s, char c)
		{
			int count = 0;

			foreach (char c_s in s)
				if (c_s == c)
					count++;

			return count;
		}
	}
}
