namespace DataStructures
{
    public class MyHeap
    {
        static int heapSize = 0;
        static void Main(string[] args)
        {
            int[] heap = new int[1000];

            Add(heap, 3);
            Add(heap, 4);
            Add(heap, -1);
            Add(heap, -0);
            Add(heap, -4);
            Add(heap, 5);
            Add(heap, 2);

            heap.Print(heapSize);
        }

        private static void Add(int[] heap, int item)
        {
            heap[heapSize] = item;
            Heapify(heap,heapSize);
            heapSize++;
        }

        private static void Heapify(int[] heap, int insertedLocation)
        {
            var parentIndex = (insertedLocation - 1) / 2;
            var parent = heap[parentIndex];

            var child = heap[insertedLocation];
            if (child < parent)
            {
                heap.Swap(parentIndex, insertedLocation);
                Heapify(heap, parentIndex);
            }

            //Wrote below code when we were lil less intelligent. <-- Naina doesn't agree with this. But I DO.
            /*
            if (insertedLocation % 2 == 0)
            {
                var rightIndex = insertedLocation;// parentIndex * 2 + 2;
                var rightChild = heap[rightIndex];
                if (rightChild < parent)
                {
                    heap.Swap(parentIndex, rightIndex);
                    Heapify(heap, parentIndex);
                }
            }
            else
            {
                var leftIndex = insertedLocation;// parentIndex * 2 + 1;
                var leftChild = heap[leftIndex];
                if (leftChild < parent)
                {
                    heap.Swap(parentIndex, leftIndex);
                    Heapify(heap, parentIndex);
                }
            }*/
            //var leftChild = heap[parentIndex * 2 + 1];
            //var rightChild = heap[parentIndex * 2 + 2];

        }
    }
}
