using System;

namespace FibonacciSequence {
	class Program {
		static void Main(string[] args)
		{

			bool exit = false;

			while (!exit)
			{
				Console.WriteLine("Enter a number");
				try
				{
					int pos = Convert.ToInt32(Console.ReadLine());
					SequenceCalulator calc = new SequenceCalulator();
					int result = calc.Calc(pos);

					Console.WriteLine($"The Fibonacci of {pos}th term is {result}");
				}
				catch (Exception)
				{
					exit = true;
				}
			}
		}
	}
}
