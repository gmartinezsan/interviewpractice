using System;

namespace swapnodes
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new ListNode();
            var b = new ListNode();
            var c = new ListNode();
            var d = new ListNode();
            var head = a;

            a.val = 1;
            a.next = b;
            
            b.val = 2;
            b.next = c;

            c.val = 3;
            c.next = d;
            
            d.val = 4;
            d.next = null;

            PrintList(head);
           
            Console.WriteLine("After swap");
            var newlist = SwapPairs(head);

            // PrintList(newlist);
        }

    
        public static void PrintList(ListNode head)
        {
             var current = head;

            while(current != null)
            {
              Console.WriteLine(current.val);
              current = current.next;
            }
        }

       public static ListNode SwapPairs(ListNode head) {
        
        if (head == null || head.next == null) return head;

        ListNode result = head.next;
        //the second node will be the head after all swaps, so we keep a variable with reference to it.

        ListNode firstNode = null;
        ListNode secondNode = null;
        ListNode previousNode = new ListNode();

        int i = 0 ;
        while (head != null && head.next != null)
        {
            firstNode = head;
            secondNode = head.next;
            firstNode.next = secondNode.next;
            secondNode.next = firstNode;

            previousNode.next = secondNode;
            //secondNode will be the first node in the swapped pair. It is used to link previous and current pairs together.
            previousNode = firstNode; 
            //firstNode will be the last node in the swapped pair for the next iteartion.
            head = firstNode.next;
            //we cannot use head.next here because nodes are modified in every iteration and head.next will give false results.
            // PrintList(result);
            // break;
            // if (i == 1)
            //    PrintList(result);
            // i++;
        }

        return result;
        
        
    }

    }

    public class ListNode {
        public int val;
        public ListNode next;
       
    }
}
