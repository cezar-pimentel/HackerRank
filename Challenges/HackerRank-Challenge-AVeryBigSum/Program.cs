using System;
using System.Linq;

namespace HackerRank_Challenge_AVeryBigSum
{
	internal class Program
	{
		private static void Main()
		{
			var n = Convert.ToInt32(Console.ReadLine());
			var arr_temp = Console.ReadLine().Split(' ');
			var arr = Array.ConvertAll(arr_temp, int.Parse);
			var res = new System.Numerics.BigInteger();
			res = arr.Aggregate(res, (current, item) => current + item);
			Console.WriteLine(res);
			Console.ReadLine();
		}
	}
}