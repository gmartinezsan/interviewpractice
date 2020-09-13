using System;
using System.Collections.Generic;

namespace pair_sums
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n = 5;
            int k = 6;
            int[] arr = new int[] { 1, 2, 3, 4, 3 };

            int output = numberOfWays(arr, k);

            Console.WriteLine("output " + output);
        }

        private static int numberOfWays(int[] arr, int k)
        {
            // Write your code here

            // find the numbers that complete the equality
            // a + b = k    
            // where a is a number in the array arr[i] + arr[j]
            // i and j are different
            // return the list of all the unique pairs (a unique pair where the index are all different in the resulting list)
            // Approach 1
            // brute force: 2 nested loops trying each number from arr pairing with the rest of the numbers in the array O(n)^2
            // use a dictionary to look up for the numbers that match the value of k, the key is the value number and the value is the index of the number
            // use a Hashset to keep a list of the unique pairs found in the array

            Dictionary<int, int> arr_dic = new Dictionary<int, int>();
            HashSet<int[]> pairs = new HashSet<int[]>();
            for (int i = 0; i < arr.Length; i++)
            {
                arr_dic.Add(i, arr[i]);
            }

            // // a = k - b
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     int a = k - arr[i];
            //     if (arr_dic.ContainsValue(a))
            //     {
            //         if (!pairs.Contains(new int[2] { i, arr_dic[a] }) && !pairs.Contains(new int[2] { arr_dic[a], i }))
            //             pairs.Add(new int[2] { i, arr_dic[a] });
            //     }
            // }

            return pairs.Count;
        }
    }
}
}
