namespace DataStructures
{
    public class MyLinkedList
    {
        private Node start;

        private class Node
        {
            public int data;
            public Node next;

        }

        public void Add(int data)
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

        public void printList()
        {
            //Make sure don't modify where the start is pointing.
            //Print the whole list using Console.WriteLine();
        }

    }

    class MyLinkedListRunner
    {
        static void Main(string[] args)
        {
            var linkedList = new MyLinkedList();

            linkedList.Add(5);
            linkedList.Add(7);
            linkedList.Add(8);
            linkedList.Add(7);
        }
    }
}
