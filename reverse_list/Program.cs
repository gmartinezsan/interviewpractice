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
            // add node 2
            currentNode.Next = new LinkedListNode(2);
            currentNode = currentNode.Next;
            //add node 3
            currentNode.Next = new LinkedListNode(3);
            currentNode = currentNode.Next;
            // add node 4
            currentNode.Next = new LinkedListNode(4);
            currentNode = currentNode.Next;
            // add node 5
            currentNode.Next = new LinkedListNode(5);
            currentNode = currentNode.Next;
            PrintList(headlist);
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

        static void ReverseList(LinkedListNode headlist)
        {
            var node = headlist;
            while (node.Next !=null)
            {               
                node = node.Next;
            }

            var newhead = node;
            newhead.Next = headlist;
            var currentNode = headlist;
            

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
