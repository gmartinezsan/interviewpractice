using System;

namespace palindrome
{
    class _Program
    {
        static void _Main(string[] args)
        {
            IsPalindrome("A man, a plan, a canal: Panama");
        }

     public static bool IsPalindrome(string s) {
         
      int j=0;
      Boolean result=true;        
      s = s.ToLower();  
      char[] letters = new char[s.Length];          
      for (int i=0; i<s.Length; i++)
      {
         if (Char.IsLetterOrDigit(s[i])){
             letters[j]=s[i];
             j++;
         }
      }

        
      for (int i=0; i<j; i++)
      {
          if (letters[i] == letters[(j-1)-i])               
              {
                  continue;
              }
          else
          {
              result = false;
              return result;
          }       
       }        
      return result;       
    }
    }
}
