using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Escolha 1, 2, ou 3: ");
			int option = int.Parse(Console.ReadLine());
			
			if (option <= 1) {
				Console.WriteLine("skibidi toilet");
			} else if (option == 2) {
				Console.WriteLine("Sigma boi");
			} else {
				Console.WriteLine("Fortnite burger");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
