using System;

namespace MyAtoi
{
    class Program
    {
        static void Main(string[] args)
        {            
            // check how know the ascii for a character in c#
            // var str  = "   -42";
            
            // var str  = "4193 with words";
            // if (str == null || str.Length == 0)
            //     return;            
        // Console.WriteLine(MyAtoI("      +-1"));
        // Console.WriteLine(MyAtoI("+-1"));
        // Console.WriteLine(MyAtoI("      +-abce"));
        // Console.WriteLine(MyAtoI("+1"));
        // Console.WriteLine(MyAtoI("  0000000000012345678"));
        Console.WriteLine(MyAtoI("   +000000000001"));
        Console.WriteLine(MyAtoI("-000000000000001"));
        Console.WriteLine(MyAtoI("words and 987"));
        Console.WriteLine(MyAtoI("+000000000"));
        Console.WriteLine(MyAtoI("2147483648"));
        Console.WriteLine(MyAtoI("-2147483647"));
        Console.WriteLine(MyAtoI("-2147483649"));
        Console.WriteLine(MyAtoI("-6147483648"));
        }  

        static int MyAtoI(string str)
        {
            int i = 0;
            int j = 0;
            int decimalDigit = 1;
            if (String.IsNullOrEmpty(str) || String.IsNullOrWhiteSpace(str))
               return 0;

            while(i < str.Length && str[i] == ' ')                            
                i++;                               
            
            if (!(48 <= (int)str[i] && (int)str[i] <= 59) && (str[i] != '-' && str[i] != '+'))
              return 0;

            if ((str[i] == '-' || str[i] == '+'))
            {
                  decimalDigit = str[i] == '-' ?  -1 : 1;                    
                  i++; 
            }

            if (i < str.Length && !(48 <= (int)str[i]) && ((int)str[i] <= 59))
                return 0;

            while(i < str.Length && str[i] == '0')
                i++;

            j = i;            
            while(j < str.Length && (48 <= (int)str[j]) && ((int)str[j] <= 59))  
              j++;                                                        


            if (j - i > 10)
                return decimalDigit > 0 ? Int32.MaxValue : Int32.MinValue;
            
            int result = 0;          
            j--;
            while (j >= i)
            {                            
                    if ((48 <= (int)str[j]) && ((int)str[j] <= 59))
                    {                                               
                        if (decimalDigit == 1000000000 || decimalDigit == -1000000000)
                        {    
                            long longresult = result;                            
                            if ((longresult + (((long)str[j] % 48) * (long)decimalDigit)) >= Int32.MaxValue)
                                return Int32.MaxValue;                            
                            if ((longresult + (((long)str[j] % 48) * (long)decimalDigit)) <= Int32.MinValue)
                                return Int32.MinValue;
                            result += (((int)str[j] % 48) * decimalDigit);                                                        
                        }
                        else
                        {
                            result += ((int)str[j] % 48) * decimalDigit; 
                            decimalDigit *= 10;                                             
                        }
                    } 
               j--;                       
            }
           
        return result;        
        }               
    }
}    


// public int MyAtoi(string str)
//         {
//             int counter = 0;

//             int factor = 1;

//             str = str.Trim();

//             if (counter<str.Length && (str[0] == '-' || str[0] == '+'))
//             {
//                 if (str[0] == '-')
//                 {
//                     factor = -factor;
//                 }

//                 counter++;
//             }

//             decimal result = 0;

//             while (counter<str.Length && char.IsDigit(str[counter]))
//             {
//                 result = result * 10 + (str[counter] - '0');
                
//                 if (result>int.MaxValue) break;    

//                 counter++;
//             }

//             result = result * factor;

//             if (result > int.MaxValue)
//             {
//                 result = int.MaxValue;
//             }
//             else if (result < int.MinValue)
//             {
//                 result = int.MinValue;
//             }
            
//             return (int)result;
//         }
    
// }

