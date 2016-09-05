using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_Challenge_BeautifulTriplets
{
	internal class Program
	{
		private static void Main()
		{
			var input1 = Console.ReadLine().Split(' ');
			var n = Convert.ToInt32(input1[0]);
			var d = Convert.ToInt32(input1[1]);
			var input2 = Console.ReadLine().Split(' ');
			var array = Array.ConvertAll(input2, int.Parse);
			var ss = new SortedSet<int>();

			foreach (var item in array)
				ss.Add(item);

			var count = ss.Count(item => ss.Contains(item - d) && ss.Contains(item + d));
			Console.WriteLine(count);
			Console.ReadLine();
		}
	}
}