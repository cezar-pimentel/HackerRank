using System;
using System.Text;

namespace HackerRank_Challenge_BeautifulBinaryString
{
	internal class Program
	{
		private static void Main()
		{
			var n = Convert.ToInt32(Console.ReadLine());
			var B = Console.ReadLine();
			var counter = 0;

			var index = B.IndexOf("010", StringComparison.Ordinal);
			while (index > -1)
			{
				index = index + 2;
				var sb = new StringBuilder(B);
				var character = sb[index];

				if (character == '1')
					sb[index] = '0';
				else
					sb[index] = '1';

				B = sb.ToString();

				counter++;
				index = B.IndexOf("010", StringComparison.Ordinal);
			}

			Console.WriteLine($"{counter}");
			Console.ReadLine();
		}
	}
}