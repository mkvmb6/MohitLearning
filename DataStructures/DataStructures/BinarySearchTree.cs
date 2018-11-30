namespace DataStructures
{
    public class BinarySearchTree
    {
        private Node rootNode;

        public void Insert(int data)
        {
            var newNode = new Node {Data = data};
            if (rootNode == null)
            {
                rootNode = newNode;
            }
            else
            {
                var tempNode = rootNode;
                var prevNode = rootNode;
                while (tempNode != null)
                {
                    prevNode = tempNode;
                    if (data < tempNode.Data)
                        tempNode = tempNode.Left;
                    else
                        tempNode = tempNode.Right;
                }
                if (data < prevNode.Data)
                    prevNode.Left = newNode;
                else
                    prevNode.Right = newNode;
            }
        }

        private class Node
        {
            public int Data;
            public Node Left;
            public Node Parent;
            public Node Right;
        }
    }

    internal class BST
    {
        private static void Main(string[] args)
        {
            var bst = new BinarySearchTree();
            bst.Insert(5);
            bst.Insert(10);
            bst.Insert(13);
            bst.Insert(2);
        }
    }
}