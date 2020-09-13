using System;

namespace reversestring
{
    class Program
    {
        static void Main(string[] args)
        {
           char[] word = new char[]{'h','e','l','l','o'}; 
           ReverseString(word);
           foreach (var c in word)
           {
              Console.Write(c);               
           }
        }

        public static void ReverseString(char[] s)
        {
            int i = s.Length - 1;
            int j = 0;
            char temp;
            while (i >= j)
            {
                temp = s[j];
                s[j] = s[i];
                s[i] = temp;
                j++;
                i--;
            }
        }
    }
}
