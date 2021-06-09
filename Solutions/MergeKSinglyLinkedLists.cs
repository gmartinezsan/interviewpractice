using System.Collections.Generic;

namespace Solutions
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


    public static class MergeSortedLinkedLists2
    {
        public static ListNode MergeSortedNLinkedLists(ListNode[] lists)
        {
            if (lists.Length == 0 || lists == null)
                return null;

            List<int> numbers = new List<int>();

            for (int i = 0; i < lists.Length; i++)
            {
                var node = lists[i];
                while (node.next != null)
                {
                    numbers.Add(node.val);
                    node = node.next;
                }
                // add the last node
                numbers.Add(node.val);
            }

            numbers.Sort(); // O(n log n)

            ListNode dummyhead = new ListNode();
            ListNode current = dummyhead;

            foreach (var item in numbers)
            {
                current.next = new ListNode(item);
                current = current.next;
            }

            return dummyhead.next;

        }


        public static ListNode MergeSortNLinkedListsDAndC(ListNode[] lists)
        {
            return MergeLists(lists, 0, lists.Length - 1);
        }

        public static ListNode MergeLists(ListNode[] lists, int start, int end)
        {
            if (start == end)
            {
                return lists[start];
            }
            else
            {

                // 9
                // start = 0 
                // end = 8
                // mid = 4 
                int mid = start + (end - start / 2);

                ListNode left = MergeLists(lists, start, mid);
                ListNode right = MergeLists(lists, mid + 1, end);

                return Merge(left, right);
            }
        }


        public static ListNode Merge(ListNode a, ListNode b)
        {
            ListNode dummyhead = a;
            ListNode current = dummyhead;

            while(a != null && b != null)
            {
                if (a.val < b.val)
                {
                    current.next = a;
                    a = a.next;
                }
                else
                {
                    current.next = b;
                    b = b.next;
                }

                current = current.next;
            }

            // add the remaining elements

            if (a != null)
            {
                current.next = a;
            }
            else
            {
                current.next = b;
            }

            return dummyhead.next;
        }


    }

}