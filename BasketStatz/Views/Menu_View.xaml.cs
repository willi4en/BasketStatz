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

namespace BasketStatz.Views
{
    /// <summary>
    /// Interaction logic for Menu_View.xaml
    /// </summary>
    public partial class Menu_View : UserControl
    {
        public Menu_View()
        {
            InitializeComponent();
        }

        private void newGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void endGame_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result;
            result = MessageBox.Show("Team and player statistics will be update.\n" +
                "Are you sure you want to end the game?", "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {

            }
        }

        private void newTeam_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addPlayer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
