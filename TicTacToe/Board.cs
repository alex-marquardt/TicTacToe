namespace TicTacToe
{
    using System;

    class Board
    {
        public int turns = 0;
        public char[] playingFields = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        // draw the board
        public void DrawBoard()
        {
            Console.WriteLine("|" + playingFields[0] + "|" + playingFields[1] + "|" + playingFields[2] + "|" + "\n" + "|" +  playingFields[3] + "|" + playingFields[4] + "|" + playingFields[5] + "|" + "\n" + "|" + playingFields[6] + "|" + playingFields[7] + "|" + playingFields[8] + "|");
        }
       
        // check for a winner
        public bool CheckForWin(char playerPiece)
        {
            // horizontal win
            if ((playingFields[0] & playingFields[1] & playingFields[2]) == playerPiece || (playingFields[3] & playingFields[4] & playingFields[5]) == playerPiece || (playingFields[6] & playingFields[7] & playingFields[8]) == playerPiece)
            {
                return true;
            }  
            // vertical win
            else if ((playingFields[0] & playingFields[3] & playingFields[6]) == playerPiece || (playingFields[1] & playingFields[4] & playingFields[7]) == playerPiece || (playingFields[2] & playingFields[5] & playingFields[8]) == playerPiece)
            {
                return true;
            }
            // cross win
            else if ((playingFields[0] & playingFields[4] & playingFields[8]) == playerPiece || (playingFields[2] & playingFields[4] & playingFields[6]) == playerPiece)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
    }
}
