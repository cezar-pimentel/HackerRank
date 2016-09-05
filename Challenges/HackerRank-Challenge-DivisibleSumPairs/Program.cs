using System;

namespace HackerRank_Challenge_DivisibleSumPairs
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var input1 = Console.ReadLine().Split(' ');
			var n = Convert.ToInt32(input1[0]);
			var k = Convert.ToInt32(input1[1]);

			var input2 = Console.ReadLine().Split(' ');
			var array = Array.ConvertAll(input2, int.Parse);

			var total = 0;
			for (var x = array.Length - 1; x >= 1; x--)
			{
				var val1 = array[x];

				for (var y = x - 1; y >= 0; y--)
				{
					var val2 = array[y];
					var sum = val1 + val2;

					if (sum % k == 0)
					{
						total++;
					}
				}
			}

			Console.WriteLine(total);
			Console.ReadLine();
		}
	}
}