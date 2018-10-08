using System;

namespace DataStructures
{
    public class RecursionFibonacci
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var n = Convert.ToInt32(Console.ReadLine());
            var fibonacci = Fibonacci(n);

            Console.WriteLine(fibonacci);
        }

        private static int Fibonacci(int i)
        {
            if (i <= 1)
                return i;

            return Fibonacci(i - 1) + Fibonacci(i - 2);
        }
    }
}