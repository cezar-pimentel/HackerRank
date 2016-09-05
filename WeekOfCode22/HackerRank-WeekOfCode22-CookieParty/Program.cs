using System;

namespace HackerRank_WeekOfCode22_CookieParty
{
	internal class Program
	{
		private static void Main()
		{
			var readLine = Console.ReadLine();
			if (!string.IsNullOrWhiteSpace(readLine))
			{
				var inputs = readLine.Split(' ');
				var n = Convert.ToInt32(inputs[0]);
				var m = Convert.ToInt32(inputs[1]);

				var rest = m % n;
				var counter = 0;
				while (rest > 0)
				{
					counter++;
					m++;
					rest = m % n;
				}

				Console.WriteLine(counter);
				Console.ReadLine();
			}
		}
	}
}