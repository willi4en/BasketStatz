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
using BasketStatz.ViewModels;
using BasketStatz.Views;

namespace BasketStatz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            displayContent.Content = new Menu_VM();
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            displayContent.Content = new Menu_VM();
        }

        private void SetStats_Click(object sender, RoutedEventArgs e)
        {
            displayContent.Content = new PlayerStatInput_VM();
        }

        private void PlayerGameStats_Click(object sender, RoutedEventArgs e)
        {
            displayContent.Content = new PlayerCareerStats_VM();
        }

        private void TeamGameStats_Click(object sender, RoutedEventArgs e)
        {
            displayContent.Content = new TeamGameStats_VM();
        }

        private void TeamSeasonStats_Click(object sender, RoutedEventArgs e)
        {
            displayContent.Content = new TeamSeasonStats_VM();
        }



    }
}
