using System;

namespace tic_tac
{
    class Program
    {
        static void Main(string[] args)
        {
           var b = new tic_tac_board();
           b.addtoken('x', 0,0);
           b.printboard();
        }
    }

    public class tic_tac_board
    {
        char[,] board = new char[3, 3];
        
        public void addtoken(char token, int row, int column){
            board[row,column] = token;
        }

        public void printboard()
        {

         /*    Console.WriteLine(); */
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Char.ToString(board[i,0] == Char.MinValue ? '-' : board[i,0])
                 + "|" + Char.ToString(board[i,1] == Char.MinValue ? '-' : board[i,1]) + "|"
                 + Char.ToString(board[i,2] == Char.MinValue ? '-' : board[i,2]));
            }
        }
    }
}
