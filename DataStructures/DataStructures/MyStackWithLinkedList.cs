using System;

namespace DataStructures
{
    internal class MyStackWithLinkedList
    {
        private Node top;

        private class Node
        {
            public int Data;
            public Node Previous;
        }

        static void Main(string[] args)
        {
            var obj = new MyStackWithLinkedList();
            obj.Push(8);
            PopLastElement(obj);
            PopLastElement(obj);
            PrintTheLastElement(obj);
            obj.Push(10);
            obj.Push(9);
            PrintTheLastElement(obj);
        }

        private static void PopLastElement(MyStackWithLinkedList obj)
        {
            int number;
            number = obj.Pop();
            if (number != int.MinValue)
            {
                Console.WriteLine("Popped {0}", number);
            }
        }

        private static void PrintTheLastElement(MyStackWithLinkedList obj)
        {
            int number;
            number = obj.Peek();
            if (number != int.MinValue)
            {
                Console.WriteLine("Last element {0}", number);
            }
        }

        public void Push(int number)
        {
            var node = new Node();

            node.Data = number;
            node.Previous = top;
            top = node;
        }

        public int Pop()
        {

            var temp = top;
            if (top == null)
            {
                Console.WriteLine("Nothing to Pop");
                return int.MinValue;
            }
            var poppedNumber = top.Data;
            top = top.Previous;
            temp.Previous = null;
            return poppedNumber;
        }

        public int Peek()
        {
            if (top != null) return top.Data;
            Console.WriteLine("Stack is empty");
            return int.MinValue;
        }

    }
}
