using System;

namespace DataStructures
{
  public class MyBubbleSort
    {
        public static void Main()
        {
            var numList = new int[] {4, 7, 1,-1, 12, 9, 4};
            numList.Print();
            DoBubbleSort(numList);
            numList.Print();

        }

        private static void DoBubbleSort(int[] numList)
        {
            int length = numList.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (numList[j] > numList[j + 1])
                    {
                        numList.Swap(j, j + 1);
                    }
                }

            }
        }
    }
}
