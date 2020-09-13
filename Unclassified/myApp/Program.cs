using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ababcd";            
            CountFrequency_2(s);
        }

        static void CountFrequency_1(string s)
        {        
           for(char a = 'a' ; a <= 'z'; a++)
            {
                int frequency = 0;
                for (int i=0; i < s.Length; i++)
                {
                   if (s[i]==a){
                       frequency++;
                   }                      
                }
                Console.WriteLine("Letter " + a + " - " + frequency);
            }
        }

        static void CountFrequency_2(string s)
        {        
            int[] Frequency = new int[26]; 
            for (int i=0; i < s.Length; i++)
            {
                int index = HashFunction(s[i]);
                Frequency[index]++;                                     
            }
            
            for (int i =0; i < Frequency.Length; i ++)
            {
                Console.WriteLine((char)(i + 'a') + " - " + Frequency[i]);
            }            
        }

        static int HashFunction(char c)
        {
            return (c -'a');
        }
    }
}
