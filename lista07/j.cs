using System;
using System.Collections.Generic;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite a senha: ");
			string senha;
			const string key   = "123";
			
			bool right = false;
			for (int i = 0; i < 2; i++) {
				senha = Console.ReadLine();
				
				if (senha == key) {
					right = true;
					break;
				}
			}
			
			if (right) {
				Console.WriteLine("Acertou a senha");
			} else {
				Console.WriteLine("Errou a senha com 3 tentativas.");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
