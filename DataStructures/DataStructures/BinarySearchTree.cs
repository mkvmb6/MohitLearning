using System;

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
                {
                    prevNode.Left = newNode;
                }
                else
                {
                    prevNode.Right = newNode;
                }
                newNode.Parent = prevNode;
            }
        }

        public void Delete(int data)
        {
            var delNode = FindNode(data);
            if (delNode==null)
            {
                Console.WriteLine("Node not present in the tree.");
                return;
            }

            DeleteNode(delNode);

        }

        private void DeleteNode(Node node)
        {
            if (node==rootNode)
            {
                DeleteRootNode();
                return;
            }
            if (node.Left == null && node.Right == null)
            {
                if (node.Parent.Left != null && node.Parent.Left.Data == node.Data)
                {
                    node.Parent.Left = null;
                }
                else
                {
                    node.Parent.Right = null;
                }
                node.Parent = null;
                return;
            }

            if (node.Left == null)
            {
                node.Parent.Right = node.Right;
                node.Right.Parent = node.Parent;
                node.Parent = node.Right = null;
                return;
            }

            if (node.Right == null)
            {
                node.Parent.Left = node.Left;
                node.Left.Parent = node.Parent;
                node.Parent = node.Left = null;
                return;
            }

            node.Left.Parent = node.Parent;
            node.Parent.Left = node.Left;
            node.Left.Right = node.Right;
            node.Left.Right.Parent = node.Left;
            node.Parent = node.Left = node.Right = null;

        }

        private void DeleteRootNode()
        {
            if (rootNode.Left == null && rootNode.Right == null)
            {
                rootNode = null;
            }
            else if (rootNode.Left == null)
            {
                rootNode = rootNode.Right;
                rootNode.Parent = null;
            }
            else if (rootNode.Right == null)
            {
                rootNode = rootNode.Left;
                rootNode.Parent = null;
            }
            else
            {
                var tempNode = rootNode.Right;
                while (tempNode.Left != null)
                {
                    tempNode = tempNode.Left;
                }
                tempNode.Left = rootNode.Left;
                rootNode.Left.Parent = tempNode;
                rootNode = rootNode.Right;
                rootNode.Parent = null;
            }
        }

        private Node FindNode(int data)
        {
            var tempNode = rootNode;
            while (tempNode != null && tempNode.Data != data)
            {
                if (data < tempNode.Data)
                {
                    tempNode = tempNode.Left;
                }
                else
                {
                    tempNode = tempNode.Right;
                }
            }
            return tempNode;
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
            bst.Delete(5);
            bst.Delete(10);
            bst.Delete(2);
            bst.Delete(13);
        }
    }
}