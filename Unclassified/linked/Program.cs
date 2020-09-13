using System;

namespace linked
{

    public class Node {
        public int value {get; set;}
        public Node next {get; set;}

        public Node(int v)
        {
            this.value = v;
            this.next = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node(45);
            Node b = new Node(23);
            Node c = new Node(11);

            a.next =  b;
            b.next = c;            

            PrintList(a);
        }

        static void PrintList(Node n)
        {
            while(n != null)
            {
                Console.WriteLine("value at node " + n.value);
                n = n.next;
            }
        }
    }
}
