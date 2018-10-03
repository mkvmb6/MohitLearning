namespace DataStructures
{
    class MySelectionSort
    {
        static void Main(string[] args)
        {
            var numList = new int[] { 4, 7, 1, -1, 12, 9, 4 };
            numList.Print();
            DoSelectionSort(numList);
            numList.Print();
        }

        private static void DoSelectionSort(int[] numList)
        {
            int length = numList.Length;
            for (int i = 0; i < length; i++)
            {
                int smallest = FindSmallest(numList, i);
                numList.Swap(smallest, i);
            }
        }

        private static int FindSmallest(int[] numList, int from)
        {
            int locationOfSmallest = from;
            for (int i = from + 1; i < numList.Length; i++)
            {
                if (numList[i] < numList[locationOfSmallest])
                {
                    locationOfSmallest = i;
                }
            }
            return locationOfSmallest;
        }
    }
}


