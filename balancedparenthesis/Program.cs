using System;
using System.Collections;

namespace balancedparenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(isbalanced("{()()}") ? "true" : "false");
            // string[] strs = {"flow", "flower", "flight"};
            string[] strs = {"catched", "dogmas", "by"};            
            commonPrefix(strs);
        }


        static string commonPrefix(string[] strs)
        {              
            string longestprefix = string.Empty;
            var currentPrefix = strs[0];
            for(int i=0; i < strs.Length; i++)
            {
                if (currentPrefix == strs[i])
                    continue;            
                int j = 0;
                var newPrefix = string.Empty;
                while(j< currentPrefix.Length)
                {
                    if (strs[i][j] == currentPrefix[j])                
                    {
                        newPrefix += strs[i][j];                            
                    }                       
                        else
                            break;            
                    j++;
                }
                currentPrefix = newPrefix;
            }
            return currentPrefix;
        }

    
        // static bool isbalanced(string exp)
        // {
        //     Stack s = new Stack();
        //     foreach (char c in exp)
        //     {
        //         // check if the character is an opening parenthesis
        //         if (c == '(' || c == '{' || c == '[')
        //         {
        //            s.Push(c);
        //         }
        //         else if (c == ')' || c == '}' || c == ']')
        //         {
        //             if (s.Count == 0) return false;
        //             var p = (char)s.Peek();
        //             switch (c)
        //             {
        //                 case ')':                             
        //                      if (p != '(') return false;
        //                 break;                        
        //                 case '}':
        //                      if (p != '{') return false;
        //                 break;
        //                 case ']':
        //                      if (p != '[') return false;                
        //                 break;
        //             }
        //             s.Pop();
        //         }
        //     }
        //     return s.Count == 0;
        // }
    }
}
