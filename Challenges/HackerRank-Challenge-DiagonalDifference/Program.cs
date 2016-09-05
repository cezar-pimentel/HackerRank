using System;

namespace HackerRank_Challenge_DiagonalDifference
{
	internal class Program
	{
		private static void Main()
		{
			var n = Convert.ToInt32(Console.ReadLine());
			var a = new int[n][];
			for (var a_i = 0; a_i < n; a_i++)
			{
				var a_temp = Console.ReadLine().Split(' ');
				a[a_i] = Array.ConvertAll(a_temp, int.Parse);
			}

			var firstDiag = 0;
			for (var i = 0; i < n; i++)
			{
				firstDiag += a[i][i];
			}

			var secDiag = 0;
			var startIndex = 0;
			var endIndex = a.Length - 1;

			while (endIndex >= 0)
			{
				secDiag += a[startIndex][endIndex];
				startIndex++;
				endIndex--;
			}

			var diff = Math.Abs(firstDiag - secDiag);

			Console.WriteLine(diff);
			Console.ReadLine();
		}
	}
}