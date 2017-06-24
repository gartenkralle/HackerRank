using System;

namespace DesignerPDFViewer
{
	class Program
	{
		static void Main(string[] args)
		{
			byte[] h = Array.ConvertAll(Console.ReadLine().Split(' '), byte.Parse);
			string s = Console.ReadLine();

			int area = 0;
			int maxHeight = int.MinValue;

			foreach (char c in s)
			{
				int currentHeight = h[Convert.ToInt32(c) - 97];

				if (currentHeight > maxHeight)
					maxHeight = currentHeight;
			}

			area = maxHeight * s.Length;

			Console.WriteLine(area);
		}
	}
}
