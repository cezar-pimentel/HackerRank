using System;

namespace HackerRank_Challenge_JumpingOnTheClouds
{
	internal class Program
	{
		private static void Main()
		{
			var n = Convert.ToInt32(Console.ReadLine());
			var input = Console.ReadLine().Split(' ');
			var array = Array.ConvertAll(input, int.Parse);

			var counter = -1;
			for (var i = 0; i < array.Length; i++, counter++)
			{
				if (i < (n - 2) && array[i + 2] == 0)
					i++;
			}

			Console.WriteLine(counter);
			Console.ReadLine();
		}
	}
}