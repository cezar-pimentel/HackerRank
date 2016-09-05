using System;

namespace HackerRank_Challenge_Staircase
{
	internal class Program
	{
		private static void Main()
		{
			var n = Convert.ToInt32(Console.ReadLine());
			for (var i = 1; i <= n; i++)
			{
				var text = "";
				var j = 1;
				while (j <= i)
				{
					text += "#";
					j++;
				}
				Console.WriteLine(text.PadLeft(n, ' '));
			}
			Console.ReadLine();
		}
	}
}