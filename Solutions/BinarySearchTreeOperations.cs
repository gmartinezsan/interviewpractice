using System;

namespace Solutions
{
    public static class BinarySearchTreeOperations
    {
        public static bool IsTreeValidBinarySearchTree(TreeNode<int> node, int? min = null, int? max = null)
        {
            if (node != null)
            {
                if (node.val < min)
                    IsTreeValidBinarySearchTree(node.left, node.val);
                else
                    return false;

                if (node.val > max)
                    IsTreeValidBinarySearchTree(node.right, null, node.val);
                else
                    return false;
            }

            return true;

        }

        public static bool IsValidBST(TreeNode<int> root, int? min = null, int? max = null)
        {
            if (root == null)
                return true;

            if (root.val <= min || root.val >= max)
                return false;

            var left = IsValidBST(root.left, min, root.val);
            var right = IsValidBST(root.right, root.val, max);
            return left && right;
        }


        public static bool Helper(TreeNode<int> node, int? min = null, int? max = null)
        {
            if (node == null)
            {
                return true;
            }

            if ((min.HasValue && node.val <= min) || (max.HasValue && node.val >= max))
            {
                return false;
            }


            return Helper(node.left, min, node.val) && Helper(node.right, node.val, max);
        }

        public static bool IsValidBST_2(TreeNode<int> node) => Helper(node);

    }
}
