using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class MyInsertionSort
    {
        static void Main(string[] args)
        {
            var numList = new int[] { 4, 7, 1, -1, 12, 9, 4 };
            numList.Print();
            DoInsertionSort(numList);
            numList.Print();
        }

        private static void DoInsertionSort(int[] numList)
        {
            int length = numList.Length;
            int j,temp;
            for (int i = 0; i < length; i++)
            {
                j = i + 1;
                temp = numList[j];
                while (j!=-1 && numList[j] < numList[j - 1])
                {
                    numList[j] = numList[j-1];
                    j--;
                }
                numList[j] = temp;
            }
        }
    }
}
