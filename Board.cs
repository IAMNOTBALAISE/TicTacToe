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

        public bool IsCellEmpty(int row, int column)
        {
            return board[row, column] == PlayerEnum.NONE;
        }

        public void MakeMove(int row, int column, PlayerEnum player)
        {
            if (IsCellEmpty(row, column))
            {
                board[row, column] = player;
            }
        }

        public void ResetEnumsOnBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = PlayerEnum.NONE;
                }
            }
        }

        public bool checkWin(out bool tictactoe, out int Xscore, out int Oscore, out PlayerEnum winner)
        {
            tictactoe = false;
            winner = PlayerEnum.NONE;
            Xscore = StateOfGame.XGamesWonCounter;
            Oscore = StateOfGame.OGamesWonCounter;
            // Checks the rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] != PlayerEnum.NONE && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    tictactoe = true;
                    if (board[i, 0] == PlayerEnum.X)
                    {
                        winner = PlayerEnum.X;
                        StateOfGame.XGamesWonCounter++;
                    }
                    else
                    {
                        StateOfGame.OGamesWonCounter++;
                        winner = PlayerEnum.O;
                    }
                    break;
                }
            }

            // Checks the columns
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] != PlayerEnum.NONE && board[0, j] == board[1, j] && board[1, j] == board[2, j])
                {
                    tictactoe = true;
                    if (board[0, j] == PlayerEnum.X)
                    {
                        winner = PlayerEnum.X;
                        StateOfGame.XGamesWonCounter++;
                    }
                    else
                    {
                        StateOfGame.OGamesWonCounter++;
                        winner = PlayerEnum.O;
                    }
                    break;
                }
            }

            // Checks the diagonals
            if (board[0, 0] != PlayerEnum.NONE && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                tictactoe = true;
                if (board[0, 0] == PlayerEnum.X)
                {
                    winner = PlayerEnum.X;
                    StateOfGame.XGamesWonCounter++;
                }
                else
                {
                    StateOfGame.OGamesWonCounter++;
                    winner = PlayerEnum.O;
                }
            }
            if (board[0, 2] != PlayerEnum.NONE && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                tictactoe = true;
                if (board[0, 2] == PlayerEnum.X)
                {
                    winner = PlayerEnum.X;
                    StateOfGame.XGamesWonCounter++;
                }
                else
                {
                    StateOfGame.OGamesWonCounter++;
                    winner = PlayerEnum.O;
                }


                Xscore = StateOfGame.XGamesWonCounter++;
                Oscore = StateOfGame.OGamesWonCounter++;


            }

            return tictactoe;
        }
    }
}
