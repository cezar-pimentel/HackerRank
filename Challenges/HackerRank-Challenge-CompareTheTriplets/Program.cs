using System;

namespace HackerRank_Challenge_CompareTheTriplets
{
	internal class Program
	{
		private static void Main()
		{
			var tokens_a0 = Console.ReadLine().Split(' ');
			var a0 = Convert.ToInt32(tokens_a0[0]);
			var a1 = Convert.ToInt32(tokens_a0[1]);
			var a2 = Convert.ToInt32(tokens_a0[2]);
			var tokens_b0 = Console.ReadLine().Split(' ');
			var b0 = Convert.ToInt32(tokens_b0[0]);
			var b1 = Convert.ToInt32(tokens_b0[1]);
			var b2 = Convert.ToInt32(tokens_b0[2]);
			var totalA = 0;
			var totalB = 0;

			if (a0 > b0)
				totalA++;

			if (a1 > b1)
				totalA++;

			if (a2 > b2)
				totalA++;

			if (a0 < b0)
				totalB++;
			if (a1 < b1)
				totalB++;
			if (a2 < b2)
				totalB++;

			Console.WriteLine($"{totalA} {totalB} ");
			Console.ReadLine();
		}
	}
}