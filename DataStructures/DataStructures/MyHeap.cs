using System;

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

        private static void Heapify(int[] heap,int insertLocation)
        {
            var parentIndex = (insertLocation - 1) / 2;
            var parent = heap[parentIndex];

            if (insertLocation % 2 == 0)
            {
                var rightIndex = insertLocation;// parentIndex * 2 + 2;
                var rightChild = heap[rightIndex];
                if (rightChild < parent)
                {
                    heap.Swap(parentIndex, rightIndex);
                    Heapify(heap, parentIndex);
                }
            }
            else
            {
                var leftIndex = insertLocation;// parentIndex * 2 + 1;
                var leftChild = heap[leftIndex];
                if (leftChild < parent)
                {
                    heap.Swap(parentIndex, leftIndex);
                    Heapify(heap, parentIndex);
                }
            }
            //var leftChild = heap[parentIndex * 2 + 1];
            //var rightChild = heap[parentIndex * 2 + 2];

        }
    }
}
