namespace DataStructures
{
    internal class MyQueueWithLinkedList
    {
        private class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        }

        Node front;
        Node rear;

        public void EnQueue(int item)
        {
            var newNode = new Node(item);
            if (front == null)
            {
                front = newNode;
                rear = newNode;
                return;
            }
            rear.next = newNode;
            rear = newNode;
        }

        public int DeQueue()
        {
            if (front == null)
            {
                System.Console.WriteLine("Queue is empty.");
                return int.MinValue;
            }
            if (front == rear)
            {
                rear = null;
            }
            var deQueuedItem = front.data;
            front = front.next;
            return deQueuedItem;
        }

        public void PrintQueue()
        {
            if (front == null)
            {
                System.Console.WriteLine("Queue is empty.");
                return;
            }
            var temp = front;
            while (temp != null)
            {
                System.Console.Write(temp.data + ",");
                temp = temp.next;
            }
            System.Console.WriteLine("\n-----------------------------");
        }
    }

    class QueueDriver
    {
        static void Main(string[] args)
        {
            var myQueue = new MyQueueWithLinkedList();
            myQueue.EnQueue(3);
            myQueue.PrintQueue();
            myQueue.EnQueue(7);
            myQueue.PrintQueue();
            myQueue.DeQueue();
            myQueue.PrintQueue();
            myQueue.EnQueue(5);
            myQueue.PrintQueue();
            myQueue.EnQueue(2);
            myQueue.PrintQueue();
            myQueue.EnQueue(1);
            myQueue.PrintQueue();
            myQueue.DeQueue();
            myQueue.DeQueue();
            myQueue.DeQueue();
            myQueue.DeQueue();

            myQueue.PrintQueue();/**/

        }
    }
}
