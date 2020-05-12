namespace Binary_Tree.BinaryTree
{
    public class Tree
    {
        Node top;

        public Tree()
        {
            top = null;
        }

        public Tree(int initial)
        {
            top = new Node(initial);
        }

        public void Add(int value)
        {
            if (top == null) //tree is empty
            {
                //add item as base Node
                Node newNode = new Node(value);
                top = newNode;
                return;
            }

            Node currentNode = top;
            bool added = false;
            do
            {
                //traverse tree
                if (value < currentNode.value)
                {
                    //go left
                    if (currentNode.left == null)
                    {
                        //add the item
                        Node newNode = new Node(value);
                        currentNode.left = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                else if (value >= currentNode.value)
                {
                    if (currentNode.right == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.right = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            } while (!added);
        }

        public void AddRc(int value)
        {
            AddR(ref top, value);
        }

        private void AddR(ref Node N, int value)
        {
            if (N == null)
            {
                Node newNode = new Node(value);
                N = newNode;
            }
            else if (value <= N.value)
            {
                AddR(ref N.left, value);
            }
            else if (value >= N.value)
            {
                AddR(ref N.right, value);
            }
        }

        public void Print(Node N, ref string s)
        {
            if (N == null)
                N = top;

            if (N.left != null)
            {
                Print(N.left, ref s);
                s = s + N.value.ToString().PadLeft(3);
            }
            else
            {
                s = s + N.value.ToString().PadLeft(3);
            }

            if (N.right != null)
                Print(N.right, ref s);
        }
    }
}