using System;
using System.Collections.Generic;

namespace permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in GetPermutations("cat"))
            {
                Console.WriteLine(item);
            }
        }


        static HashSet<string> GetPermutations(string word)
        {
            if (word.Length <= 1)
               return new HashSet<string>(){ word };
            
            var permutationsSet = new HashSet<string>();
                       
            for (int i = 0; i < word.Length; i++)
            {                
                var c = word[i];
                char[] newword = word.ToCharArray();
                newword[i] = word[0];
                newword[0]= c;                
                string permutation = string.Empty;
                // var initialPos = i + 1;
                string newWordFromArray = new string(newword);
                for(int j = 0 ; j < newword.Length; j++)
                {
                    permutation = newWordFromArray.Substring(1, j) + c + newWordFromArray.Substring(j + 1, newWordFromArray.Length - (j + 1));
                    if (!permutationsSet.Contains(permutation))
                        permutationsSet.Add(permutation);
                }
            }   

            return permutationsSet;
        }
    }
}
