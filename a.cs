using System;
using System.Collections.Generic;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um número inteiro positivo: ");
			int num = int.Parse(Console.ReadLine());
			
			for(int i = 0; i <= num; i++) {
				if (i % 2 == 0) {
					Console.Write("{0} ", i);
				}
			}
			Console.WriteLine();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
