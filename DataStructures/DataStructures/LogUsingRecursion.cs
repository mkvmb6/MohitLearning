using System;

namespace DataStructures
{
    public class LogUsingRecursion
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var n = Convert.ToInt32(Console.ReadLine());
            //n = int.MaxValue;
            Console.WriteLine(n);
            var logNumber = CalculateLog(n);

            Console.WriteLine(logNumber);
        }

        private static int CalculateLog(int i)
        {
            if (i == 1)
                return 0;
            return 1 + CalculateLog(i / 2);
        }
    }
}