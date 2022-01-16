// File Name: Program.cs
// Author: Efrain Gomez
class Program
    {
        static void Main(string[] args)
        {
            string player = choosePlayer("");
            string[] board = createBoard();
            displayBoard(board);
            while (!checkDraw(board) && !checkWinner(board))
            {
                string[] newBoard = playerMove(board, player);
                displayBoard(newBoard);
                player = choosePlayer(player);
            }
            Console.WriteLine("Thank you for playing!");
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
                    x = checkInvalidMove(board, x);
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

        static int checkInvalidMove(string[] board, int playerInput)
        {
            while (board[playerInput - 1] == "X" || board[playerInput - 1] == "O")
            {
                displayBoard(board);
                Console.WriteLine($"Try Again:");
                playerInput = Convert.ToInt32(Console.ReadLine());
            }
            return playerInput;
        }

        static bool checkWinner(string[] board)
        {
            return ((board[0] == "X" && board[1] == "X" && board[2] == "X" || 
                    board[0] == "O" && board[1] == "O" && board[2] == "O")
                    || (board[3] == "X" && board[4] == "X" && board[5] == "X" || 
                    board[3] == "O" && board[4] == "O" && board[5] == "O") 
                    || (board[6] == "X" && board[7] == "X" && board[8] == "X" || 
                    board[6] == "O" && board[7] == "O" && board[8] == "O") 
                    || (board[0] == "X" && board[4] == "X" && board[8] == "X" || 
                    board[0] == "O" && board[4] == "O" && board[8] == "O") 
                    || (board[6] == "X" && board[4] == "X" && board[2] == "X" || 
                    board[6] == "O" && board[4] == "O" && board[2] == "O") 
                    || (board[0] == "X" && board[3] == "X" && board[6] == "X" || 
                    board[0] == "O" && board[3] == "O" && board[6] == "O") 
                    || (board[1] == "X" && board[4] == "X" && board[7] == "X" || 
                    board[1] == "O" && board[4] == "O" && board[7] == "O") 
                    || (board[2] == "X" && board[5] == "X" && board[8] == "X" || 
                    board[2] == "O" && board[5] == "O" && board[8] == "O"));
        }

        static bool checkDraw(string[] board)
        {
            bool draw = true;
            for (int i = 0; i < 9; i++)
            {
                if (board[i] != "X" && board[i] != "O")
                {
                    draw = false;
                    break;
                }
            }
            return draw;
        }
    }