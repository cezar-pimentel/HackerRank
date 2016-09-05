using System;

namespace HackerRank_Challenge_Kangaroo
{
	internal class Program
	{
		private static void Main()
		{
			var inputs = Console.ReadLine().Split(' ');
			var x1 = Convert.ToInt32(inputs[0]);
			var v1 = Convert.ToInt32(inputs[1]);
			var x2 = Convert.ToInt32(inputs[2]);
			var v2 = Convert.ToInt32(inputs[3]);

			var resx = x1 - x2;
			var resv = v2 - v1;

			if (resv == 0)
			{
				Console.WriteLine("NO");
			}
			else if ((resx % resv == 0) && (resx / resv > 0))
			{
				Console.WriteLine("YES");
			}
			else
			{
				Console.WriteLine("NO");
			}
		}
	}
}