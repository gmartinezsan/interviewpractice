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

        public static void PreOrderTraversalIterative()
        { }

        public static void PostOrderTraversalRecursive()
        { }


        public static void PostOrderTraversalIterative()
        { }

    }
}