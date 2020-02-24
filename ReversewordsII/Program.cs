using System;

namespace ReversewordsII
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            char[] s = new char[]{'t','h','e',' ' ,'s','k','y',' ','i','s',' ','b','l','u','e'};
            ReverseWords(s);
        }

        public static void ReverseWords(char[] s)
        {
            if (s == null || s.Length == 0) return;

            int wordsCount = 0;
            foreach (char c in s)
            {
                if (c == ' ') wordsCount++;
            }
            int endIndex = s.Length - 1;
            string word = string.Empty;
            int i = 0;
            int j = 0;
            while (j < endIndex && i < wordsCount)
            {
                if (s[j] == ' ')
                {
                    int k = 0;
                    while (j < endIndex)
                    {
                        s[k] = s[++j];
                        k++;                        
                    }                 
                    endIndex = k - 1;
                    s[k++] = ' ';

                    foreach (char c in word)
                    {
                        s[k++] = c;
                    }
                    j = -1;
                    i++;
                    word = string.Empty;
                }
                else
                {
                    word += s[j];
                }
                j++;
            }
        }
    }
}
