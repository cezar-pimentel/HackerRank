using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_Challenge_Gemstones
{
	internal class Program
	{
		private static void Main()
		{
			var inputs = new List<string>();
			var N = Convert.ToInt32(Console.ReadLine());

			for (var i = 1; i <= N; i++)
			{
				inputs.Add(Console.ReadLine());
			}

			var allCharLists = inputs.Select(input => input.Distinct().ToList()).ToList();

			var finalList = IntersectAllLists(allCharLists);
			Console.WriteLine($"{finalList.Count}");
			Console.ReadLine();
		}

		private static List<T> IntersectAllLists<T>(IEnumerable<IEnumerable<T>> lists)
		{
			HashSet<T> hashSet = null;
			foreach (var list in lists)
			{
				if (hashSet == null)
					hashSet = new HashSet<T>(list);
				else
					hashSet.IntersectWith(list);
			}
			return hashSet?.ToList() ?? new List<T>();
		}
	}
}