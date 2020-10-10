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
            showBoard(board);
            char chooseLetter = chooseUserLetter();
        }
        //UC1_Create_Board
        public static char[] createBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';               
            }
            return board;
        }
        //UC2_Choose_Letter_From X & O by User
        public static char chooseUserLetter()
        {
            Console.WriteLine("Choose your Letter: ");
            string chooseLetter = Console.ReadLine();
            return char.ToUpper(chooseLetter[0]);
        }
        //UC3_Show_Board
        public static void showBoard(char[] board)
        {
            Console.WriteLine("\n " + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("-------------");
            Console.WriteLine("\n " + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("-------------");
            Console.WriteLine("\n " + board[7] + " | " + board[8] + " | " + board[9]);
        }

    }
}
