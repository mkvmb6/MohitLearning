using System;

namespace DataStructures
{
    class MySearching
    {
        static void Main(string[] args)
        {
           // var numbers = new[] {5, 1, 3, 9, 0, 11, 7};
            var numbers = new[] { 1,4,6,8,15 };

            Console.WriteLine("Enter the number to search.");
            var numberToSearch = int.Parse(Console.ReadLine());
            int location;
         //   bool isNumberPresent = IsNumberPresent(numbers, numberToSearch, out location);
            bool isNumberPresent = BinarySearch(numbers, numberToSearch, out location);
            Console.WriteLine(isNumberPresent
                ? "Number is present in the list at position " + (location+1) + "."
                : "Number is not present in the list.");
            Console.ReadKey();
        }

        //Linear search
        private static bool LinearSearch(int[] numbers, int numberToSearch, out int location)
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


        private static bool BinarySearch(int[] numbers, int key, out int location)
        {
            location = -1;

            var low = 0;
            var n = numbers.Length;
            var high = n-1;
            int mid;
            while (low<=high)
            {
                mid = (low + high) / 2;
                if (key == numbers[mid])
                {
                   // Console.WriteLine("number {0} is present in location {1}", key,mid);
                    location = mid;
                    return true;
                }
                if (key < numbers[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
           // Console.WriteLine("Element not present");
            return false;
        }
    }
}
