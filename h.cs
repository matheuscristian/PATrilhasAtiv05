using System;
using System.Collections.Generic;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<char> vogais = new List<char>();
			
			vogais.Add('a');
			vogais.Add('e');
			vogais.Add('i');
			vogais.Add('o');
			vogais.Add('u');
			
			Console.Write("digite uma letra: ");
			char option = Console.ReadKey().KeyChar;
			
			bool is_vogal = false;
			foreach (var letter in vogais) {
				if (letter == option) {
					is_vogal = true;
					break;
				}
			}
			
			Console.WriteLine();
			if (is_vogal) {
				Console.WriteLine("É vogal");
			} else {
				Console.WriteLine("É consoante");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
