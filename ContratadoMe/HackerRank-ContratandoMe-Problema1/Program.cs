using System;

namespace HackerRank2
{
	internal class Program
	{
		private static void Main()
		{
			var m = 3; // Valor máximo
			var k = 2; // Incremento

			var v = new[] { 1, 2, 3 };
			var maximoSomaAntesDeEstourar = 0;

			for (var i = 0; i < v.Length; i++)
			{
				var somaAntesDeEstourar = 0;
				var valor = v[i];

				do
				{
					valor = valor + k;
					somaAntesDeEstourar++;
				} while (valor <= m);

				if (somaAntesDeEstourar > maximoSomaAntesDeEstourar)
					maximoSomaAntesDeEstourar = somaAntesDeEstourar;
			}

			Console.WriteLine(maximoSomaAntesDeEstourar);
			Console.ReadLine();
		}
	}
}