using System;
using System.Collections.Generic;

namespace Solutions
{
    public static class MaximumLengthOfConcatSeq
    {
        public static int MaxLength(IList<string> arr)
        {
            int maxLength = 0;

            if (arr.Count == 1)
                return arr[0].Length;

            HashSet<char> uniqueChars = new HashSet<char>();
            CanAdd(ref uniqueChars, arr[0]);

            for (int i = 0; i < arr.Count - 1; i++)
            {
                //Console.WriteLine("--- " + arr[i]);
                for (int j = i + 1; j < arr.Count; j++)
                {
                    //Console.WriteLine(arr[j]);
                    maxLength = Math.Max(maxLength, CanAdd(ref uniqueChars, arr[j]));
                }
            }
            return maxLength;
        }

        public static int CanAdd(ref HashSet<char> uniqueChars, string b)
        {
            HashSet<char> uniqueCharCopy = new HashSet<char>(uniqueChars);

            for (int j = 0; j < b.Length; j++)
            {
                if (!uniqueChars.Add(b[j]))
                {
                    uniqueChars = uniqueCharCopy;
                    Console.WriteLine("==== " + string.Concat(uniqueChars));
                    return uniqueChars.Count;
                }
            }
            //Console.WriteLine("==== " + string.Concat(uniqueChars));
            return uniqueChars.Count;
        }
    }
}