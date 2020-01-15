using System;

namespace Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
        //   Console.WriteLine("Enter the value of M (rows)");
        //   var m = Console.ReadLine();
        //   Console.WriteLine("Enter the value of N (columns)");
        //   var n = Console.ReadLine();     
        PrintSpiralMatrix();
        }

        static void PrintSpiralMatrix()
        {
           int[,] numbers = new int[,] { { 1, 2, 3 }, { 4, 5, 6}, { 7, 8, 9 } };
           var r = numbers.GetLength(0);
           var c = numbers.GetLength(1);

// row 0, all columns

         for(int i = 0; i < c ;i++) {
              Console.Write(numbers[0,i] + ", ");
         }

// all rows, column c
        for(int i = 1; i < r ;i++) {
                Console.Write(numbers[i, c-1] + ", ");
        }

               

        //     for(int i = 0; i < r ;i++)
        //     {
        //        for(int j=0; j < c; j++)
        //        {
                
        //           Console.Write(numbers[i,j] + (i == c-1 && j == r-1 ? " " : ", "));                   
        //        }
        //    }           
        }


    }
}
