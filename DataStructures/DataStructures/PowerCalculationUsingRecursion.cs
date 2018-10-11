using System;

namespace DataStructures
{
    public class PowerCalculationUsingRecursion
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power");
            var x = Convert.ToInt32(Console.ReadLine());

            var answer = NPowerX(n, x);
            Console.WriteLine(answer);
        }

        private static long NPowerX(int n, int x)
        {
            if (x == 0)
                return 1;
            return n * NPowerX(n, x - 1);
        }
    }
}