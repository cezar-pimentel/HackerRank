using System;
using System.Collections.Generic;

namespace HackerRank_Challenge_MinimumDistances
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var n = Convert.ToInt32(Console.ReadLine());
			var input = Console.ReadLine().Split(' ');
			var array = Array.ConvertAll(input, int.Parse);
			var distance = -1;

			var dic = new Dictionary<int, int>();

			for (var x = 0; x < array.Length; x++)
			{
				int foundIndex;
				if (!dic.TryGetValue(array[x], out foundIndex))
				{
					dic.Add(array[x], x);
				}
				else
				{
					int dif = Math.Abs(x - foundIndex);
					if (dif < distance || distance == -1)
					{
						distance = dif;
					}
				}
			}

			Console.Write(distance);
			Console.ReadLine();
		}
	}
}