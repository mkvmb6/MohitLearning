using System;

namespace DataStructures
{
    internal class MyQueueWithArray<T>
    {
        static int front = -1;
        static int rear = -1;
        private static T[] myQueue = new T[100];

        static void Main(string[] args)
        {
            var queue = new MyQueueWithArray<int>();
            queue.EnQueue(8);
            queue.DeQueue();
            queue.DeQueue();
            queue.EnQueue(10);
            myQueue.Print(front, rear);
        }

        public T DeQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
            return myQueue[front++];
        }

        public void EnQueue(T data)
        {
            // rear = rear++; value of rear will not change here. it resulted in the out of bound exception
            rear++;
            myQueue[rear] = data;
            if (rear == 0)
            {
                front = 0;
            }
        }

        public bool IsEmpty()
        {
            return front > rear || front == -1;
        }
    }
}
