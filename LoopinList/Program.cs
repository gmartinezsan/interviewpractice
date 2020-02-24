using System;
using System.Collections.Generic;

namespace LoopinList
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new ListNode(3);
            var b = new ListNode(2);
            var c = new ListNode(0);
            var d = new ListNode(4);

            // var e = new ListNode(5);
            // var f = new ListNode(6);
            a.next = b;
            b.next = c;
            c.next = d;
            d.next = b;

            // e.next = f;
            // f.next = b; // loop
            a.next.next.next.next = a;
            // var pos = FoundCycle(a) != null ? FoundCycle(a).val.ToString() : "";
            var found = FoundCycleUsingHashSet(a) != null ? "found" : "not found";
            Console.WriteLine("Cycle {0}", found);
        }

        static ListNode FoundCycle(ListNode head)
        {
            if (head != null && head.next != null)
            {
                int pos = -1;
                ListNode slowPointer = head;

                while (slowPointer != null)
                {
                    var fastPointer = (slowPointer.next).next;
                    pos += 1;
                    Console.WriteLine(slowPointer.val);
                    while (fastPointer != null)
                    {
                        Console.WriteLine(fastPointer.val);
                        if (fastPointer == slowPointer)
                        {
                            // Console.WriteLine(fastPointer.val);
                            // Console.WriteLine(pos);
                            Console.WriteLine("Cycle found at {0}", pos);
                            return slowPointer;
                        }
                        fastPointer =
                            fastPointer.next == slowPointer
                                ? null
                                : fastPointer.next;

                    }

                    slowPointer = slowPointer.next;
                }
                Console.WriteLine("no cycle");
                return null;
            }
            Console.WriteLine("no cycle");
            return null;
        }

        static ListNode FoundCycleUsingHashSet(ListNode head)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();
            ListNode node = head;
            while (node != null)
            {
                if (visited.Contains(node))
                {
                    return node;
                }
                visited.Add (node);
                node = node.next;
            }            
            return null;
        }

        static void PrintList(ListNode headlist)
        {
            var node = headlist;
            while (node.next != null)
            {
                Console.WriteLine(node.val);
                node = node.next;
            }
            Console.WriteLine(node.val);
        }
    }

    public class ListNode
    {
        public int val { get; set; }

        public ListNode next { get; set; }

        public ListNode(int value)
        {
            val = value;
        }
    }
}
