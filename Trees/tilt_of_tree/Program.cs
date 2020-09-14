using System;

/*
563. Binary Tree Tilt
Easy

Given a binary tree, return the tilt of the whole tree.

The tilt of a tree node is defined as the absolute difference between the sum of all left subtree node values and the sum of all right subtree node values. Null node has tilt 0.

The tilt of the whole tree is defined as the sum of all nodes' tilt.

Leetcode link
https://leetcode.com/problems/binary-tree-tilt/

*/

namespace tilt_of_tree
{

    public class Node
    {
        public int val;
        public Node left;
        public Node right;

        public Node(int val_node)
        {
            val = val_node;
        }
    }

    class Program
    {
        static int tiltSum = 0;
        static void Main(string[] args)
        {
            // create a new tree
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            DFS(root);
            Console.WriteLine("Tilt of tree " + tiltSum);
        }

        // public static int FindTilt(Node root)
        // {
        //     DFS (root);
        //     return tiltSum;
        // }

        public static int DFS(Node node)
        {
            if (node == null)
                return 0;

            int sumLeft = DFS(node.left);
            int sumRight = DFS(node.right);  

            tiltSum += Math.Abs(sumLeft - sumRight);

            return node.val + sumLeft + sumRight; 
        }
    }
}
