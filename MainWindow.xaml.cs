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
            lblStack1.Content = "Games Played:x Games Won: y";
            lblStack2.Content = "Win Ratio: x%";
            lblStack3.Content = "Turn Player X";
        }

    }
}
