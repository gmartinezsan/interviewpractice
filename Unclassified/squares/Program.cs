using System;

namespace squares
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] A  = new int[7] {5, 3, 7, 6, 2, 1, 4};
        
           SortedSquares(A);

           Console.WriteLine("Array sorted");
           for (int i = 0; i< A.Length; i++) 
           {
               Console.Write(A[i] + ( i== A.Length-1 ? " " : ","));
           }
        }

        public static void SortedSquares(int[] A) {
            // var result = new int[A.Length];
            // result = A;
            // for(var i =0; i < A.Length; i++){
            //     result[i] = (int)System.Math.Pow(A[i],2);
            // }
            //sort resulting array
            SortArray(A, 0, A.Length -1);
        }



        public static int PartitionIndex(int[] numbers, int low, int top)
        {
            int p, i;
            int j = top-1;            
            p = numbers[top];           
              
            for(i = low; i<j; i++)
            {
                if(numbers[i] >= p) // swap to the left to have the minors numbers
                {
                    var aux = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = aux;                                           
                }
                if (!(numbers[j] < p))
                {
                    j--;
                }
            }

            var temp = numbers[j];
            numbers[j] = p;
            numbers[top] = temp;

            return j;

        }
        public static void SortArray(int[] numbers, int low, int top)
        {        
            if (low < top)
            {
                int index = PartitionIndex(numbers, low, top);
                SortArray(numbers, low, index -1);
                SortArray(numbers, index + 1, top);              
            }            
        }
    }
}
