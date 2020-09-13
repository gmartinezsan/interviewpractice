using System;
using System.Collections.Generic;

namespace cleanpath
{
    class Program
    {
        static void Main(string[] args)
        {

            // string mypath = "/home/a/./x/../b//c/";            
            // mypath = mypath.Replace("//", "/");   
            // mypath = mypath.Substring(0, mypath.Length - 1);
            // Console.WriteLine(cleanpath(mypath));                        

            int[] nums = new int[]{0, 0, 1, 2, 2, 3, 3, 4};
            //int[] nums = new int[]{0, 0, 0, 0, 0, 0};

            Console.WriteLine(RemoveDuplicates(nums));            
        }

        static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++) {
                if (nums[j] != nums[i]) {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
            
            // int i = 0;
            // int duplicates = 0;
            // while (i < nums.Length)
            // {   
            //     if (i + 1  == (nums.Length - duplicates))
            //       break;

            //     if (nums[i] == nums[i + 1])
            //     {
            //         int j = i + 1;                    
            //         while (j < nums.Length && nums[j] == nums[i])
            //         {
            //             j++;
            //             duplicates++;
            //         }
            //         var k = i + 1;
            //         var newlenght = nums.Length - i;
            //         while (j < newlenght)
            //         {
            //             nums[k] = nums[j];
            //             k++;
            //             j++;
            //         }
            //     }
            //     i++;
            // }
            // return nums.Length - duplicates;
        }
        static string cleanpath(string path)
        {
            if (path.Length <= 1)
                return path;

            Stack<string> stackOfPath = new Stack<string>();
            var directoryname = string.Empty;
            stackOfPath.Push(path[0].ToString());
            var i = 1;
            while (i < path.Length)
            {
                if (stackOfPath.Peek() == "/" && path[i] == '/')
                {
                    if (directoryname == ".") ;
                    // stackOfPath.Pop();
                    else if (directoryname == "..")
                    {
                        stackOfPath.Pop();
                        stackOfPath.Pop();
                    }
                    else
                    {
                        stackOfPath.Push(directoryname);
                        stackOfPath.Push(path[i].ToString());
                    }
                    directoryname = string.Empty;
                }
                else
                {
                    directoryname += path[i].ToString();
                }
                i++;
            }

            if (directoryname != string.Empty)
                stackOfPath.Push(directoryname);

            var result = string.Empty;
            foreach (string v in stackOfPath)
            {
                result = v + result;
            }
            return result;
        }
    }
}
