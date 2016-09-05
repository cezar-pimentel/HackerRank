using System;
using System.Linq;

namespace HackerRank_Challenge_SimpleArraySum
{
	internal class Program
	{
		private static void Main()
		{
			var n = Convert.ToInt32(Console.ReadLine());
			var arr_temp = Console.ReadLine().Split(' ');
			var arr = Array.ConvertAll(arr_temp, int.Parse);
			var counter = arr.Sum();
			Console.WriteLine(counter);
			Console.ReadLine();
		}
	}
}