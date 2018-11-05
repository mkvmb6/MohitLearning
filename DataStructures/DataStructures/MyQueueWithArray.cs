using System;

namespace DataStructures
{
    internal class MyQueueWithArray
    {
        static int front = -1;
        static int rear = -1;
        private static int[] myQueue = new int[100];

        static void Main(string[] args)
        {
            EnQueue(8);
            DeQueue();
            DeQueue();
            EnQueue(10);
            myQueue.Print(front, rear);
        }

        private static int DeQueue()
        {
            if (front > rear || front == -1)
            {
                Console.WriteLine("Queue is empty");
                return int.MinValue;
            }
            return myQueue[front++];
        }

        private static void EnQueue(int number)
        {
            // rear = rear++; value of rear will not change here. it resulted in the out of bound exception
            rear++;
            myQueue[rear] = number;
            if (rear == 0)
            {
                front = 0;
            }
        }
    }
}
