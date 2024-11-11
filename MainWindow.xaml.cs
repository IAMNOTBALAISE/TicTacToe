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

        private PlayerEnum PlayerTurnActuator = PlayerEnum.X;
        private bool TicTacToed = true;
        private bool WinPlayerX = false;
        public MainWindow()
        {
            InitializeComponent();
            IsTicTacToe();
            ChangeStack();
        }

        private void AddXorO(object sender, MouseButtonEventArgs e)
        {
           
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
            lblStack3.Content = $"Turn Player {PlayerTurnActuator}";
        }

        public bool IsTicTacToe()
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
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ChangeImg(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
