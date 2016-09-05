using System;

namespace HackerRank_Challenge_InsertionSortPart1
{
	internal class Program
	{
		private static void insertionSort(int[] ar)
		{
			var runOnce = true;
			var numberToShift = 0;

			for (var i = ar.Length - 1; i >= 0; i--)
			{
				if (runOnce)
				{
					numberToShift = ar[i];
					runOnce = false;
				}

				if (i == 0)
				{
					ar[i] = numberToShift;
				}
				else
				{
					var prev = ar[i - 1];
					if (prev > numberToShift)
					{
						ar[i] = prev;
					}
					else
					{
						ar[i] = numberToShift;
					}
				}

				var numbers = "";
				foreach (var n in ar)
				{
					numbers += $"{n} ";
				}
				Console.WriteLine(numbers);

				if (ar[i] == numberToShift)
				{
					break;
				}
			}
		}

		private static void Main()
		{
			var _ar_size = Convert.ToInt32(Console.ReadLine());
			var _ar = new int[_ar_size];
			var elements = Console.ReadLine();
			var split_elements = elements.Split(' ');
			for (var _ar_i = 0; _ar_i < _ar_size; _ar_i++)
			{
				_ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
			}

			insertionSort(_ar);
		}
	}
}