using System.Collections.Generic;

namespace Solutions
{
    public static class TraversingTrees
    {
        public static List<T> PreOrderTraversalRecursive<T>(TreeNode<T> treeNode, List<T> nodes)
        {
            if (treeNode == null)
                return null;

            nodes.Add(treeNode.val);
            PreOrderTraversalRecursive<T>(treeNode.left, nodes);
            PreOrderTraversalRecursive<T>(treeNode.right, nodes);
            return nodes;
        }

        public static List<T> PreOrderTraversalIterative<T>(TreeNode<T> treeNode, List<T> nodes)
        {
            if (treeNode == null)
                return null;

            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();

            stack.Push(treeNode);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                nodes.Add(currentNode.val);

                if (currentNode.right != null)
                {
                    stack.Push(currentNode.right);
                }
                if (currentNode.left != null)
                {
                    stack.Push(currentNode.left);
                }
            }
            return nodes;
        }

        public static void PostOrderTraversalRecursive()
        { }


        public static void PostOrderTraversalIterative()
        { }

    }
}