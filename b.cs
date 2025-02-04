using System;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			DateTime sys_date = DateTime.Now;
			DateTime birth_date = new DateTime(2007, 12, 09);
			
			Console.WriteLine((sys_date - birth_date).Days);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
