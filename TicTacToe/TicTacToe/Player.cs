namespace TicTacToe
{
    class Player
    {
        // choose which player piece based on turn
        public char PlayerPiece(int turns)
        {
            if (turns % 2 == 0)
            {
                return 'X';
            }
            else
            {
                return 'O';
            }
        }
    }
}
