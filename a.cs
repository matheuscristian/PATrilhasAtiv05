using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			DateTime date = DateTime.Now;
			
			Console.WriteLine(date.ToLocalTime());
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
