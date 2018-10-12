namespace DataStructures
{
   public class MyMergeSort
    {
        static void Main(string[] args)
        {
            var a = new int[] {2, 6, 4, 9, 2, 8};
            var MergeSortResult = SortByMerge(a);
        }

        private static int[] SortByMerge(int[] array)
        {
            Divide(array);
        }

        private static void Divide(int[] array)
        {
            int length = array.Length;
            var firstArray = int[length / 2 + 1]{};
            var secondArray=


            if( !array.Length == 1)

            return Divide((array) / 2);
        }
    }
}
