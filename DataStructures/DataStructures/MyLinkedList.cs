using System;

namespace DataStructures
{
    internal class MyLinkedList<T>
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
            if (start.data.Equals(deleteData))
            {
                start = start.next;
                return;
            }
            var tempNode = start;
            var prevNode = start;
            while (tempNode != null)
            {
                if (tempNode.data.Equals(deleteData))
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


        public void Reverse()
        {
            if (start?.next == null)
            {
                return;
            }

            var previousNode = start;
            var currentNode = start.next;
            var nextNode = currentNode.next;

            previousNode.next = null;

            while (nextNode != null)
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
            var count = 1;
            var newNode = new Node {data = data};
            var tempNode = start;
            if (position == 1)
            {
                newNode.next = tempNode;
                start = newNode;
                return;
            }

            while (count != position - 1 && tempNode != null)
            {
                tempNode = tempNode.next;
                count++;
            }
            if (tempNode == null)
            {
                Console.WriteLine("Node can't be inserted at given position.");
                return;
            }
            newNode.next = tempNode.next;
            tempNode.next = newNode;


            #region Naina'sCode

            /*
                        while (count != position - 1 && tempNode != null)
                        {
                            tempNode = tempNode.next;
                            count++;
                        }
                        if (count == position - 1 && tempNode != null)
                        {
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
                        Console.WriteLine("mentioned position not present");  */

            #endregion
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
            //linkedList.Insert(6,3);
            //  linkedList.Reverse();
            //  linkedList.Update(3,1);
            linkedList.Access(1);
            linkedList.Print();
            Console.ReadLine();
        }
    }

}
