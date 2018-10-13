namespace DataStructures
{
  public  class MyHeap
    {
        private Node root;

        private class Node
        {
            public int data;
            public Node left;
            public Node right;
            
        }

        public void Add(int data)
        {
            var newNode = new Node {data = data};

            if (root==null)
            {
                root = newNode;
                return;
            }
            var tempNode = root;
            while (tempNode.left!=null&& tempNode.right!=null)
            
            {
                
            }




            if (tempNode.left == null)
            {
                tempNode.left = newNode;
            }
            else if (tempNode.right == null)
            {
                tempNode.right = newNode;
            }
            //tempNode=tempNode.


        }

    }
}
