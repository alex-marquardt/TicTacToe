namespace TicTacToe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Validation
    {

        // collect all validation
        public bool CheckForValidMovie(string selectedField, Board board)
        {
            if (CheckForValidNumber(selectedField))
            {
                return CheckForValidField(selectedField, board);
            }
            else
            {
                return false;
            }
        }

        // check if selectedField is taken
        private bool CheckForValidField(string selectedField, Board board)
        {
            if (board.playingFields[Convert.ToInt32(selectedField) - 1] != 'X' && board.playingFields[Convert.ToInt32(selectedField) - 1] != 'O')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // check if selectedField is a number and is/between 1 and 9
        private bool CheckForValidNumber(string selectedField)
        {
            int number;

            if (int.TryParse(selectedField, out number))
            {
                if (0 < number && number < 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
