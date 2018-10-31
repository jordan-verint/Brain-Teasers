using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("The Fibonacci of " + x + " th term is "+fib(x));
		}

		//get the nth fib number
		static int fib(int n)
		{
			if(n == 0) {
				return 0;
			} 

			if(n == 1) {
				return 1;
			}

			return fib(n - 1) + fib(n - 2);
		}
	}
}
