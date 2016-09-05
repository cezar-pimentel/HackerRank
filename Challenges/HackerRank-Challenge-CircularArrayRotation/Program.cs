using System;
using System.Collections.Generic;

namespace HackerRank_Challenge_CircularArrayRotation
{
	internal class Program
	{
		private static void Main()
		{
			var firstLineText = Console.ReadLine().Split(' ');
			var firstLine = Array.ConvertAll(firstLineText, int.Parse);

			var arraySize = firstLine[0];
			var timesToRotate = firstLine[1];
			var numberOfQuestions = firstLine[2];

			var secondLineText = Console.ReadLine().Split(' ');
			var array = Array.ConvertAll(secondLineText, int.Parse);

			var counter = 1;
			var indexesToShow = new List<int>();
			while (counter <= numberOfQuestions)
			{
				indexesToShow.Add(Convert.ToInt32(Console.ReadLine()));
				counter++;
			}

			for (var x = 1; x <= timesToRotate; x++)
				array = Cycle(array);

			foreach (var idx in indexesToShow)
			{
				Console.WriteLine(array[idx]);
			}

			Console.ReadLine();
		}

		private static int[] Cycle(int[] actualArray)
		{
			var lastValue = actualArray[actualArray.Length - 1];
			Array.Copy(actualArray, 0, actualArray, 1, actualArray.Length - 1);
			actualArray[0] = lastValue;
			return actualArray;
		}
	}
}