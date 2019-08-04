namespace TicTacToe
{
    using System;
    using System.Threading;

    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Player player = new Player();
            Validation validation = new Validation();
            string selectedField;
            bool isValid;
            string playAgain;

            // make the turns in the game
            for (; board.turns < 9; board.turns++)
            {
                board.DrawBoard();

                // check for if input number is valid
                do
                {
                    Console.Write("Pick a number (" + player.PlayerPiece(board.turns) + "): ");
                    selectedField = Console.ReadLine();

                    isValid = validation.CheckForValidMovie(selectedField, board);
                } while (!isValid);

                board.playingFields[Convert.ToInt32(selectedField) - 1] = player.PlayerPiece(board.turns);                

                // check for a winner
                if (board.CheckForWin(player.PlayerPiece(board.turns)))
                {
                    board.DrawBoard();

                    Console.WriteLine("WINNER: " + player.PlayerPiece(board.turns));                    
                    
                    Console.Write("Wanna play again? (Y/N)");
                    playAgain = Console.ReadLine();

                    // reset the game
                    if (playAgain == "y" || playAgain == "Y")
                    {                        
                        board = new Board();
                        board.turns--;
                        Console.Clear();                       
                    }
                    else
                    // close the game
                    {
                        Console.WriteLine("Thanks for playing!");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                }
                // check if the game is a draw
                else if (board.turns == 8)
                {
                    Console.WriteLine("No winner...");                          
                    Console.Write("Wanna play again? (Y/N)");                   
                    playAgain = Console.ReadLine();

                    // reset the game
                    if (playAgain == "y" || playAgain == "Y")
                    {                        
                        board = new Board();
                        Console.Clear();
                    }
                }
            }
        }
    }
}
