using System;

namespace MyDelicatessen.Trees
{
    public class BinaryTreeNode<T>
    {
        private BinaryTreeNode<T> left;
        private BinaryTreeNode<T> right;

        public BinaryTreeNode(T value)
        {
            this.Value = value;
        }

        public BinaryTreeNode<T> Left
        {
            get { return left; }
            set
            {
                this.left = value;
                if (value != null)
                    this.left.Parent = this;
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                return right;
            }
            set
            {
                this.right = value;
                if (value != null)
                    this.right.Parent = this;
            }
        }

        public BinaryTreeNode<T> Parent;
        public T Value;

        public bool Leaf => Left == null && Right == null;
    }

    public class BinarySearchTree<T>
    {
        BinaryTreeNode<T> root;
        int length;

        public void Insert(T value)
        {
            BinaryTreeNode<T> node = new BinaryTreeNode<T>(value);

            if (length == 0)
            {
                root = node;
            }
            else
            {
                while (true)
                {
                    var current = root;

                    if (current.newNode < newNode)
                    {
                        if (current.Right == null)
                        {
                            current.Right = newNode;
                            break;
                        }
                        else
                        {
                            current = current.Right;
                            break;
                        }
                    }
                    else if (current.Left == null)
                    {
                        current.Left = newNode;
                    }
                    else current = current.Left;
                }
            }
        }

        public BinaryTreeNode<T> Lookup(T value)
        {

            var current = root;
            while (true)
            {
                if (current == null || current.Value == value)
                    return current;

                if (value > current.Value) current = current.Right;
                else current = current.Left;
            }
        }

        public void Delete(T value)
        {
            if (root?.Value == value)
            {
                var newRoot = PopSubstitute(root);
                newRoot.Right = root.Right;
                newRoot.Left = root.Left;
                root = newRoot;
                return;
            }

            var current = root;
            while (true)
            {
                if (current == null) return;

                if (value == current.Value)
                {
                    if (!current.Leaf)
                    {
                        {
                            var newCurrent = PopSubstitute(current);
                            newCurrent.Right = current.Right;
                            newCurrent.Left = current.Left;
                        }

                        if (current.Value > current.Parent.Value)
                            current.Parent.Right = newCurrent;
                        else
                            current.Parent.Left = newCurrent;
                    }
                    else if (value < current.Value)
                    {
                        current = current.Left;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
            }
        }

        private BinaryTreeNode<T> PopSubstitute(BinaryTreeNode<T> node)
        {
            if (node.Leaf)
                throw new Exception("Popsubstitute was call with a leaf node.");

            BinaryTreeNode<T> current = null;

            if (node.Right != null)
            {
                //this condition could consider the height of the tree, so the tree is more balanced after that
                current = node.Right;
                while (current.Left != null)
                {
                    current = current.Left;
                }
                current.Parent.Left = null;
            }
            else if (node.Left != null)
            {
                current = node.Left;
                while (current.Right != null)
                {
                    current = current.Right;
                }
                current.Parent.Right = null;
            }

            return current;
        }
    }
}
