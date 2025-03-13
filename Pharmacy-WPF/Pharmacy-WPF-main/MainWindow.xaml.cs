using System.Windows;

namespace Pharmacy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
   
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new Home();
        }

        private void Leki_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new Leki();
        }

        private void Recepty_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new Recepty();
        }
    }
}