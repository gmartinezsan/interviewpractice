using System.Collections.Generic;

namespace Solutions
{
    public static class FindCycleInList
    {
        public static ListNode<T> Solution1<T>(ListNode<T> head)
        {
            ListNode<T> slowPointer = head;
            ListNode<T> fastPointer = head;

            while (slowPointer.Next != null)
            {
                slowPointer = slowPointer.Next;
                fastPointer = fastPointer.Next.Next;
                if (slowPointer == fastPointer)
                    return slowPointer;
            }

            return null;
        }

    }

}