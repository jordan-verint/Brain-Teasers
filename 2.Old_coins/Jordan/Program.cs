using System;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money you got:");
            int getMoneys = Convert.ToInt32(Console.ReadLine());
            Coin.Calculate( getMoneys );
        }
    }

    public static class Coin
    {
        public static void Calculate(int n)
        {
            int value = n; // Initial value
            int[] moneySizes = { 100, 50, 20, 5, 2, 1 }; // Notes sizes
            int[] moneySlots = {0, 0, 0, 0, 0, 0}; // Money slots for amount sizes

            int remainder = value; // Value which is mutated
            int moneyPosition = 0; // Position in money slots
            while (remainder > 0) // While loop which loops through money slots and assigns value
            {
                moneySlots[moneyPosition] = remainder / moneySizes[moneyPosition];
                remainder -= moneySlots[moneyPosition] * moneySizes[moneyPosition];
                moneyPosition++; // Incremement through moneySlots
            }

            // YEE cant print out and array. so loop through and label the amounts with money note value
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("$"+moneySizes[i] + " : " + moneySlots[i].ToString());
            }
        }
    }
}
