using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int GamesPlayedCounter = 0;
        private int XGamesWonCounter = 0;
        private int YGamesWonCounter = 0;  
        private int XWinRatioCounter = 0;
        private int YWinRatioCounter = 0;
        private bool TicTacToed = true;
        private bool WinPlayerX = false;

        private PlayerEnum currentplayer;
        private Board gameBoard;
        private int turnCount;

       
        public MainWindow(PlayerEnum startingPlayer)
        {
            InitializeComponent();

            gameBoard = new Board();
            currentplayer = startingPlayer;

            lblStack3.Content = $"Turn Player {currentplayer}";

            IsTicTacToe();
            ChangeStack();
        }


        public void ChangeStack()
        {
            if (GamesPlayedCounter == 0) {
                XWinRatioCounter = 0;
                YWinRatioCounter = 0;
            }
            else {
                XWinRatioCounter = (XGamesWonCounter / GamesPlayedCounter) * 100;
                YWinRatioCounter = (YGamesWonCounter / GamesPlayedCounter) * 100;
            }
            lblStack1.Content = $"Games Played: {GamesPlayedCounter} Games won by X: {XGamesWonCounter} Games won by Y: {YGamesWonCounter}";
            lblStack2.Content = $"X Win Ratio: {XWinRatioCounter}% Y Win Ratio: {YWinRatioCounter}%";
            
        }

        public void IsTicTacToe()
        {

            if (TicTacToed == true)
            {
                GamesPlayedCounter++;
                if (WinPlayerX == true)
                {
                    XGamesWonCounter++;
                }
                else
                {
                    YGamesWonCounter++;
                }
               
            }
        
        }

       
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {

            Image imageclicked = (Image)sender;

            int row = Grid.GetRow(imageclicked);
            int col = Grid.GetColumn(imageclicked);

            if (gameBoard.IsCellEmpty(row,col))
                if (currentplayer == PlayerEnum.X)
                {
                    imageclicked.Source = new BitmapImage(new Uri($"Image/tic-tac-toe_x.png", UriKind.Relative));
                    gameBoard.MakeMove(row, col,PlayerEnum.X);
                    currentplayer = PlayerEnum.O;
                }
                else if (currentplayer == PlayerEnum.O)
                {


                    imageclicked.Source = new BitmapImage(new Uri($"Image/tic-tac-toe_o.png", UriKind.Relative));
                    gameBoard.MakeMove(row, col, PlayerEnum.O);
                    currentplayer = PlayerEnum.X;
                }

            lblStack3.Content = $"Turn Player {currentplayer}";
            ChangeStack();

        }

        }

      
    }

    
