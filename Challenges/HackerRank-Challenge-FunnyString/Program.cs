using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_Challenge_FunnyString
{
	internal class Program
	{
		private static void Main()
		{
			var inputs = new List<string>();
			var t = Convert.ToInt32(Console.ReadLine());

			for (var i = 1; i <= t; i++)
			{
				inputs.Add(Console.ReadLine());
			}

			foreach (var input in inputs)
			{
				var normalString = input;
				var reverseString = new string(input.Reverse().ToArray());

				var isEqual = true;
				for (var i = 0; i < normalString.Length; i++)
				{
					var actual = i;
					var next = i + 1;

					if (actual < normalString.Length && next < normalString.Length)
					{
						var tot1 = Math.Abs((int)normalString[i] - (int)normalString[i + 1]);
						var tot2 = Math.Abs((int)reverseString[i] - (int)reverseString[i + 1]);

						isEqual = (tot1 == tot2);

						if (isEqual)
							continue;
						else
						{
							Console.WriteLine("Not Funny");
							break;
						}
					}
				}

				if (isEqual)
					Console.WriteLine("Funny");
			}
		}
	}
}