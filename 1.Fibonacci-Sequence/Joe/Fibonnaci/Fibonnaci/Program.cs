using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonnaci
{
	class Program
	{
		static void Main(string [] args)
		{
			int answerInt = 0;
			string sequence;
			answerInt = GetInteger();
			sequence = CalculateFibonnaci(answerInt);
			OuptutSequence(sequence);
			//Console.ReadLine();
		}

		private static int GetInteger()
		{
			bool isInteger = false;
			int inputInteger = 0;
			Console.WriteLine("Enter an Integer Number");
			var number = Console.ReadLine();
			isInteger= int.TryParse(number,out inputInteger);
			if (isInteger)
			{
				return inputInteger;
			}
			else OutputError("Input must be an integer value e.g 10"); //if not integer output error message and retry
			return 10;
		}
		private static string CalculateFibonnaci(int number = 2)
		{
			int result = 0;
			StringBuilder fibonaci = new StringBuilder();
			fibonaci.Append("Sequence : ");
			number++;
			for (int i = 0; i < number; i++)
			{
				result += i;
				fibonaci.Append(i.ToString()+" , ");
			}
			fibonaci.Append(" = "+result.ToString());
			return fibonaci.ToString();
		}

		private static void OutputError(string errorMessage)
		{
			Console.WriteLine(errorMessage);
			Console.WriteLine("Please Try again");
			GetInteger();
		}

		private static void OuptutSequence(string sequence)
		{
			Console.WriteLine(sequence);
			Console.ReadLine();
			GetInteger();
		}
	}
}
