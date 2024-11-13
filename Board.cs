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

        public void MakeMove(int row, int column,PlayerEnum player)
        {
            if(IsCellEmpty(row, column))
            {
                board[row, column] = player;
            }
        }

        public bool checkWin(out bool tictactoe, out int Xscore, out int Yscore)
        {
            tictactoe = false;

            //checks for horizontal tictactoes
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (board[i, j] == PlayerEnum.X && !(board[i, j] == PlayerEnum.O) || board[i, j] == PlayerEnum.O && !(board[i, j] == PlayerEnum.X))
                    {
                        if ((board[i + 1, j] == PlayerEnum.X && !(board[i + 1, j] == PlayerEnum.O)) || (board[i + 1, j] == PlayerEnum.O && !(board[i + 1, j] == PlayerEnum.X)))
                        {
                            if ((board[i + 2, j] == PlayerEnum.X && !(board[i + 2, j] == PlayerEnum.O)) || (board[i + 2, j] == PlayerEnum.O && !(board[i + 2, j] == PlayerEnum.X)))
                            {
                                tictactoe |= true;

                                if (board[i, j] == PlayerEnum.X)
                                {
                                    x_score_cumulative++;
                                }
                                else if (board[i, j] == PlayerEnum.O)
                                {
                                    y_score_cumulative++;
                                }
                            }
                        }
                    }

                    else if (board[i, j + 1] == PlayerEnum.X && !(board[i, j + 1] == PlayerEnum.O) || board[i, j + 1] == PlayerEnum.O && !(board[i, j + 1] == PlayerEnum.X))
                    {
                        if ((board[i + 1, j + 1] == PlayerEnum.X && !(board[i + 1, j + 1] == PlayerEnum.O)) || (board[i + 1, j + 1] == PlayerEnum.O && !(board[i + 1, j + 1] == PlayerEnum.X)))
                        {
                            if ((board[i + 2, j + 1] == PlayerEnum.X && !(board[i + 2, j + 1] == PlayerEnum.O)) || (board[i + 2, j + 1] == PlayerEnum.O && !(board[i + 2, j + 1] == PlayerEnum.X)))
                            {
                                tictactoe |= true;

                                if (board[i, j+1] == PlayerEnum.X)
                                {
                                    x_score_cumulative++;
                                }
                                else if (board[i, j + 1] == PlayerEnum.O)
                                {
                                    y_score_cumulative++;
                                }
                            }
                        }
                    }


                    else if (board[i, j + 2] == PlayerEnum.X && !(board[i, j + 2] == PlayerEnum.O) || board[i, j + 2] == PlayerEnum.O && !(board[i, j + 2] == PlayerEnum.X))
                    {
                        if ((board[i + 1, j + 2] == PlayerEnum.X && !(board[i + 1, j + 2] == PlayerEnum.O)) || (board[i + 1, j + 2] == PlayerEnum.O && !(board[i + 1, j + 2] == PlayerEnum.X)))
                        {
                            if ((board[i + 2, j + 2] == PlayerEnum.X && !(board[i + 2, j + 2] == PlayerEnum.O)) || (board[i + 2, j + 2] == PlayerEnum.O && !(board[i + 2, j + 2] == PlayerEnum.X)))
                            {
                                tictactoe |= true;

                                if (board[i, j+2] == PlayerEnum.X)
                                {
                                    x_score_cumulative++;
                                }
                                else if (board[i, j+2] == PlayerEnum.O)
                                {
                                    y_score_cumulative++;
                                }
                            }
                        }
                    }
                }
            }

            //checks for vertical tictactoes
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if (board[i, j] == PlayerEnum.X && !(board[i, j] == PlayerEnum.O) || board[i, j] == PlayerEnum.O && !(board[i, j] == PlayerEnum.X))
                    {
                        if ((board[i, j + 1] == PlayerEnum.X && !(board[i, j + 1] == PlayerEnum.O)) || (board[i, j + 1] == PlayerEnum.O && !(board[i, j + 1] == PlayerEnum.X)))
                        {
                            if ((board[i, j + 2] == PlayerEnum.X && !(board[i, j + 2] == PlayerEnum.O)) || (board[i, j + 2] == PlayerEnum.O && !(board[i, j + 2] == PlayerEnum.X)))
                            {
                                tictactoe |= true;

                                if (board[i, j] == PlayerEnum.X)
                                {
                                    x_score_cumulative++;
                                }
                                else if (board[i, j] == PlayerEnum.O)
                                {
                                    y_score_cumulative++;
                                }

                            }
                        }
                    }

                    if (board[i + 1, j] == PlayerEnum.X && !(board[i + 1, j] == PlayerEnum.O) || board[i + 1, j] == PlayerEnum.O && !(board[i + 1, j] == PlayerEnum.X))
                    {
                        if ((board[i + 1, j + 1] == PlayerEnum.X && !(board[i + 1, j + 1] == PlayerEnum.O)) || (board[i + 1, j + 1] == PlayerEnum.O && !(board[i + 1, j + 1] == PlayerEnum.X)))
                        {
                            if ((board[i + 1, j + 2] == PlayerEnum.X && !(board[i + 1, j + 2] == PlayerEnum.O)) || (board[i + 1, j + 2] == PlayerEnum.O && !(board[i + 1, j + 2] == PlayerEnum.X)))
                            {
                                tictactoe |= true;

                                if (board[i + 1, j] == PlayerEnum.X)
                                {
                                    x_score_cumulative++;
                                }
                                else if (board[i + 1, j] == PlayerEnum.O)
                                {
                                    y_score_cumulative++;
                                }

                            }
                        }
                    }

                    if (board[i + 2, j] == PlayerEnum.X && !(board[i + 2, j] == PlayerEnum.O) || board[i + 2, j] == PlayerEnum.O && !(board[i + 2, j] == PlayerEnum.X))
                    {
                        if ((board[i + 2, j + 1] == PlayerEnum.X && !(board[i + 2, j + 1] == PlayerEnum.O)) || (board[i + 2, j + 1] == PlayerEnum.O && !(board[i + 2, j + 1] == PlayerEnum.X)))
                        {
                            if ((board[i + 2, j + 2] == PlayerEnum.X && !(board[i + 2, j + 2] == PlayerEnum.O)) || (board[i + 2, j + 2] == PlayerEnum.O && !(board[i + 2, j + 2] == PlayerEnum.X)))
                            {
                                tictactoe |= true;

                                if (board[i + 2, j] == PlayerEnum.X)
                                {
                                    x_score_cumulative++;
                                }
                                else if (board[i + 2, j] == PlayerEnum.O)
                                {
                                    y_score_cumulative++;
                                }

                            }
                        }
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                }
            }

                    Xscore = x_score_cumulative;
            Yscore = y_score_cumulative;
            return false;
        }


    }
}
