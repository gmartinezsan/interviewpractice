using Solutions;
using Xunit;

namespace LinkedListsTests
{

    public class MergeSortedLinkedListsTests
    {
        private ListNode<int> _headList1;
        private ListNode<int> _headList2;
        private ListNode<int> _headList3;


        [Fact]
        public void CanMergeSortedLinkedLists()
        {
            CreateListsForTests();
            ListNode<int>[] lists = new ListNode<int>[3];
            lists[0] = _headList1;
            lists[1] = _headList2;
            lists[2] = _headList3;

            var actual = MergeSortedLinkedLists.Solution1(lists);
            var expected = new int[] { 1, 1, 2, 3, 4, 4, 5, 6 };

            var i = 0;
            while (actual.Next != null)
            {
                Assert.Equal(expected[i++], actual.val);
                actual = actual.Next;
            }
        }

        [Fact]
        public void CanFindCycleInlist()
        {
            _headList1 = new ListNode<int>(1);
            var secondNode = new ListNode<int>(4);
            secondNode.Next = new ListNode<int>(5);
            secondNode.Next.Next = _headList1;
            _headList1.Next = secondNode;
            Assert.Equal(_headList1, FindCycleInList.Solution1(_headList1));
        }


        private void CreateListsForTests()
        {
            ///[1,4,5],[1,3,4],[2,6]            
            _headList1 = new ListNode<int>(1);
            var secondNode = new ListNode<int>(4);
            secondNode.Next = new ListNode<int>(5);
            _headList1.Next = secondNode;

            _headList2 = new ListNode<int>(1);
            secondNode = new ListNode<int>(3);
            secondNode.Next = new ListNode<int>(4);
            _headList2.Next = secondNode;

            _headList3 = new ListNode<int>(2);
            _headList3.Next = new ListNode<int>(6);
        }

    }

}