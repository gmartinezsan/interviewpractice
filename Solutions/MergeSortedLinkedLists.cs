using System;
using System.Collections.Generic;

namespace Solutions
{

    /// 
    public static class MergeSortedLinkedLists
    {

        public static ListNode<T> BruteForceSolution<T>(ListNode<T>[] lists)
        {
            if (lists.Length == 0)
                return null;

            List<T> values = new List<T>();
            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i] == null)
                    continue;

                var list = lists[i];
                while (list.Next != null)
                {
                    values.Add(list.val);
                    list = list.Next;
                }

                // add the last node
                values.Add(list.val);
            }
            values.Sort(); // default sorting method in place

            // recreate the singly-linked list
            ListNode<T> dummyhead = new ListNode<T>(default);
            ListNode<T> current = dummyhead;
            foreach (T n in values)
            {
                current.Next = new ListNode<T>(n);
                current = current.Next;
            }

            return dummyhead.Next;

        }


        public static ListNode<T> DivideAndConquer<T>(ListNode<T>[] lists)
        {
            if (lists == null || lists.Length == 0)
            {
                return null;
            }

            return Merge(lists, 0, lists.Length - 1);
        }

        private static ListNode<T> Merge<T>(ListNode<T>[] lists, int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public static ListNode<T> Solution1<T>(ListNode<T>[] lists)
        {
            // using sorted dictionary
            // where the key is the element in the list and the value is the number of times it appears in the lists
            SortedDictionary<T, int> sortDict = new SortedDictionary<T, int>();
            for (int i = 0; i < lists.Length; i++)
            {
                while (lists[i] != null)
                {
                    if (!sortDict.ContainsKey(lists[i].val))
                    {
                        sortDict.Add(lists[i].val, 1);
                    }
                    else
                    {
                        sortDict[lists[i].val]++;
                    }
                    lists[i] = lists[i].Next;
                }
            }
            T val = default(T);
            ListNode<T> newHead = new ListNode<T>(val);
            var currentNode = newHead;
            foreach (var item in sortDict)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    currentNode.Next = new ListNode<T>(item.Key);
                    currentNode = currentNode.Next;
                }
            }

            return newHead.Next;
        }

    }

}