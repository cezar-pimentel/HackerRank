using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankSample
{
	internal class Program
	{
		private static void Main()
		{
			var f = new[] { 10670, 11057, 16111, 17203, 16390, 8500, 7551, 11517, 12848, 6988, 17875, 11571, 8500 };
			var m = new[] { 14376, 17203, 16797, 8350, 8500, 7155, 12365, 16111, 16111, 17875, 13115, 10048, 8500 };
			var listaFinal = AchaCasais(f, m);

			foreach (var i in listaFinal)
			{
				Console.Write($"{i},");
			}

			Console.ReadLine();
		}

		private static int[] AchaCasais(int[] f, int[] m)
		{
			const int minAge = 6600;
			const int maxAge = 18300;
			var res = new List<int>();

			if (f.Length < 5 || m.Length < 5 || f.Length > 1000 || m.Length > 1000)
				throw new ArgumentException("As listas f e m precisam ter no mínimo 5 elementos e no máximo 1.000.");

			if (f.Any(i => i < minAge) || m.Any(i => i < minAge) || f.Any(i => i > maxAge) || m.Any(i => i > maxAge))
				throw new ArgumentException("Os valores das listas f e m devem ser no mínimo 6600 elementos, e no máximo 18.300.");

			for (var i = 0; i < f.Length; i++)
			{
				var valF = f[i];

				for (var j = 0; j < m.Length; j++)
				{
					if (m[j] == valF)
					{
						res.Add(valF);
						m[j] = -1;
						break;
					}
				}
				f[i] = -1;
			}

			return res.OrderByDescending(i => i).ToArray();
		}
	}
}