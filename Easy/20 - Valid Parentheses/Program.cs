using System;
using System.Collections;

/*

20. Valid Parentheses
Easy

Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false

Leetcode link
https://leetcode.com/problems/valid-parentheses/

*/

namespace balancedparenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("{0}, {1}", "()", isbalanced("()") ? "Parentheses are balanced" : "Parentheses are not balanced");
           Console.WriteLine("{0}, {1}", "()[]{}", isbalanced("()[]{}") ? "Parentheses are balanced" : "Parentheses are not balanced");
           Console.WriteLine("{0}, {1}", "(]", isbalanced("(]") ? "Parentheses are balanced" : "Parentheses are not balanced");
        }
       
        static bool isbalanced(string exp)
        {
            Stack s = new Stack();
            foreach (char c in exp)
            {
                // check if the character is an opening parenthesis
                if (c == '(' || c == '{' || c == '[')
                {
                   s.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (s.Count == 0) return false;
                    var p = (char)s.Peek();
                    switch (c)
                    {
                        case ')':                             
                             if (p != '(') return false;
                        break;                        
                        case '}':
                             if (p != '{') return false;
                        break;
                        case ']':
                             if (p != '[') return false;                
                        break;
                    }
                    s.Pop();
                }
            }
            return s.Count == 0;
        }
    }
}
