using System;

namespace DataStructures
{
    class MySearching
    {
        static void Main(string[] args)
        {
            var numbers = new[] {5, 1, 3, 9, 0, 11, 7};
            Console.WriteLine("Enter the number to search.");
            var numberToSearch = int.Parse(Console.ReadLine());
            int location;
            bool isNumberPresent = IsNumberPresent(numbers, numberToSearch, out location);
            Console.WriteLine(isNumberPresent
                ? "Number is present in the list at position " + (location + 1) + "."
                : "Number is not present in the list.");
            Console.ReadKey();
        }

        //Linear search
        private static bool IsNumberPresent(int[] numbers, int numberToSearch, out int location)
        {
            location = -1;
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numberToSearch)
                {
                    location = i;
                    return true;
                }
            }
            return false;
        }
    }
}
