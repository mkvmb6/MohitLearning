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
    }
}

class MyDoublyLinkedListRunner
{
    static void Main(string[] args)
    {
        var doublyLinkedList = new MyDoublyLinkedList<int>();

        doublyLinkedList.Add(5);
        doublyLinkedList.Add(7);
        doublyLinkedList.Add(8);
        doublyLinkedList.Add(7);
        doublyLinkedList.Add(3);
        doublyLinkedList.Print();
        doublyLinkedList.Delete(10);
        doublyLinkedList.Delete(7);
        doublyLinkedList.Print();
        Console.ReadLine();
    }
}
    
