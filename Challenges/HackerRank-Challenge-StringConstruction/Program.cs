using System;
using System.Collections.Generic;

namespace HackerRank_Challenge_StringConstruction
{
	internal class Program
	{
		private static void Main()
		{
			var n = Convert.ToInt32(Console.ReadLine());
			var inputs = new List<string>();
			for (var a0 = 0; a0 < n; a0++)
			{
				inputs.Add(Console.ReadLine());
			}

			foreach (var input in inputs)
			{
				var hash = new HashSet<char>();
				var ca = input.ToCharArray();
				foreach (var c in ca)
				{
					hash.Add(c);
				}

				Console.WriteLine(hash.Count);
			}

			Console.ReadLine();
		}
	}
}