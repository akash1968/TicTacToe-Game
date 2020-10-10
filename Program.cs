using System;
using System.Runtime.InteropServices;

namespace Tic_Tac_Toe_Workshop
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
             char[] board = createBoard();
        }
        //UC1
        public static char[] createBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';               
            }
            return board;
        }
    }
}
