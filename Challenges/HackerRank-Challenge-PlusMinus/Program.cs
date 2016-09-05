using System;

namespace HackerRank_Challenge_PlusMinus
{
	internal class Program
	{
		private static void Main()
		{
			var n = Convert.ToInt32(Console.ReadLine());
			var arr_temp = Console.ReadLine().Split(' ');
			var arr = Array.ConvertAll(arr_temp, int.Parse);

			var totalPos = 0;
			var totalNeg = 0;
			var totalZer = 0;

			foreach (var item in arr)
			{
				if (item == 0)
				{
					totalZer++;
					continue;
				}

				if (item > 0)
				{
					totalPos++;
					continue;
				}

				if (item < 0)
					totalNeg++;
			}

			var fracPos = totalPos / Convert.ToDecimal(n);
			var fracNeg = totalNeg / Convert.ToDecimal(n);
			var fracZer = totalZer / Convert.ToDecimal(n);

			Console.WriteLine($"{fracPos:0.000000}");
			Console.WriteLine($"{fracNeg:0.000000}");
			Console.WriteLine($"{fracZer:0.000000}");

			Console.ReadLine();
		}
	}
}