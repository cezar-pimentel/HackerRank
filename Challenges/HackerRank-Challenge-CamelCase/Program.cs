using System;
using System.Linq;

namespace HackerRank_Challenge_CamelCase
{
	internal class Program
	{
		private static void Main()
		{
			var s = Console.ReadLine();

			var counter = 0;
			if (!string.IsNullOrEmpty(s))
			{
				if (s.Length > 100000)
					throw new Exception("You've input a word with more than 100,000 letters, which is the maximum allowed on this program.");

				counter++;
				counter += s.Count(char.IsUpper);
			}
			else
			{
				throw new Exception("You've input a word with less than 1 letter, which is the minimun allowed on this program.");
			}

			Console.WriteLine($"{counter}");
		}
	}
}