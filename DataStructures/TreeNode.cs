using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Tree<T> where T : IComparable
    {
        private class TreeNode<T>
        {
            public T data;
            public TreeNode<T> left;
            public TreeNode<T> right;

            public TreeNode(T value)
            {
                this.data = value;
            }
        }

        private TreeNode<T> root;

        public Tree() { }

        public void insert(T value)
        {
            if (root == null)
            {
                root = new TreeNode<T>(value);
            } else
            {
                TreeNode<T> workingNode = root;

                while (workingNode != null)
                {
                    if (value.CompareTo(workingNode.data) < 0)
                    {
                        if(workingNode.left == null)
                        {
                            workingNode.left = new TreeNode<T>(value);
                            break;
                        }
                        workingNode = workingNode.left;
                    }
                    else if (value.CompareTo(workingNode.data) > 0)
                    {
                        if(workingNode.right == null)
                        {
                            workingNode.right = new TreeNode<T>(value);
                            break;
                        }
                        workingNode = workingNode.right;
                    }
                }
            }
        }

        public void remove(T value)
        {

        }

        public void printTree()
        {
            printTreeNode(root);
            Console.WriteLine();
        }

        private void printTreeNode(TreeNode<T> node)
        {
            TreeNode<T> workingNode = node;

            if(workingNode.left != null)
            {
                printTreeNode(workingNode.left);
            }
            Console.Write(workingNode.data + ", ");
            if(workingNode.right != null)
            {
                printTreeNode(workingNode.right);
            }
        }
    }
}
