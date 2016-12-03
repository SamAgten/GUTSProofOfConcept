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

namespace SimpleButtons
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

        private void Button1Click(object sender, RoutedEventArgs e)
        {
            string ja = "Ja";
            label1.Content = ja;
            label2.Content = ja;
            label3.Content = ja;
        }

        private void Button2Click(object sender, RoutedEventArgs e)
        {
            string nee = "Nee";
            label1.Content = nee;
            label2.Content = nee;
            label3.Content = nee;
            
        }

        private void Button3Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "A";
            label2.Content = "B";
            label3.Content = "C";
        }
    }
}
