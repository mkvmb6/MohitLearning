using System;

namespace DataStructures
{
    public class MyMergeSort
    {
        static void Main(string[] args)
        {
            var array = new int[] { 2,1,6 };
            array.Print();
            var sortedArray = SortByMerge(array);
            sortedArray.Print();
        }

        private static int[] SortByMerge(int[] array)
        {
            int length = array.Length;
            if (length == 1)
            {
                return array;
            }

            int[] leftArray = new int[length / 2];
            int rightArraySize = (length % 2 == 0) ? length / 2 : length / 2 + 1;
            int[] rightArray = new int[rightArraySize];

            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = array[i];
            }

            int j = 0;
            for (int i = leftArray.Length; i < array.Length; i++, j++)
            {
                rightArray[j] = array[i];
            }

            return MergeArrays(SortByMerge(leftArray), SortByMerge(rightArray));
        }

        private static int[] MergeArrays(int[] leftArray, int[] rightArray)
        {
            int[] combinedSortedArray = new int[leftArray.Length + rightArray.Length];

            int left = 0, right = 0, i = 0;
            while (left < leftArray.Length && right < rightArray.Length)
            {
                if (leftArray[left] <= rightArray[right])
                {
                    combinedSortedArray[i] = leftArray[left];
                    left++;
                }
                else
                {
                    combinedSortedArray[i] = rightArray[right];
                    right++;
                }
                i++;
            }

            while (left < leftArray.Length)
            {
                combinedSortedArray[i] = leftArray[left];
                left++;
                i++;
            }

            while (right < rightArray.Length)
            {
                combinedSortedArray[i] = rightArray[right];
                right++;
                i++;
            }

            return combinedSortedArray;
        }
    }
}
