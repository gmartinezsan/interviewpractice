using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int fib(int n)
        {
            if (n == 0 || n == 1)
                return n;

            return fib(n - 1) + fib(n - 2);
        }

    }
}
