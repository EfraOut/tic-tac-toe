using System;

class ticatactoe
    {
        static void Main(string[] args)
        {
            string player = choosePlayer("");
            string[] board = createBoard();
            displayBoard(board);
            bool test = true;
            while (test)
            {
                string[] newBoard = playerMove(board, player);
                displayBoard(newBoard);
                player = choosePlayer(player);
            }
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

        static string[] playerMove(string[] board, string player)
        {
            bool dummyTrue = true;
            while (dummyTrue)
            {
                try
                {
                    Console.WriteLine($"Play for {player}:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    board[x - 1] = player;
                    dummyTrue = false;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Try again");
                }
            }
            return board;
        }

        static string choosePlayer(string current)
        {
            string player = "O";
            if (current == "" || current == "O")
            {
                player = "X";
            }
            return player;
        }
    }