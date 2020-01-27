using System;

namespace binarysearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7]{2, 3, 7, 11, 15, 17, 20};
            Console.WriteLine(BinarySearchMethod(numbers, 17));            
            Console.WriteLine(BinarySearchMethod(numbers, 2));                        
        }
    

        public static int BinarySearchMethod(int[] numbers, int x)
        {
            if (numbers.Length == 0) return -1;

            int start = 0;
            int end = numbers.Length - 1;
            
            while(end >= start)
            {
                int mid = start + ((end - start) / 2);
                if (x == numbers[mid])
                {
                  return mid;
                }
                else if (x > numbers[mid])  // x is on the right side
                {
                   start = mid + 1;     
                }
                else // x is on the left side
                {
                    end = mid - 1;
                }            
            }
            return -1;
        }
    }
}
