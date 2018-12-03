using System;

namespace DataStructures
{
    internal class BinaryTreeTraversal
    {
        public void InOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            InOrderTraversal(node.Left);
            Console.Write($"{node.Data} ");
            InOrderTraversal(node.Right);
        }

        public void PreOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write($"{node.Data} ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public void PostOrderTraversal(Node node)
        {
            if (node == null)
            {
                return;
            }
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write($"{node.Data} ");
        }

        public void LevelOrderTraversal(Node node)
        {
            var queue = new MyQueueWithArray<Node>();
            queue.EnQueue(node);
            while (!queue.IsEmpty())
            {
                var item = queue.DeQueue();
                if (item != null)
                {
                    Console.Write($"{item.Data} ");
                    queue.EnQueue(item.Left);
                    queue.EnQueue(item.Right);
                }
            }
        }
    }
}