using System;
using System.Collections.Generic;
using Solutions;
using Xunit;

namespace Tests
{
    public class TreeTests : IDisposable
    {
        private TreeNode<int> _rootToValidBinarySearchTree;
        private TreeNode<int> _rootToInvalidBinarySearchTree;
        private TreeNode<int> _rootToBinarySearchTree;
        private TreeNode<int> _rootInvertTest;

        public TreeTests()
        {
            CreateTrees();
        }

        [Fact]
        public void IsTreeValidBST()
        {
            var expected = Solutions.BinarySearchTreeOperations.IsValidBST(_rootToValidBinarySearchTree);
            var actual = Solutions.BinarySearchTreeOperations.IsTreeValidBinarySearchTree(_rootToValidBinarySearchTree);
            Assert.Equal(actual, expected);
        }


        [Fact]
        public void IsTreeValid_2()
        {

            var expected = Solutions.BinarySearchTreeOperations.IsValidBST_2(_rootToValidBinarySearchTree);
            var actual = Solutions.BinarySearchTreeOperations.IsTreeValidBinarySearchTree(_rootToValidBinarySearchTree);
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void InvertTree()
        {
            var expected = new List<int>() { 4, 7, 9, 6, 2, 3, 1 };
            Solutions.InvertBinaryTree.InvertTreeIterative(_rootInvertTest);
            var actual = Solutions.TraversingTrees.PreOrderTraversalRecursive<int>(_rootInvertTest, new List<int>());
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void PrintPreOrder()
        {
            var expected = new List<int>() { 4, 2, 1, 3, 7, 6, 9 };
            var actual = Solutions.TraversingTrees.PreOrderTraversalRecursive<int>(_rootInvertTest, new List<int>());
            Assert.Equal(actual, expected);
        }

        private void CreateTrees()
        {

            // Create valid binary search tree for usage in tests
            _rootToValidBinarySearchTree = new TreeNode<int>(5);
            _rootToValidBinarySearchTree.left = new TreeNode<int>(4);
            var rightTree = new TreeNode<int>(6);
            rightTree.left = new TreeNode<int>(3);
            rightTree.right = new TreeNode<int>(7);
            _rootToValidBinarySearchTree.right = rightTree;

            // Create a tree for invert 

            _rootInvertTest = new TreeNode<int>(4);

            var left = new TreeNode<int>(2);
            left.left = new TreeNode<int>(1);
            left.right = new TreeNode<int>(3);

            var right = new TreeNode<int>(7);
            right.left = new TreeNode<int>(6);
            right.right = new TreeNode<int>(9);

            _rootInvertTest.left = left;
            _rootInvertTest.right = right;

        }

        public void Dispose()
        {
            _rootToValidBinarySearchTree = null;
        }
    }
}
