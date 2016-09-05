using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

/*
	TEST CASE:
	5
	AAAA
	BBBBB
	ABABABAB
	BABABA
	AAABBB
*/

namespace HackerRank_Challenge_AlternatingCharacters
{
	internal class Program
	{
		private static void Main()
		{
			var texts = new List<string>();
			var T = Convert.ToInt32(Console.ReadLine());

			for (var i = 1; i <= T; i++)
			{
				texts.Add(Console.ReadLine());
			}

			foreach (var t in texts)
			{
				var actualLen = t.Length;
				var regex = new Regex("(.)(?<=\\1\\1)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
				var newText = regex.Replace(t, string.Empty);
				var newLen = newText.Length;
				var total = actualLen - newLen;
				Console.WriteLine($"{total}");
			}
		}
	}
}