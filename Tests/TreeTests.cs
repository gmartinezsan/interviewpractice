using System;
using Solutions;
using Xunit;

namespace Tests
{
    public class TreeTests : IDisposable
    {
        public TreeNode<int> _rootToValidBinarySearchTree;
        public TreeNode<int> _rootToInvalidBinarySearchTree;
        public TreeNode<int> _rootToBinarySearchTree;

        public TreeTests()
        {
            // Create valid binary search tree for usage in tests
            _rootToValidBinarySearchTree = new TreeNode<int>(5);
            _rootToValidBinarySearchTree.left = new TreeNode<int>(4);
            var rightTree = new TreeNode<int>(6);
            rightTree.left = new TreeNode<int>(3);
            rightTree.right = new TreeNode<int>(7);
            _rootToValidBinarySearchTree.right = rightTree;
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

        public void Dispose()
        {
            _rootToValidBinarySearchTree = null;
        }
    }
}
