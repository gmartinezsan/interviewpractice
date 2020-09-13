//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Solution
{
    /**
    * @param {string[]} words
    * @return {string[]}
    */
    public static string[] reconstruct_alphabet (string[] words) 
    {
       string[] result = new string[] {};
       Dictionary<string, int> alp = new Dictionary<string, int>();

        // Put your code here to                        
        int p = 0;
        for (int index = 0; index < words[0].Length; index++)
        {
            foreach(string s in words)
            {            
                if (s.Length > 0 && index < s.Length)
                {
                   string c = s[index].ToString();
                   if (!alp.ContainsKey(c))
                   {
                      alp[c]= p;
                      p++;
                   }                   
                }
            }
        } 
        result = alp.Keys.ToArray();        
        // Return the result, do not change the structure
        return result;
    }
}

namespace Turing
{
    public class Program
    {
        public static void Main()
        {
            List<string> list_words = new List<string>();
            list_words.Add("ccda");
            list_words.Add("ccbk");
            list_words.Add("cd");
            list_words.Add("a");
            list_words.Add("ab");
            
            // string line;
            // while((line = Console.ReadLine()) != null) { list_words.Add(line); }
            
            string[] words = list_words.ToArray();
            string[] result = Solution.reconstruct_alphabet(words);
            Console.Write(string.Join("", result));
        }
    }
}




// //Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5
// using System;
// using System.Linq;

// class Solution
// {
//     /**
//     * @param {int[]} trip_durations
//     * @param {int} total_hours
//     * @return {int} min_purchases
//     */
//     public static int minPurchases(int[] trip_durations, int total_hours) 
//     {
//         int min_purchases = -1;
//         // Put your code here to calculate min_purchases
//         if (trip_durations.Length == 0)
//           return min_purchases;
                
//         // sort the array
//         trip_durations = trip_durations.OrderBy(t => t).ToArray();
        
//         int i = trip_durations.Length - 1;
//         int remaining = total_hours;
//         min_purchases = 0;
//         while(i >= 0 && remaining > 0)
//         {
//             if (remaining - trip_durations[i] >= 0)
//             {
//                remaining -= trip_durations[i];
//                min_purchases++;               
//             }
//             else
//             {
//                 i--;
//             }         
//         }
//         Console.WriteLine(min_purchases);
//         // Return the result, do not change the structure
//         min_purchases = remaining == 0 ? min_purchases : -1;
//         return min_purchases;
//     }
// }

// namespace Turing
// {
//     public class Program
//     {
//         public static void Main()
//         {
//             // string[] components = Console.ReadLine().Split(' ');
//             // int[] trip_durations = new int[components.Length];
//             // for (int i = 0; i < components.Length; i++) trip_durations[i] = int.Parse(components[i].ToString());
//             // int total_hours = int.Parse(Console.ReadLine());
//             int[] trip_durations = new int[]{5,1,6};
//             int total_hours = 15;
            
//             int min_purchases = Solution.minPurchases(trip_durations, total_hours);
//             Console.Write("{0}", min_purchases);
//         }
//     }
// }