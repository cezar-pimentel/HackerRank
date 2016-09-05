using System;

namespace HackerRank_Challenge_MarsExploration
{
	internal class Program
	{
		private static void Main()
		{
			var counter = 0;
			var S = Console.ReadLine();

			for (var i = 0; i < S.Length; i = i + 3)
			{
				if (S[i] != 'S')
					counter++;
				if (S[i + 1] != 'O')
					counter++;
				if (S[i + 2] != 'S')
					counter++;
			}

			Console.WriteLine($"{counter}");
		}
	}
}