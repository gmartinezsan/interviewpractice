using System;
//https://practice.geeksforgeeks.org/problems/word-boggle/0

// Input:
// The first line of input contains an integer T denoting the no of test cases . 
// Then T test cases follow. 
// Each test case contains an integer x denoting the no of words in the dictionary. 
// Then in the next line are x space separated strings denoting the contents of the dictinory.
//  In the next line are two integers N and M denoting the size of the boggle. 
// The last line of each test case contains NxM space separated values of the boggle.

// Output:
// For each test case in a new line print the space separated sorted distinct words of the dictionary which could be formed from the boggle. If no word can be formed print -1.

// Example

// Input: dictionary[] = {"GEEKS", "FOR", "QUIZ", "GO"};
//        boggle[][]   = {{'G','I','Z'},
//                        {'U','E','K'},
//                        {'Q','S','E'}};
// Example:
// Input:
// 1
// 4
// GEEKS FOR QUIZ GO
// 3 3
// G I Z U E K Q S E

// Output:  Following words of dictionary are present
//          GEEKS, QUIZ


namespace wordboggle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("# of cases");                
            // int testCases = int.Parse(Console.ReadLine());

            // for (int t=0; t < testCases; t++)
            // {
            //     Console.WriteLine("# Words for the dictionary");
            //     int w = int.Parse(Console.ReadLine());   
            //     Console.WriteLine("Words for the dictionary");            
            //     var words = Console.ReadLine().Split(' ');
            //     Console.WriteLine("m");
            //     var m = int.Parse(Console.ReadLine());
            //     Console.WriteLine("n");
            //     var n = int.Parse(Console.ReadLine());
            //     Console.WriteLine("Letters");   
            //     string letters = Console.ReadLine();              
            //     var board = new char[m][];
            //     for(int i = 0; i < m ; i++)
            //     {
            //        board[i] = new char[n];
            //        for(int j = 0; j < n; j++)
            //        {
            //           board[i][j] = letters[j]; 
            //        }
            //     }
            // }

           int testCases = 1;
           var words = new string[4]{"GEEKS", "FOR", "QUIZ", "GO"};
           var board = new char[m][];
           board[0] = new char[3]{'G','I', 'Z'};
           board[1] = new char[3]{'U', 'E', 'K'};
           board[2] = new char[3]{'Q', 'S', 'E'};

           

           Console.ReadKey();
        }
    }
}
