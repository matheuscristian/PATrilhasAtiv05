using System;
using System.Collections.Generic;

namespace PATrilhasAtiv05
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite vários número inteiros separados por ' ': ");
			var nums = Console.ReadLine().Split(' ');
			
			int sum = 0;
			for(int i = 0; i < nums.Length; i++) {
				sum += int.Parse(nums[i]);
			}
			Console.WriteLine(sum);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
