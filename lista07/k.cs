using System;
using System.Collections.Generic;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n = 0, sum = 0;
			do {
				sum += n;
				Console.Write("Digite um numero: ");
				n = int.Parse(Console.ReadLine());
			}while (n >= 0);
			
			Console.WriteLine(sum);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
