using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Board
    {
        PlayerEnum[,] board = new PlayerEnum[3, 3];
        PlayerEnum currentPlayer = PlayerEnum.X;
        int x_score_cumulative = 0;
        int y_score_cumulative = 0;
        int[][] positions = new int[3][3];

        public Board()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = PlayerEnum.NONE;
                }
            }
        }

        public bool checkWin()
        {


            return false;
        }


    }
}
