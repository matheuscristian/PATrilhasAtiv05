using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("digite um número: ");
			int option = int.Parse(Console.ReadLine());
			
			if (option < 0) {
				Console.WriteLine("Negativo");
			} else if (option > 0) {
				Console.WriteLine("Positivo");
			} else {
				Console.WriteLine("Zero");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
