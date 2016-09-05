using System;
using System.Collections.Generic;

namespace HackerRank_Challenge_Pangrams
{
	internal class Program
	{
		private static void Main()
		{
			const int totalLettersInAlphabet = 26;

			var s = Console.ReadLine();
			if (!string.IsNullOrEmpty(s))
			{
				if (s.Length > 1000)
					throw new Exception("You've input a word with more than 1000 letters, which is the maximum allowed on this program.");

				s = s.ToLower();
				if (s.Length < totalLettersInAlphabet)
				{
					Console.WriteLine("not pangram");
					return;
				}

				var dic = new List<char>();
				foreach (var c in s)
				{
					if (c >= 'a' && c <= 'z')
					{
						if (!dic.Contains(c))
						{
							dic.Add(c);
						}
					}
				}

				Console.WriteLine(dic.Count == 26 ? "pangram" : "not pangram");
			}
			else
			{
				throw new Exception("You've input a word with less than 1 letter, which is the minimun allowed on this program.");
			}
		}
	}
}