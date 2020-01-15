using System;
using System.Collections.Generic;

namespace reverseparentheses
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine(processString("foo(bar)baz"));
        //    //foo(bar(baz))blim
        //    Console.WriteLine(processString("foo(bar(baz))blim"));
        //    //    (abc)d(efg)
        //    Console.WriteLine(processString("(abc)d(efg)"));
           //wi(ez)(((il)))(en)
           Console.WriteLine(processString("wi(ez)(((il)))(en)"));
        }

        static string processString(string input)
        {
            string result = string.Empty;
            string strToreverse = string.Empty;
            bool stringstarted = false;
            Stack<char> stack = new Stack<char>();
            foreach (char c in input)
            {                              
                if (c == '(')
                {                  
                  strToreverse += c;   
                  stringstarted = true;  
                  stack.Push(c);            
                }
                else if (c == ')' && stringstarted)
                {
                    stack.Pop();
                    strToreverse +=c;
                    if (stack.Count == 0)
                    {
                        result += reverseString(strToreverse);
                        stringstarted = false;
                        strToreverse = string.Empty;
                    }
                }                
                else
                {
                    if(!stringstarted) result+=c;
                    if(stringstarted) strToreverse += c;
                }
            }
            return result;
        }

        static string reverseString(string t)
        {            
            t = t.Replace("(","").Replace(")", "");
            char[] array = new char[t.Length];
            int forward = 0;
            for (int i = t.Length - 1; i >= 0; i--)
            {
                array[forward++] = t[i];
            }
            return new string(array);
        }
    }
}
