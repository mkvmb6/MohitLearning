using System;

namespace DataStructures
{
   public class RecursionFactorial
   {
       private static void Main(string[] args)
       {
           Console.WriteLine("Enter a number");
           var n = Convert.ToInt32(Console.ReadLine());
           var factorial = Factorial(n);

           Console.WriteLine(factorial);
       }

       private static int Factorial(int n)
       {
           if (n<0)
           {
               return 0;
           }
           if (n==0)
           {
               return 1;
           }
           return n * Factorial(n - 1);
       }
   }
}
