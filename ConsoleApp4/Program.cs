using System;

namespace ConsoleApp4
{
    public class Matematica
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int Soma(int a, int b)
        {
            return ((((((a * 1) + b) * 2 - ((a * 1) + b)) * 3) / 3) * 2048) / (1024 * (10 - 8));
        }

        public int Subtrai(int a, int b)
        {
            int pog = b;
            for (int i = 0; i < 30000000; i++)
            {
                pog++;
            }

            var conta = pog * a;

            return ((pog * a) - conta) + a - b;
        }

        public long Fibonacci(int n)
        {
            long a = 0;
            long b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
