using System;
using System.Collections.Generic;

namespace HackerRank_Challenge_FibonacciModified
{
	internal class Program
	{
		private static void Main()
		{
			var inputs = Console.ReadLine().Split(' ');
			var t1 = Convert.ToInt32(inputs[0]);
			var t2 = Convert.ToInt32(inputs[1]);
			var n = Convert.ToInt32(inputs[2]);
			var nums = new List<System.Numerics.BigInteger> { t1, t2 };

			for (var i = 0; i < n; i++)
			{
				var newNumber = (nums[i] + System.Numerics.BigInteger.Pow(nums[i + 1], 2));
				nums.Add(newNumber);
			}

			Console.WriteLine(nums[n - 1]);
		}
	}
}