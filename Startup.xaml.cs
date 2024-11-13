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

        private void ChooseX(object sender, MouseButtonEventArgs e)
        {

            MainWindow mainWindow = new MainWindow("Image/tic-tac-toe_x.png","X");
            mainWindow.Show();
            this.Close();

        }

        private void ChooseO(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow("Image/tic_tac_toe_o.png","O");
            mainWindow.Show();
            this.Close();
        }
    }
       
}
