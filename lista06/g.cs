using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("digite vermelho, azul ou verde: ");
			string option = Console.ReadLine().Trim().ToLower();
			
			if (option == "vermelho") {
				Console.WriteLine("escolheu vermelho");
			} else if (option == "azul") {
				Console.WriteLine("escolheu azul");
			} else {
				Console.WriteLine("escolheu verde");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
