using System;

namespace Solutions
{
    public static class BalancedCheckTree
    {
        /*
        https://leetcode.com/problems/balanced-binary-tree/
        */

        //Solution 1 - Naive approach, first getting the height of both trees and then check if the tree is balanced
        // Time Complexity O(N) where N is the number of nodes in the tree, Space Complexity O(h) where h is the height of the tree
        public static bool IsBinaryTreeBalanced<T>(TreeNode<T> treeNode)
        {
            int leftHeight = 0;
            int rightHeight = 0;

            if (treeNode == null)
                return true;

            leftHeight = GetHeight<T>(treeNode.left);

            rightHeight = GetHeight<T>(treeNode.right);

            if (Math.Abs(leftHeight - rightHeight) <= 1 && IsBinaryTreeBalanced<T>(treeNode.left) && IsBinaryTreeBalanced<T>(treeNode.right))
                return true;

            return false;


        }

        private static int GetHeight<T>(TreeNode<T> treeNode)
        {
            if (treeNode == null)
            {
                return 0;
            }

            return 1 + Math.Max(GetHeight<T>(treeNode.left), GetHeight<T>(treeNode.right));
        }


          //Solution 2 - Traverse the tree and 

    }

}