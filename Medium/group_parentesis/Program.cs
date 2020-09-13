/*
241. Different Ways to Add Parentheses
Medium

Given a string of numbers and operators, return all possible results from computing all the different possible ways to group numbers and operators. 
The valid operators are +, - and *.

Examples

Input: "2-1-1"
Output: [0, 2]
Explanation: 
((2-1)-1) = 0 
(2-(1-1)) = 2

Example 2:

Input: "2*3-4*5"
Output: [-34, -14, -10, -10, 10]
Explanation: 
(2*(3-(4*5))) = -34 
((2*3)-(4*5)) = -14 
((2*(3-4))*5) = -10 
(2*((3-4)*5)) = -10 
(((2*3)-4)*5) = 10


Solution: Explanation
- The first observation is that we need a way to break out the expression in subparts and finds ways to group them after using the parenthesis
- An expression has three parts: 2 operands and operator, in this case we are using only binary operators, which means we will be trying to group in two parts in general
- Based on this conditions we can think of a technique that can help us to do that. We can think on the divide and conquer approach, which is useful when we have a problem that can be
divided in parts or subproblems, also we can think of Dynamic Programming. 
- Let's try to solve it with divide and conquer. 
- we can see in the expression that we have nodes where the root is an operator and then we have a left part and a right part.
- the most basic and valid expression has only a node, which is a number. It cannot be just an operator because that is not a valid expression and does not have a value. 

*/

using System;
using System.Collections.Generic;

namespace group_parentesis
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "2-1-1";            
            string input = "2*3-4*5";
            List<int> result = EvaluateExpression(input);
            Console.WriteLine("[{0}]",string.Join(",", result));
            // foreach (var item in result)            
            // {
            //     Console.WriteLine(item);
            // }
        }

        static List<int> EvaluateExpression(string input)
        {
             List<int> result = new List<int>();
             int val;

             if (Int32.TryParse(input, out val))
                result.Add(val);
            
             for (int i = 0; i < input.Length; i++)
             {
                 char c = input[i];
                 // here we know that we can break in the expression
                 if (c == '+' || c == '-' || c == '*')
                 {
                      string left = input.Substring(0, i); // if we have 2 + 1, then left is: 2
                      string right = input.Substring(i + 1);  // if we have 2 + 1 then right is: + 1
                      List<int> eval_left = EvaluateExpression(left);
                      List<int> eval_right = EvaluateExpression(right);
                      foreach (var a in eval_left)
                      {
                          foreach (var b in eval_right)
                          {
                              if (c == '+')
                              {
                                  result.Add(a + b);
                              }
                              else if (c == '-')
                              {
                                  result.Add(a - b);
                              }
                              else if (c == '*')
                              {
                                  result.Add(a * b);
                              }
                          }
                      }
                 }
             }

            return result;
        }
        
    }
}
