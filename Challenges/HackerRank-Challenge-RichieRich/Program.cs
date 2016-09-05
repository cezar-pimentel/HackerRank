using System;
using System.Text;

namespace HackerRank_Challenge_RichieRich
{
	/*
	SOLVED WITH PHYTON:
	import sys
	import re

	n,k =map(int,input().strip().split(' '))
	S = list(map(int,re.findall(r'\d',input().strip())))
	ch_req = 0

	for i in range(int(n/2)):
		if S[i]!=S[n-i-1]:
			ch_req +=1
	if ch_req>k:
		print ("-1")
	else:
		pos = k - ch_req
		p = 0
		i = 0
		while p<pos and i<(n/2 if n%2==0 else (n/2+1)):
			if S[i]!=S[n-i-1] and (S[i] == 9 or S[n-i-1] == 9):
				S[i]=S[n-i-1]=9

			elif S[i]!=S[n-i-1]:
				S[i]=S[n-i-1]=9
				p+=1

			elif S[i]==S[n-i-1] and S[i]!=9:
				if i  == n-i-1:
					if pos-p>=1:
						S[i]=9
						p+=1
				elif pos-p>=2:
					S[i] = S[n-i-1] = 9
					p+=2
			i+=1
		while i<(n/2):
			if S[i]!=S[n-i-1]:
				a = max(S[i],S[n-i-1])
				S[i]=S[n-i-1] = a
			i+=1
		print (''.join(map(str,S)))
	*/

	internal class Program
	{
		private static void Main()
		{
			var tokens_n = Console.ReadLine().Split(' ');
			var n = Convert.ToInt32(tokens_n[0]);
			var k = Convert.ToInt32(tokens_n[1]);
			var number = Console.ReadLine();
			var sb = new StringBuilder(number);

			var numberCopy = number;
			var isPalindrome = true;

			for (var i = 0; (i) < (n / 2); i++)
			{
				if (number != null && number[i] != number[n - 1 - i])
				{
					if (k == 0)
					{
						isPalindrome = false;
						break;
					}

					k--;

					sb[n - 1 - i] = (char)Math.Max(number[i], number[n - 1 - i]);
					sb[i] = sb[n - 1 - i];
				}
			}

			for (var i = 0; (i) < (n / 2); i++)
			{
				if (k == 0)
					break;

				if (number[i] == '9')
					continue;

				if (numberCopy[i] != numberCopy[n - 1 - i])
					k++;

				if (k >= 2)
				{
					k = k - 2;
					sb[n - 1 - i] = '9';
					sb[i] = sb[n - 1 - i];
				}
			}

			if ((k != 0 && number[n / 2] != '9'))
			{
				sb[n / 2] = '9';
			}

			Console.Write((isPalindrome ? sb.ToString() : "-1"));
			Console.ReadLine();
		}
	}
}