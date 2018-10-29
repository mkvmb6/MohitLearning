using System;

namespace DataStructures
{
    internal class MyStackWithArray
    {
        static int top = -1;
        static int[] myStack = new int[100];
        static void Main(string[] args)
        {

            Push(10);
            Peek();
            Push(3);
            Pop();
            Peek();
            Push(1);
            Peek();
            Push(7);
            Peek();
        }

        private static void Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine(myStack[top]);
        }

        private static int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            var deletedItem = myStack[top];
            Console.WriteLine($"Item {deletedItem} is popped.");
            top--;
            return deletedItem;
        }

        private static void Push(int item)
        {
            myStack[++top] = item;
            if (top == myStack.Length - 1)
            {
                CopyStack();//This is a problem.
            }
        }

        private static void CopyStack()
        {
            var newStack = new int[myStack.Length + 1];
            myStack.CopyTo(newStack, 0);
            myStack = newStack;
        }
    }
}
