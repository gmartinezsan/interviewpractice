using System;

/*
Write a program that takes an array A and an index i into A, and rearranges the elements
such that all elements less than A[i] ("pivot") appear first, followed by elements
equal to the pivot, followed by elements greater than the pivot.

This problem is similar than the Sort Colors problem in leetcode. 

75. Sort Colors

Given an array with n objects colored red, white or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white and blue.
Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
Note: You are not suppose to use the library's sort function for this problem.

Example:

Input: [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]

Leetcode link

https://leetcode.com/problems/sort-colors/

*/

namespace dutchFlagProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 0, 2, 1, 1, 0 };

            // this can be solved with the quick sort, partition technique
            // select a pivot, it can start with the last element
            // do the partition using the pivot
            // do the swap of the elements

            dutchFlagProblem(numbers, numbers.Length - 1);
            
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            // if we have only 3 values and we want to make the small values at the beginning 
            // then the middle and larger use this function
            
            Console.WriteLine("Second example");
            numbers = new int[] { 2, 1, 0 };
            
            sortColors(numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }


        // When having only 3 values (0,1,2)
        public static void sortColors(int[] numbers)
        {
            int smaller = 0;
            int equal = 0;
            int larger = numbers.Length;

            while (equal < larger)
            {
                if (numbers[equal] == 0)
                {
                    Swap(numbers, smaller++, equal++);
                }
                else if (numbers[equal] == 1)
                {
                    equal++;
                }
                else
                {
                    Swap(numbers, equal, --larger);
                }
            }
        }



        // Generic solution for any value in the array numbers
        // which makes the array sorted in three groups
        // less than the pivot,
        // equal and larger
        public static void dutchFlagProblem(int[] numbers, int pivotIndex)
        {
            int pivot = numbers[pivotIndex];
            int smaller = 0;
            int equal = 0;
            int larger = numbers.Length;

            while (equal < larger)
            {
                if (numbers[equal] < pivot)
                {
                    Swap(numbers, smaller++, equal++);
                }
                else if (numbers[equal] == pivot)
                {
                    equal++;
                }
                else
                {
                    Swap(numbers, equal, --larger);
                }
            }
        }


        public static void Swap(int[] nums, int source, int target)
        {
            int temp = nums[source];
            nums[source] = nums[target];
            nums[target] = temp;
        }
    }
}
