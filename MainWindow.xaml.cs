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
        private int GamesWonCounter = 0;
        private int WinRatioCounter = 0;
        private PlayerEnum PlayerTurnActuator = PlayerEnum.X;
        public MainWindow()
        {
            InitializeComponent();
            ChangeStack();
        }

        private void AddXorO(object sender, MouseButtonEventArgs e)
        {
           
        }

        public void ChangeStack()
        {
            if (GamesPlayedCounter == 0) {
                WinRatioCounter = 0;
            }
            else {
                WinRatioCounter = (GamesWonCounter / GamesPlayedCounter) * 100;
            }
            lblStack1.Content = $"Games Played: {GamesPlayedCounter} Games Won: {GamesWonCounter}";
            lblStack2.Content = $"Win Ratio: {WinRatioCounter}%";
            lblStack3.Content = $"Turn Player {PlayerTurnActuator}";
        }



    }
}
