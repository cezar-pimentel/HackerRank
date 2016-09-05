using System;

namespace HackerRank_Challenge_StrangeCounter
{
	internal class Program
	{
		private static void Main()
		{
			var t = Convert.ToInt64(Console.ReadLine());
			long t1 = 1;
			long t2 = 3;
			long v1 = 3;

			while (!(t1 <= t && t < t2))
			{
				t1 += v1;
				v1 *= 2;
				t2 = (t1 + v1 - 1);
			}
			Console.WriteLine((v1 - (t - t1)));
			Console.ReadLine();
		}
	}
}