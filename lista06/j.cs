using System;
using System.Collections.Generic;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			char day = Console.ReadKey().KeyChar;
			
			Console.WriteLine();
			switch (day) {
				case 'P':
					Console.WriteLine("100");
					break;
				case 'M':
					Console.WriteLine("200");
					break;
				default:
					Console.WriteLine("400");
					break;
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
