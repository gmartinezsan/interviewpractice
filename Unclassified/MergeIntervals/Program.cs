using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

/*
56. Merge Intervals

Given a collection of intervals, merge all overlapping intervals.

Example 1:

Input: intervals = [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].
Example 2:

Input: intervals = [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.

leetcode link
https://leetcode.com/problems/merge-intervals/

*/


namespace MergeIntervals
{
    class Program
    {
        const int _max = 1000000;
        static void Main(string[] args)
        {
            var intervals = new int[4][];
            intervals[0] = new int[]{1,3};
            intervals[1] = new int[]{2,6};
            intervals[2] = new int[]{8,10};
            intervals[3] = new int[]{15,18};

            int[][] result = Merge(intervals);
            Console.WriteLine("Solution 1");
            Console.Write("[");                    
            foreach (var item in result)
            {
                Console.Write("[{0},{1}] ", item[0], item[1]);
            }            
            Console.WriteLine("]");

            Console.WriteLine("Solution 2");
            int[][] resultTwo = MergeI(intervals);
            Console.Write("[");                    
            foreach (var item in resultTwo)
            {
                Console.Write("[{0},{1}] ", item[0], item[1]);
            }            
            Console.Write("]");
          
        }

        // Solution one
        public static int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0)
                return intervals;
            
            var s1 = Stopwatch.StartNew();
            // sort the input based on the first number, which is the start of the interval
            intervals = intervals.OrderBy(entry => entry[0]).ToArray();

            // use a list to keep the merged intervals

            List<int[]> merged = new List<int[]>();

            int[] previous_interval = intervals[0];
            merged.Add(previous_interval);

            for (int i = 1; i < intervals.Length; i++)
            {
                int start = intervals[i][0];
                if (start <= previous_interval[1])
                {
                    previous_interval[1] = Math.Max(previous_interval[1], intervals[i][1]);                    
                }
                else
                {
                    previous_interval = intervals[i];
                    merged.Add(previous_interval);
                }
                
            }
            s1.Stop();
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
            return merged.ToArray();
        }

        // Solution 2, using IEnumerable
        public static int[][] MergeI(int[][] intervals)
        {
            if (intervals == null || intervals.Length == 0) return new int[0][];

            var s1 = Stopwatch.StartNew();
            Array.Sort(intervals, (op1, op2) => op1[0].CompareTo(op2[0]));
            var result = GetIntervals().ToArray();
            s1.Stop();            
            Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000000) / _max).ToString("0.00 ns"));
            
            return result;

            IEnumerable<int[]> GetIntervals()
            {
                var current_interval = intervals[0];

                foreach (var interval in intervals)
                {
                    if (current_interval[1] > interval[0])
                        current_interval[1] = Math.Max(current_interval[1], interval[1]);
                    else
                    {
                        yield return current_interval;
                        current_interval = interval;
                    }
                }
                yield return current_interval;
            }           
        }
    }
}
