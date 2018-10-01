using System;
using System.Xml;
using DataStructures;

namespace DataStructures
{
    public class MyDoublyLinkedList<T>
    {
        private Node start;

        private class Node
        {
            public Node previous;
            public T data;
            public Node next;
        }

        public void Add(T data)
        {
            //add to the end
            //when no elements are there
            //when elements are there

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
                newNode.previous = tempNode;
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

            //when one element is there
            //the normal use case
            if (start == null)
            {
                Console.WriteLine("Node is not present in the list.");
                return;
            }
            //if the list contains elements but the first value is the data to be deleted
            if (start.data.Equals(deleteData))
            {
                start = start.next;
                start.previous = null;
                Console.WriteLine($"{deleteData} node deleted successfully.");
                return;
            }
            var tempNode = start;
          
            while (tempNode != null)
            {
                if (tempNode.data.Equals(deleteData))
                {
                    tempNode.previous.next = tempNode.next;
                    if (tempNode.next!=null)
                    {
                    tempNode.next.previous = tempNode.previous;

                    }

                    tempNode.previous = null;
                    //tempNode.next = null;
                    Console.WriteLine($"{deleteData} node deleted successfully.");
                    //return;
                }
               
                    tempNode = tempNode.next;
                }

            Console.WriteLine($"{deleteData} node is not present in the list.");
        }

        public void Access(int position)
        {
            if (start == null)
            {
                Console.WriteLine("The list is empty. Nothing To access");
                return;
            }
            var tempNode = start;
            var count = 1;
            while (count != position)
            {
                if (tempNode == null)
                {
                    Console.WriteLine("There is no data in the mentioned postion.cant Access");
                    return;
                }
                tempNode = tempNode.next;
                count++;
            }
            if (tempNode != null)
            {

                Console.WriteLine("the data is : {0} ,  the given position is  {1}", tempNode.data, position);
                return;
            }
            Console.WriteLine("there is no data in the given positon {0}. Nothing to access", position);
        }
        public void Update(T data, int position)
        {
            if (start == null)
            {
                Console.WriteLine("The list is empty. Cant update anything");
                return;
            }
            var tempNode = start;
            var count = 1;
            while (count != position)
            {
                if (tempNode == null)
                {
                    Console.WriteLine("There is no data in the mentioned postion.cant update");
                    return;
                }
                tempNode = tempNode.next;
                count++;
            }
            if (tempNode != null)
            {
                tempNode.data = data;
                Console.WriteLine("the data {0} is updated in the given position {1}", data, position);
                return;
            }
            Console.WriteLine("there is no data in the given positon, its null");
        }

        public void Reverse()
        {
            if (start?.next == null)
            {
                return;
            }

          //  var previousNode = start;
            var currentNode = start;
            var nextNode = currentNode.next;
            currentNode.next = null;

           // previousNode.next = null;

            while (nextNode != null)
            {
                currentNode.next = currentNode.previous;
                currentNode.previous=currentNode.next;
                currentNode = nextNode;
                nextNode = nextNode.next;
            }
            currentNode.next = currentNode.previous;
            start = currentNode;
        }

    }
}

class MyDoublyLinkedListRunner
{
    static void Main(string[] args)
    {
        var doublyLinkedList = new MyDoublyLinkedList<int>();

        doublyLinkedList.Add(5);
        //doublyLinkedList.Add(7);
        //doublyLinkedList.Add(8);
        //doublyLinkedList.Add(7);
        //doublyLinkedList.Add(3);
        doublyLinkedList.Print();
        //doublyLinkedList.Delete(10);
        //doublyLinkedList.Delete(7);
    //   doublyLinkedList.Access(5);
        doublyLinkedList.Reverse();
        doublyLinkedList.Print();
        Console.ReadLine();
    }
}
    
