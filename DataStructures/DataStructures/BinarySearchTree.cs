using System;

namespace DataStructures
{
    internal class BinarySearchTree
    {
        internal Node rootNode;

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

        #region Copied Delete Code


        // This method mainly calls DeleteRec() 
        public void DeleteData(int data)
        {
            rootNode = DeleteRec(rootNode, data);
        }

        /* A recursive function to insert a new Data in BST */
        private Node DeleteRec(Node node, int deleteData)
        {
            /* Base Case: If the tree is empty */
            if (node == null) return null;

            /* Otherwise, recur down the tree */
            if (deleteData < node.Data)
                node.Left = DeleteRec(node.Left, deleteData);
            else if (deleteData > node.Data)
                node.Right = DeleteRec(node.Right, deleteData);

            // if Data is same as node's Data, then This is the node 
            // to be deleted 
            else
            {
                // node with only one child or no child 
                if (node.Left == null)
                    return node.Right;
                else if (node.Right == null)
                    return node.Left;

                // node with two children: Get the inorder successor (smallest 
                // in the Right subtree) 
                node.Data = MinValue(node.Right);

                // Delete the inorder successor 
                node.Right = DeleteRec(node.Right, node.Data);
            }

            return node;
        }

        private static int MinValue(Node root)
        {
            var minv = root.Data;
            while (root.Left != null)
            {
                minv = root.Left.Data;
                root = root.Left;
            }
            return minv;
        }



        #endregion

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
            /* bst.Delete(5);
             bst.Delete(10);
             bst.Delete(2);
             bst.Delete(13);

            bst.DeleteData(5);
            bst.DeleteData(10);
            bst.DeleteData(13);
            bst.DeleteData(2);*/


            var treeTraversal = new BinaryTreeTraversal();
            treeTraversal.InOrderTraversal(bst.rootNode);
            Console.WriteLine();
            treeTraversal.PreOrderTraversal(bst.rootNode);
            Console.WriteLine();
            treeTraversal.PostOrderTraversal(bst.rootNode);
            Console.WriteLine();
            treeTraversal.LevelOrderTraversal(bst.rootNode);
        }
    }
}