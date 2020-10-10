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
    }
}
