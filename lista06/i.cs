using System;
using System.Collections.Generic;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			int day = int.Parse(Console.ReadKey().KeyChar.ToString());
			
			Console.WriteLine();
			switch (day) {
				case 1:
					Console.WriteLine("Segunda");
					break;
				case 2:
					Console.WriteLine("Terça");
					break;
				case 3:
					Console.WriteLine("Quarta");
					break;
				case 4:
					Console.WriteLine("Quinta");
					break;
				case 5:
					Console.WriteLine("Sexta");
					break;	
				case 6:
					Console.WriteLine("Sabado");
					break;
				case 7:
					Console.WriteLine("Domingo");
					break;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
