using Solutions;
using Xunit;

namespace Tests
{
    public class MergeSortedLinkedListsTests
    {
        [Fact]
        public void CanMergeTwoSortedlists()
        {
            int[] a = new int[] { 2, 8, 15, 16, 17, 18 };
            int[] b = new int[] { 5, 9, 12, 13, 14 };

            int[] expected = new int[] { 2, 5, 8, 9, 12, 13, 14, 15, 16, 17, 18 };
            var c = MergeSortingAlgorithms.MergeTwoSortedArrays(a, b);
            Assert.Equal(expected, c);
        }
    }
}