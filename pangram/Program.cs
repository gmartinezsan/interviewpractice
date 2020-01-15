using System;

namespace pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            // var t = Console.ReadLine(); // number of tests
            // var tests = 0;
            int[] result = new int[25];
            // if (Int32.TryParse(t, out tests))
            // {
                // for (int i = 0; i < tests; i++)
                // {
                    // var input = Console.ReadLine();
                    // result[i] = IsPanagram(input) ? 1 : 0;
                    Console.WriteLine(IsPanagram("Bawds jog, flick quartz, vex nymph") ? 1 : 0);

                // }
            // }
        }

        static bool IsPanagram(string word)
        {
            int[] alpha = new int[26];
            word = word.ToLowerInvariant();
            foreach(char c in word)
            {
                if (Char.IsLetter(c)) 
                {                    
                   int i = (int)c - 97;
                   alpha[i] = 1;
                }                
            }
            for(int i=0; i < alpha.Length;i++)
            {
                if (alpha[i]==0)
                  return false;
            }
            return true;
        }
    }
}
