using System;

namespace subarray_sum
{
    class Program
    {
        static int[,] result = new int[100,2];

        static void Main(string[] args)
        {            
           int t;           
           if (!Int32.TryParse(Console.ReadLine(), out t))
                return; 
           for (int i = 0; i < t; i++)
           {
              String num_and_sum = Console.ReadLine(); // two numbers
              String array = Console.ReadLine(); // all the numbers for the array 
              var numbers = array.Split(' ');
              var input = num_and_sum.Split(' ');
              subarray_sum(numbers, input, i);              
           }
           for(int i = 0; i < t; i++)
           {
              if (result[i,0] == -1){
                Console.WriteLine(result[i, 0]);
              }
              else
              {
                Console.WriteLine((result[i, 0] + 1 ) + " " + (result[i, 1] + 1));
              }
           }
        }

        static void subarray_sum(string[] numbers, string[] input, int t)
        {
            int sum;
            
            if (!Int32.TryParse(input[1], out sum))
             {
                result[t,0]= -1;
                return;
             }
        
            int sum_r = 0;
            int start_index = 0;    
            int i = 0;
            while(i < numbers.Length)       
            {                                                                        
                if (sum_r == sum)
                {
                    result[t,0]= start_index;
                    result[t,1]= i - 1;
                    return;
                }                
                else if (sum_r > sum)
                {
                    int n;
                    if (Int32.TryParse(numbers[start_index], out n))
                    {
                        sum_r -= n;
                        start_index++;
                    }
                    else
                      break;
                }
                else
                {
                    int n;
                    if (Int32.TryParse(numbers[i], out n))
                    {
                      sum_r += n;
                    }
                    else
                       break;
                    i++; 
                }
            }                     
            result[t,0]= -1;
        }
    }
}
