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
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for Startup.xaml
    /// </summary>
    public partial class Startup : Window
    {
        public Startup()
        {
            InitializeComponent();
        }

        public void ChoosePlayer(object sender, MouseButtonEventArgs e)
        {

            PlayerEnum startingPlayer;

            if (sender == ImageX)
            {
                startingPlayer = PlayerEnum.X;
            }else if (sender == ImageO)
            {
                startingPlayer= PlayerEnum.O;
            }
            else
            {
                return;
            }

            MainWindow mainWindow = new MainWindow(startingPlayer);
            mainWindow.Show();
            this.Close();

        }

       
    }
       
}
