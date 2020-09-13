using System;

namespace nonoverlapping
{
    class Program
    {
        static void Main(string[] args)
        {
            // First examaple
            // [[1,2],[2,3],[3,4],[1,3]]
            int[][] intervals = new int[4][];
            intervals[0] = new int[2]{1,2};
            intervals[1] = new int[2]{2,3};
            intervals[2] = new int[2]{3,4};
            intervals[3] = new int[2]{1,3};

            Console.WriteLine("The minimum number to remove to have only non-overlapping intervals is {0}", EraseOverlapIntervals(intervals));

        }

        public static int EraseOverlapIntervals(int[][] intervals) {
        
        if (intervals.Length == 0)
              return 0;
        
        // for the DP solution we are going to order the intervals based on the ending point
        // then we will traverse each interval checking if an interval is overlapping comparing it
        // with the previous one
        // sort in place
        Array.Sort(intervals, (x, y) => {
            return x[1].CompareTo(y[1]);
        });
        
        int[] dp = new int[intervals.Length];
        
        dp[0] = 1;        
        int result = 1;
        
        for (int i = 1; i < dp.Length; i++)
        {
            int max = 0;
            for (int j = i - 1; j >=0; j--)
            {
                // 1-2
                // 1-4
                if (intervals[j][1] <= intervals[i][0] )
                {
                    max = Math.Max(dp[j], max);
                    break;
                }                
            }
            dp[i] =  Math.Max(max + 1, dp[i - 1]);
            result = Math.Max(result, dp[i]);
        }
        
        return intervals.Length - result;        
    }
    }
}
