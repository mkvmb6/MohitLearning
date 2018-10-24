using System;

namespace DataStructures
{
    internal class TowerOfHanoi
    {
        static int totalSteps = 0;
        static void Main(string[] args)
        {
            int totalDisks = 3;
            SolveTowerOfHanoi(totalDisks, "A", "B", "C");
            Console.WriteLine($"Tower of hanoi solved in {totalSteps} steps.");
            Console.ReadLine();
        }

        static void SolveTowerOfHanoi(int totalDisks, string from, string aux, string dest)
        {
            /*if (totalDisks == 1)
            {
                Console.WriteLine($"Move the disk from tower {from} to {dest}.");
                totalSteps++;
                return;
            }*/
            if (totalDisks > 0)
            {
                SolveTowerOfHanoi(totalDisks - 1, from, dest, aux);
                Console.WriteLine($"Move the disk from tower {from} to {dest}.");
                totalSteps++;
                SolveTowerOfHanoi(totalDisks - 1, aux, from, dest);
            }
            

        }
    }
}
