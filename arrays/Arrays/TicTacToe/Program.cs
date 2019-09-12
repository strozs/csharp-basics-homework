using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            Console.WriteLine("Lets play TicTacToe");
            Console.WriteLine();

            InitBoard();
            DisplayBoard();

            //Console.Write("'X', choose your location (row, column): ");
            //int input = Convert.ToInt32(Console.ReadLine());

            /*if (input == 00)
            {
                board[0, 0] = Convert.ToChar("X");
                DisplayBoard();
            }*/

            for (int i = 0; i < 5; i++)
            {
                Console.Write("'X', choose your location (row): ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("'X', choose your location (colum): ");
                int colum = Convert.ToInt32(Console.ReadLine());
                board[colum, row] = Convert.ToChar("X");
                DisplayBoard();

                Console.Write("'O', choose your location (row): ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.Write("'O', choose your location (colum): ");
                colum = Convert.ToInt32(Console.ReadLine());
                board[colum, row] = Convert.ToChar("O");
                DisplayBoard();
            }

            if ()
            {

            }



            Console.ReadKey();
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }

        }

        private static void DisplayBoard()
        {
            Console.WriteLine("    " + "0" + "  " + "1" + "  " + "2");
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
