using System;

namespace kadanesAlgo
{
    // Write an efficient program to find the sum of contiguous subarray within a one-dimensional array of numbers which has the largest sum.
    // Read the full explanation at https://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
    class Program
    {
        static void Main(string[] args)
        {
            // int[] a = new int[] {-2, -3, 4, -1, -2, 1, 5, -3};

            int[] a = new int[] {-2, 2, 5, -11, 6};            
            int current_sum_at_this_point = a[0];            
            int max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                // current sum at this point or a new sum
                if (current_sum_at_this_point + a[i] > a[i])
                {
                    current_sum_at_this_point += a[i];    
                }
                else
                {
                    current_sum_at_this_point = a[i];
                }                
                max = Math.Max(max, current_sum_at_this_point);
            }

            Console.WriteLine("Max " + max);
        }
    }
}
