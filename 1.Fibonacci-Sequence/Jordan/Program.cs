using System;

namespace fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Program fib = new Program();
            // int number = Console.ReadLine();
            int number = Convert.ToInt32(Console.ReadLine());
            fib.Fibo(number);
        }

        public int Fibo(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine(a);
            return a;
        }
    }
}
