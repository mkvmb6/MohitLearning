namespace DataStructures
{
    public class MyHeapSort
    {
        static void Main(string[] args)
        {
            var array = new int[] {3, 4, -1, -0, -4, 5, 2};
           // var array = new int[] {-4, -1, 2, 4, 0, 5, 3};
            
            array.Print();
            var sortedArray = SortByHeap(array);
            sortedArray.Print();
            
        }

        private static int[] SortByHeap(int[] array)
        {
            //heapify
            //swap
            //remove and add in the array
            Heapify(array,0,array.Length);

            var sortedArr = new int[array.Length];
            var j=0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                array.Swap(0, i);
                sortedArr[j++] = array[i];
                Heapify(array, 0,i);
            }

            return sortedArr;
        }


        private static void Heapify(int[] heap, int parentIndex,int heapLength)
        {
            var parent = heap[parentIndex];
            var leftIndex = parentIndex * 2 + 1;
            var rightIndex = parentIndex * 2 + 2;
            if (leftIndex>= heapLength)
            {
                return;

            }

            var leftChild = heap[leftIndex];

            if (rightIndex>= heapLength)
            {
                if (parent > leftChild)
                {
                    heap.Swap(leftIndex,parentIndex);
                    Heapify(heap,leftIndex, heapLength);
                    return;
                }
            }
            var rightChild = heap[rightIndex];
            
            if (parent>leftChild|| parent>rightChild)
            {
                var swapLocation = leftChild <= rightChild ? leftIndex : rightIndex;
                heap.Swap(swapLocation, parentIndex);
                Heapify(heap,swapLocation, heapLength);
            }

        }
    }
}
