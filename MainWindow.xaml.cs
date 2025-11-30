using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace Maron
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

        public void HomePage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Home());
        }
        public void SetsPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Sets());
        }
        public void StatsPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Stats());
        }
        public void SettingsPage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Settings());
        }
    }
}