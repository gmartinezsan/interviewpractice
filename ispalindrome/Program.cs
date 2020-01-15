using System;
using System.Collections.Generic;
using System.Linq;

namespace ispalindrome
{

    public class ListNode<T>
    { 
        public int value;
        public ListNode<T> next;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(ispalindrome("civic") ? "TRUE" : "FALSE" );
            //string test_word = "civic"; true
            // string test_word = "zazazaz";
            // Console.WriteLine(isAnyPalindrome("civic") ? "TRUE" : "FALSE");
            //getFirstNotRepeatingChar("abacabaabacaba");
            //int[][] arr = new int[a.Length][]; 
            char[][] grid = new char[][]
            {
            new char[]{'1','2','3'},
            new char[]{'1','2','3'},
            new char[]{'1','2','3'}
            };

            Console.WriteLine(isSudoku(grid) ? "TRUE" : "FALSE");
        }

        static bool isSudoku(char[][] grid)
        {
            if (grid.Any(row => IsInvalid(row)) || // across rows
                grid.Select((_, i) => i).Any(c => IsInvalid(grid.Select(_ => _[c])))) // down columns
                return false;

            // within sub-grids
            for (int r = 0; r < grid.Length; r += 3)
            {
                for (int c = 0; c < grid.Length; c += 3)
                {
                    if (IsInvalid(grid.Skip(r).Take(3).SelectMany(_ => _.Skip(c).Take(3))))
                        return false;
                }
            }
            return true;

        }

        static bool IsInvalid(IEnumerable<char> numbers)
        {
            var counts = new int[9];
            return numbers.Any(n => n != '.' && counts[n - '1']++ > 0);
        }

        static char getFirstNotRepeatingChar(string s)
        {
            var onlyseenonce = new Dictionary<char, int>();
            var repeated = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (onlyseenonce.ContainsKey(s[i]))
                {
                    if (repeated.Contains(s[i]))
                        continue;
                    else
                    {
                        onlyseenonce.Remove(s[i]);
                        repeated.Add(s[i]);
                    }
                }
                else
                {
                    if (repeated.Contains(s[i]))
                        continue;
                    onlyseenonce.Add(s[i], i);
                }
            }

            Console.WriteLine(onlyseenonce.Count);

            /*  int firstseen = -1;
              char result = '_';

              if (onlyseenonce.Count == 0)
                  return ('_');
              else*/
            foreach (KeyValuePair<char, int> c in onlyseenonce)
            {
                /*if (firstseen == -1 || firstseen > c.Value)
                {
                    firstseen = c.Value;
                    result = c.Key;
                }*/
                Console.WriteLine(c.Key);
            }

            return '_';
        }

        static bool isAnyPalindrome(string test_word)
        {
            char oddchacter = '\0';
            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (char c in test_word)
            {
                if (letters.ContainsKey(c))
                {
                    letters[c] += 1;
                    if ((letters[c] % 2) != 0 && oddchacter == '\0')
                    {
                        oddchacter = c;
                    }
                    else if ((letters[c] % 2) != 0 && oddchacter != '\0')
                    {
                        return false;
                    }

                }
                else
                {
                    letters.Add(c, 1);
                }

            }

            return true;
        }

        static bool ispalindrome(string test_word)
        {
            for (int i = 0; i < test_word.Length; i++)
            {
                var j = test_word.Length - (i + 1);
                if (i == j) break;
                if (i != j && test_word[i] != test_word[j])
                {
                    return false;
                }
            }
            return true;
        }


        static bool islistpalindrome(ListNode<int> l)
        {
            ListNode<int> head = l;
            int countnodes = 0;

            ListNode<int> mid = null;
            ListNode<int> prev = null;
            ListNode<int> current = head;

            while (current != null)
            {
                countnodes++;
                current = current.next;
            }

            int position = 1;
            int middle = countnodes / 2 + 1;
            current = head;

            while (current != null)
            {

                if (position >= middle)
                {
                    //reverse list
                    current = current.next;
                    head.next = prev;
                    prev = head;
                    head = current;
                }
                else
                {
                    prev = current;
                    current = current.next;
                    head = current;
                }

                position++;
            }

            //     Console.WriteLine(prev.value);
            //     return false;

            // prev is the new head
            // comparison of values
            ListNode<int> tail = prev;
            current = l; // set current to the left start of the list
            while (current != tail)
            {
                if (current.value != tail.value)
                {
                    return false;
                }
                current = current.next;
                tail = tail.next;
            }

            return true;
        }


    }
}
