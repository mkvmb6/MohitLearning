using System;

namespace DataStructures
{
    internal class MyQuickSort
    {
        public static void Main()
        {
            var numList = new int[] { 4, 7, 1, -1, 12, 9, 4 };
            numList.Print();
            QuickSort(numList);
            numList.Print();

        }

        private static void QuickSort(int[] numList)
        {
            int pivot = numList.Length - 1;
            QuickSort(numList, 0, numList.Length - 2, pivot);
        }

        private static void QuickSort(int[] numList, int left, int right, int pivot)
        {

            if (left==pivot)
            {
                return;
            }
            int start = left;
            int end = pivot;
            while (numList[left] < numList[pivot])
            {
                left++;
            }
            while (numList[right] > numList[pivot] && left < right)
            {
                right--;
            }

            if (left==right)
            {
                numList.Swap(pivot, left);
                QuickSort(numList, start, left - 2, left - 1);
                QuickSort(numList, left + 1, end-1, end);
            }
            else
            {
                numList.Swap(left, right);
                //QuickSort(numList, i, j, pivot);
            }
        }

        /*private static void MyQuickSort(int[] numList)
        {

        }*/
    }
}
