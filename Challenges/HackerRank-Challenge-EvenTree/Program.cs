using System;
using System.Linq;

namespace HackerRank_Challenge_EvenTree
{
	internal class Program
	{
		private static void Main()
		{
			var inputs = Console.ReadLine().Split(' ');
			var n = Convert.ToInt32(inputs[0]);
			var m = Convert.ToInt32(inputs[1]);

			var arvore = new int[n];
			var contador = new int[n];

			for (var i = 0; i < contador.Length; i++)
				contador[i] = 1;

			for (var i = 0; i < m; i++)
			{
				var inputs2 = Console.ReadLine().Split(' ');
				var n2 = Convert.ToInt32(inputs2[0]);
				var m2 = Convert.ToInt32(inputs2[1]);

				arvore[n2 - 1] = m2;
				contador[m2 - 1] += contador[n2 - 1];
				var root = arvore[m2 - 1];
				while (root != 0)
				{
					contador[root - 1] += contador[n2 - 1];
					root = arvore[root - 1];
				}
			}

			var counter = -1 + contador.Count(t => t % 2 == 0);
			Console.WriteLine(counter);
		}
	}
}