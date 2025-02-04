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
			
			for(int i = 1; i < 11; i++) {
				Console.Write("{0} ", num*i);
			}
			Console.WriteLine();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
