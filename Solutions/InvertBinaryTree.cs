using System;
using System.Collections.Generic;

namespace Solutions
{
    /*
    https://leetcode.com/problems/invert-binary-tree/
     
    */
    public static class InvertBinaryTree
    {

        public static TreeNode<int> InvertTreeRecursive(TreeNode<int> node)
        {
            if (node == null)
                return node;

            var right = InvertTreeRecursive(node.right);
            var left = InvertTreeRecursive(node.left);
            node.left = right;
            node.right = left;
            return node;
        }

        public static void InvertTreeIterative(TreeNode<int> treeNode)
        {
            if (treeNode == null)
                return;

            Queue<TreeNode<int>> queue = new Queue<TreeNode<int>>();
            queue.Enqueue(treeNode);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                var temp = node.left;
                node.left = node.right;

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                node.right = temp;
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

        }
    }
}
