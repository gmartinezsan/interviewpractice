using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// Your input
// "the sky is blue"
// Expected
// "blue is sky the"

namespace Reversewords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("the sky is blue"));
        }

        public static string ReverseWords(string s) {
        
        if (s == null || s.Length == 0 )
            return string.Empty;
        
         string[] splitted_s = s.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);        
         Collection<string> c = new Collection<string>(splitted_s);        
         Stack<string> words = new Stack<string>(c);
        
        return string.Join(' ', words.ToArray());       
    }
    }
}
