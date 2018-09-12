using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine(i);
            //    for (int j = 0; j < number/2; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}

            for (int i = number; i >0; i=i/2)
            {
                Console.WriteLine(i);
                for (int j = i; j >0; j--)
                {
                    Console.WriteLine(j);
                    
                }
            }
        }
    }
}
