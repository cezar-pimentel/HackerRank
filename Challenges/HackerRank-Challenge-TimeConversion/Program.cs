using System;

namespace HackerRank_Challenge_TimeConversion
{
	internal class Program
	{
		private static void Main()
		{
			var time = Console.ReadLine();
			Console.WriteLine($"{Convert.ToDateTime(time):HH:mm:ss}");
			Console.ReadLine();
		}
	}
}