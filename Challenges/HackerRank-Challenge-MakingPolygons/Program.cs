using System;
using System.Linq;

namespace HackerRank_Challenge_MakingPolygons
{
	internal class Program
	{
		private static void Main()
		{
			var n = Convert.ToInt32(Console.ReadLine());
			var arr_temp = Console.ReadLine().Split(' ');
			var arr = Array.ConvertAll(arr_temp, int.Parse);
			int cuts;

			if (arr.Length == 1)
			{
				var arrLen1 = new decimal[3];
				decimal dividedVal = Convert.ToDecimal(arr[0] / 3);

				arrLen1[0] = dividedVal;
				arrLen1[1] = dividedVal;
				arrLen1[2] = dividedVal;

				cuts = arrLen1.Count(item => item >= (arrLen1.Sum() / 2)) - 1;
			}
			else if (arr.Length == 2)
			{
				var arrLen2 = new decimal[3];
				decimal val1 = arr[0];
				decimal val2 = arr[1];

				arrLen2[0] = Convert.ToDecimal(val1 / 2);
				arrLen2[1] = Convert.ToDecimal(val1 / 2);
				arrLen2[2] = val2;

				cuts = arrLen2.Count(item => item >= (arrLen2.Sum() / 2));
			}
			else
			{
				cuts = arr.Count(item => item >= (arr.Sum() / 2));
			}

			Console.WriteLine(cuts);
			Console.ReadLine();
		}
	}
}