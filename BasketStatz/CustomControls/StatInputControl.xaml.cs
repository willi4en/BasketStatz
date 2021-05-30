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

namespace BasketStatz.CustomControls
{
    /// <summary>
    /// Interaction logic for StatInputControl.xaml
    /// </summary>
    public partial class StatInputControl : UserControl
    {
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(StatInputControl), new PropertyMetadata(""));


        public int StatValue
        {
            get { return (int)GetValue(StatValueProperty); }
            set { SetValue(StatValueProperty, value); }
        }

        public static readonly DependencyProperty StatValueProperty =
            DependencyProperty.Register("StatValue", typeof(int), typeof(StatInputControl), new PropertyMetadata(0));

        
        public StatInputControl()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Minus_Click(object sender,  RoutedEventArgs e)
        {
            StatValue--;
            statTextBlock.Text = StatValue.ToString();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            StatValue++;
            statTextBlock.Text = StatValue.ToString();
        }
    }
}
