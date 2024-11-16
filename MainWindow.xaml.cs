using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        
        private int XWinRatioCounter = 0;
        private int OWinRatioCounter = 0;
       
        private bool WinPlayerX = false;

        private PlayerEnum currentplayer;
        private Board gameBoard;
       
        

        public MainWindow(PlayerEnum startingPlayer)
        {
            InitializeComponent();

            gameBoard = new Board();
            currentplayer = startingPlayer;
           
            lblStack1.Content = $"Games Played: {StateOfGame.GamesPlayedCounter} Games won by X: {StateOfGame.XGamesWonCounter} Games won by Y: {StateOfGame.OGamesWonCounter}";
            lblStack2.Content = $"X Win Ratio: {(StateOfGame.GamesPlayedCounter > 0 ? (int)((StateOfGame.XGamesWonCounter / (double)StateOfGame.GamesPlayedCounter) * 100) : 0)}% Y Win Ratio: {(StateOfGame.GamesPlayedCounter > 0 ? (int)((StateOfGame.OGamesWonCounter / (double)StateOfGame.GamesPlayedCounter) * 100) : 0)}%";

            lblStack3.Content = $"Turn Player {currentplayer}";
        }

        public void ChangeStack()
        {
            if (StateOfGame.GamesPlayedCounter == 0) {
                XWinRatioCounter = 0;
                OWinRatioCounter = 0;
            }
            else {
                XWinRatioCounter = (int)((StateOfGame.XGamesWonCounter / StateOfGame.GamesPlayedCounter) * 100);
                OWinRatioCounter = (int)((StateOfGame.OGamesWonCounter / StateOfGame.GamesPlayedCounter) * 100);
            }
            lblStack1.Content = $"Games Played: {StateOfGame.GamesPlayedCounter} Games won by X: {StateOfGame.XGamesWonCounter} Games won by Y: {StateOfGame.OGamesWonCounter}";
            lblStack2.Content = $"X Win Ratio: {XWinRatioCounter}% Y Win Ratio: {OWinRatioCounter}%";
            
        }

        public void ResetGame()
        {
            
            Startup startup = new Startup();
            startup.Show();
            this.Close();
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

            gameBoard.checkWin(out bool tictactoe, out int Xscore, out int Oscore, out PlayerEnum winner);
            if (tictactoe == true) {

                StateOfGame.GamesPlayedCounter++;
                StateOfGame.XGamesWonCounter = Xscore;
                StateOfGame.OGamesWonCounter = Oscore;
                ChangeStack();
             MessageBoxResult result = MessageBox.Show($"Player {winner} has won! Do you wish to play again?",
                       "Game Over",MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes) {
                  ResetGame();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            
         


            lblStack3.Content = $"Turn Player {currentplayer}";

        }

        }

      
    }

    
