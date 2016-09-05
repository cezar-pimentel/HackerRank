using System;
using System.Linq;

namespace HackerRank_Challenge_MatchingSets
{
	internal class Program
	{
		private static void Main()
		{
			var n = Convert.ToInt32(Console.ReadLine());
			var input1 = Console.ReadLine().Split(' ');
			var array1 = Array.ConvertAll(input1, int.Parse).OrderBy(x => x).ToArray();
			var input2 = Console.ReadLine().Split(' ');
			var array2 = Array.ConvertAll(input2, int.Parse).OrderBy(x => x).ToArray();
			var arrayDiff = new System.Numerics.BigInteger[array1.Length];
			string res;

			for (var x = 0; x < n; x++)
			{
				var val1 = array1[x];
				var val2 = array2[x];
				arrayDiff[x] = val1 - val2;
			}

			var sum = arrayDiff.Aggregate((currentSum, item) => currentSum + item);
			if (sum == 0)
			{
				System.Numerics.BigInteger totalAbs = 0;
				foreach (var item in arrayDiff)
				{
					totalAbs += System.Numerics.BigInteger.Abs(item);
				}
				res = $"{totalAbs / 2}";
			}
			else
			{
				res = "-1";
			}

			Console.WriteLine(res);

			//Console.ReadLine();

			//for (var x = 0; x < n; x++)
			//{
			//	var val1 = array1[x];
			//	var val2 = array2[x];

			//	while (val1 != val2)
			//	{
			//		if (val1 > val2)
			//		{
			//			arrayDiff[x]--;
			//			val1--;
			//		}

			//		if (val1 < val2)
			//		{
			//			arrayDiff[x]++;
			//			val1++;
			//		}
			//	}
			//}

			//Console.Clear();
			//Console.WriteLine(array1.Aggregate("", (current, item) => current + (item + ", ")));
			//Console.WriteLine(array2.Aggregate("", (current, item) => current + (item + ", ")));
			//Console.WriteLine(arrayDiff.Aggregate("", (current, item) => current + (item + ", ")));
			//Console.ReadLine();
		}
	}
}