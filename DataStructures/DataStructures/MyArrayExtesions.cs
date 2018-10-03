using System;

namespace DataStructures
{
    public static class MyArrayExtesions
    {
        public static void Swap<T>(this T[] array, int pos1, int pos2)
        {
            T temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;
        }

        public static void Print<T>(this T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
