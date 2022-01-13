using System;

class ticatactoe
    {
        static void Main(string[] args)
        {
            string[] board = createBoard();
            displayBoard(board);
        }

        static string[] createBoard()
        {
            string[] board = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

            return board;
        }

        static void displayBoard(string[] board)
        {
            Console.WriteLine();
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
            Console.WriteLine();
        }
    }