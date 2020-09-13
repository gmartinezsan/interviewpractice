using System;

namespace reverse_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a linked list
            var headlist = new LinkedListNode(1);
            var currentNode = headlist;
            // // add node 2
            // currentNode.Next = new LinkedListNode(4);
            // currentNode = currentNode.Next;
            // //add node 3
            // currentNode.Next = new LinkedListNode(5);
            // currentNode = currentNode.Next;
            // // add node 4
            // currentNode.Next = new LinkedListNode(8);
            // currentNode = currentNode.Next;
            // // // add node 5
            // currentNode.Next = new LinkedListNode(6);
            // currentNode = currentNode.Next;
            PrintList(headlist);           
            Console.WriteLine("---");
            PrintList(ReverseList(headlist));

        }

        static void PrintList(LinkedListNode headlist)
        {
            var node = headlist;
            while (node.Next !=null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
            Console.WriteLine(node.Value);
        }

        ///
        /// Reverse a list recursive approach
        ///
        static LinkedListNode ReverseListRecursive(LinkedListNode head)
        {
            return null;
        }



        ///
        /// Reverse a list Iterative approach
        ///
        static LinkedListNode ReverseList(LinkedListNode head)
        {
           var current = head;
           LinkedListNode previous = null;
           LinkedListNode second = current.Next;
           while(current != null)
           {
               current.Next = previous;
               previous = current;
               current = second;
               second = current != null ? current.Next : null;               
           }
           return previous;           
        }
    }

    public class LinkedListNode
    {
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }

        public LinkedListNode(int value)
        {
            Value = value;
        }
    }
}
