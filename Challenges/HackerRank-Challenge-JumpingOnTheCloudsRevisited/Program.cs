using System;

namespace HackerRank_Challenge_JumpingOnTheCloudsRevisited
{
	internal class Program
	{
		private static void Main()
		{
			var input1 = Console.ReadLine().Split(' ');
			var n = Convert.ToInt32(input1[0]);
			var k = Convert.ToInt32(input1[1]);
			var input2 = Console.ReadLine().Split(' ');
			var array = Array.ConvertAll(input2, int.Parse);
			var e = 100;

			for (var i = 0; i < n; i = k + i)
			{
				if (array[i] == 0)
					e--;
				else
					e -= 3;
			}
			Console.WriteLine(e);
			Console.ReadLine();
		}
	}
}