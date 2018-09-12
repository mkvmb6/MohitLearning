using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearnThreading
{
    class Program
    {
        private static object obj = new object();

        private static int count = 0; 
        static void Main(string[] args)
        {
            
            Console.WriteLine("Main method started");
            //Method1();
            //Method2();

            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            t1.Start();
            t2.Start();
            Console.WriteLine("Main method ENDED");
            Console.WriteLine("count "+count);
            

        }

        public static void Method1()
        {
            for (int i = 0; i < 2; i++)
            {
                 lock (obj)
                {
                    Console.WriteLine("tic " + i);
                    int t = count;
                    Thread.Sleep(300);
                    count= t+1;
                }
              
            }
            Console.WriteLine("Method 1 count " + count);

            Console.WriteLine();
        }

        public static void Method2()
        {
            for (int i = 0; i < 2; i++)
            {
                lock (obj)
                {
                    Console.WriteLine("tok "+i);
                    int t = count;
                    count = t + 1;
                }
            }
            Console.WriteLine("Method 2 count " + count);

            
        }
    }
}
