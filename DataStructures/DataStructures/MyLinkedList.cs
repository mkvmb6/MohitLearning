using System;

namespace DataStructures
{
    public class MyLinkedList<T>
    {
        private Node start;

        private class Node
        {
            public T data;
            public Node next;

        }

        public void Add(T data)
        {
            var newNode = new Node {data = data};

            if (start == null)
            {
                start = newNode;
            }
            else
            {
                var tempNode = start;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = newNode;
            }
        }

        public void Print()
        {
            //Make sure don't modify where the start is pointing.
            //Print the whole list using Console.WriteLine();
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            var tempNode = start;
            while (tempNode != null)
            {
                Console.Write(tempNode.data + " -> ");
                tempNode = tempNode.next;
            }

            Console.WriteLine();

        }

        public void Delete(T deleteData)
        {
            if (start == null)
            {
                Console.WriteLine("Node is not present in the list.");
                return;
            }
            if (start.data .Equals( deleteData))
            {
                start = start.next;
                return;
            }
            var tempNode = start;
            var prevNode = start;
            while (tempNode != null)
            {
                if (tempNode.data.Equals( deleteData))
                {
                    prevNode.next = tempNode.next;
                    tempNode.next = null;
                    Console.WriteLine($"{deleteData} node deleted successfully.");
                    return;
                }
                prevNode = tempNode;
                tempNode = tempNode.next;
            }
            Console.WriteLine($"{deleteData} node is not present in the list.");

        }

      

        public void Reverse()
        {
            if (start?.next == null)
            {
                return;
            }

            var previousNode=start;
            var currentNode = start.next;
            var nextNode = currentNode.next;

            previousNode.next = null;

            while (nextNode!=null)
            {
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
                nextNode = nextNode.next;
            }
            currentNode.next = previousNode;
            start = currentNode;
        }



        public void Insert(T data, int position)
        {
            int count = 1;
            var tempNode = start;
            Node prevNode;
            if (position == 1)
            {
                var newNode = new Node {data = data};
                newNode.next = tempNode;
                start = newNode;
                // tempNode = tempNode.next;
                //prevNode = tempNode;
                //tempNode = tempNode.next;
                //var newNode = new Node {data = data};
                //prevNode.next = newNode;
                //newNode.next = tempNode;
                return;

            }
            while (count != position - 1 && tempNode != null)
            {
                tempNode = tempNode.next;
                count++;
            }
            if (count == position - 1 && tempNode != null)
            {
                var newNode = new Node {data = data};
                if (tempNode.next != null)
                {
                    prevNode = tempNode;
                    tempNode = tempNode.next;
                    prevNode.next = newNode;
                    newNode.next = tempNode;
                }
                else
                {
                tempNode.next = newNode;

                }
                return;
            }
            Console.WriteLine("mentioned position not present");  
        }
    }





    class MyLinkedListRunner
    {
        static void Main(string[] args)
        {
            var linkedList = new MyLinkedList<int>();

            linkedList.Add(5);
            linkedList.Add(7);
            linkedList.Add(8);
            linkedList.Add(7);
            linkedList.Print();
            //linkedList.Delete(10);
           // linkedList.Delete(8);
           linkedList.Insert(6,11);
         //  linkedList.Reverse();
            linkedList.Print();
            Console.ReadLine();
        }
    }
    
}
